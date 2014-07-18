using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Model;
using FrbaCommerce;

namespace FrbaCommerce.Generar_Publicacion
{
    public partial class Form1 : Form
    {

        private Publicacion publicacion = new Publicacion();

        public Form1(int id_usuario, DateTime fecha_sistema)
        {
            InitializeComponent();
            publicacion.id_usuario = id_usuario;
            publicacion.fecha_publicacion = fecha_sistema;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //modificar la lista de tildados
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargar en la lista de rubros los que haya en tabla
            lst_rubros.DataSource = ConectorSQL.traerDataTable("CP_LISTAR_RUBROS");
            lst_rubros.DisplayMember = "descripcion";
            lst_rubros.ValueMember = "id_rubro";
            
            //cargar combo visibilidad
            lst_visibilidad.DataSource = ConectorSQL.traerDataTable("CP_LISTAR_VISIBILIDADES",publicacion.id_usuario);
            lst_visibilidad.DisplayMember = "descripcion";
            lst_visibilidad.ValueMember = "id_visibilidad";

            //cargar combo permitir preguntas
            cmb_preguntas.Items.Add("SI");
            cmb_preguntas.Items.Add("NO");
        }

        private void btn_publicar_Click(object sender, EventArgs e)
        {
            //validaciones

            //descripcion de publicacion no vacia
            if (txt_descripcion.Text.Length <= 0)
            {
                MessageBox.Show("La descripcion no puede ser vacia", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //tipo de publicacion
            if (!rb_compra_inmediata.Checked && !rb_subasta.Checked)
            {
                MessageBox.Show("Se debe seleccionar un tipo de publicacion", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //stock numerico entero no nulo ni menor que cero
            int a;
            if (int.TryParse(txt_stock.Text, out a))
            {
                if (a <= 0)
                {
                    MessageBox.Show("El stock no puede ser cero o menor", "Frba Commerce", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    publicacion.stock = a;
                }
            }
            else
            {
                MessageBox.Show("Se debe ingresar un valor de stock entero", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //precio float no nulo ni menor que cero
            float b;
            if (float.TryParse(txt_precio.Text, out b))
            {
                if (b <= 0)
                {
                    MessageBox.Show("El precio no puede ser cero o menor", "Frba Commerce", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    publicacion.precio = b;
                }

            }
            else
            {
                MessageBox.Show("Se debe ingresar un valor para el precio", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //visibilidad obligatoria (solo una)
            if (lst_visibilidad.SelectedItems.Count != 1)
            {
                MessageBox.Show("Se debe seleccionar una visibilidad de la lista", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //permitir preguntas
            if (!cmb_preguntas.Text.Equals("SI") && !cmb_preguntas.Text.Equals("NO"))
            {
                MessageBox.Show("Se debe seleccionar si se permiten o no preguntas", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //rubros obligatoria
            if (lst_rubros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar al menos un rubro de la lista", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //estados de publicacion
            if (!rb_activa.Checked && !rb_pausada.Checked && !rb_borrador.Checked)
            {
                MessageBox.Show("Se debe seleccionar un estado inicial de publicacion", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //asignaciones de variables
            publicacion.descripcion = txt_descripcion.Text;
            if (rb_subasta.Checked)
            {
                publicacion.tipo_publicacion = 2;
            }
            if (rb_compra_inmediata.Checked)
            {
                publicacion.tipo_publicacion = 1;
            }
            //precio y stock ya seteados en validaciones
            string visibStr = ((DataRowView)lst_visibilidad.SelectedItem)["id_visibilidad"].ToString();
            int visibInt = -1;
            if (int.TryParse(visibStr, out visibInt))
            {
                publicacion.visibilidad = visibInt;
            }

            if (cmb_preguntas.Text.Equals("SI"))
            {
                publicacion.permitir_preguntas = 0;
            }
            else { publicacion.permitir_preguntas = 1; }

            //estados de publicacion y fecha de acttivacion
            if (rb_borrador.Checked)
            { 
                publicacion.estado = rb_borrador.Text;
            }
        
            if (rb_activa.Checked)
            { publicacion.estado = rb_activa.Text; }
            
            if (rb_pausada.Checked)
            { publicacion.estado = rb_pausada.Text; }

            publicacion.id = 0;

            //llamar SP de creacion publicacion
            if (rb_compra_inmediata.Checked)
            {
                DataTable dt_publicacion = ConectorSQL.traerDataTable("CP_CREAR_PUBLICACION_INMEDIATA",publicacion.id_usuario,publicacion.estado,publicacion.visibilidad,publicacion.tipo_publicacion,publicacion.descripcion, publicacion.fecha_publicacion , publicacion.permitir_preguntas,publicacion.precio,publicacion.stock);
                publicacion.id = Convert.ToInt32(dt_publicacion.Rows[0][0]);
            }
            else {
                if (rb_subasta.Checked)
                {
                    DataTable dt_publicacion = ConectorSQL.traerDataTable("CP_CREAR_PUBLICACION_SUBASTA", publicacion.id_usuario, publicacion.estado, publicacion.visibilidad, publicacion.tipo_publicacion, publicacion.descripcion, publicacion.fecha_publicacion , publicacion.permitir_preguntas, publicacion.precio);
                    publicacion.id = Convert.ToInt32(dt_publicacion.Rows[0][0]);
                } else {
                    MessageBox.Show("Error, ningun tipo de publicacion seleccionado", "Frba Commerce", MessageBoxButtons.OK);
                    return;
                }
            }

            //una vez cargada la publicacion vinculamos los rubros
            if (publicacion.id > 0)
            {
                foreach (var item in lst_rubros.SelectedItems)
                {
                    string varStr = ((DataRowView)item)["id_rubro"].ToString();
                    int varInt = -1;
                    if (int.TryParse(varStr, out varInt))
                    {
                        ConectorSQL.ejecutarProcedure("CP_INSERTAR_PUBLICACION_RUBRO", publicacion.id, varInt);
                    }
                    else
                    {
                        MessageBox.Show("Error al vincular rubro " + ((DataRowView)item)["descripcion"].ToString() + " a la publicacion", "Frba Commerce", MessageBoxButtons.OK);
                    }
                }

                MessageBox.Show("Publicacion generada exitosamente!", "Frba Commerce", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("Ocurrio algun error al generar la publicacion", "Frba Commerce", MessageBoxButtons.OK);    
            }
        }

        private void rb_subasta_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_subasta.Checked)
            {
                txt_stock.Hide();
                lbl_stock.Hide();
                txt_stock.Text = "1";
            }
        }

        private void rb_compra_inmediata_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_compra_inmediata.Checked)
            {
                txt_stock.Show();
                lbl_stock.Show();
                txt_stock.Text = "";
            }
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            if (txt_descripcion.Text.Length > 255)
            {
                txt_descripcion.Text = txt_descripcion.Text.Substring(0, 255);
            }
        }

    }
}
