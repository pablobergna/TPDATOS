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
        public Form1()
        {
            InitializeComponent();
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
            lst_visibilidad.DataSource = ConectorSQL.traerDataTable("CP_LISTAR_VISIBILIDADES");
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
            
            //fechas
            if (DateTime.Compare(DateTime.Now.Date,cal_fechaVencimiento.SelectionRange.Start.Date) > 0)
            {
                MessageBox.Show("Se debe seleccionar una fecha de vencimmiento mayor o igual al dia actual", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //rubros obligatoria
            if (lst_rubros.SelectedItems.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar al menos un rubro de la lista", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }
            
            //llamar SP de creacion

        }

    }
}
