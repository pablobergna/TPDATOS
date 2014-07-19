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

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class Editar_Publicacion : Form
    {
        private Publicacion publicacion_actual = new Publicacion();
        private Publicacion publicacion_modificada = new Publicacion();
        private string fecha_sistema;

        public Editar_Publicacion(int usuario, DateTime fecha)
        {
            InitializeComponent();
            publicacion_actual.id_usuario = usuario;
            publicacion_modificada.id_usuario = usuario;
            
            fecha_sistema = fecha.ToString("dd/MM/yyyy");
            publicacion_modificada.fecha_publicacion = fecha_sistema;
        }

        private void Editar_Publicacion_Load(object sender, EventArgs e)
        {

            gb_datos.Hide();

            DataTable tabla;

            tabla = ConectorSQL.traerDataTable("EP_LISTAR_PUBLICACIONES", publicacion_actual.id_usuario);

            dg_publicaciones.DataSource = tabla;


        }

        private void dg_publicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtiene id de la publicacion clickeada
            string idStr = dg_publicaciones.Rows[e.RowIndex].Cells["id_publicacion"].Value.ToString();
            int idInt = -1;
            if (int.TryParse(idStr, out idInt))
            {
                publicacion_actual.id = idInt;
                publicacion_modificada.id = idInt;
            }

            //cargar data de publicacion existente
            DataTable tb_publicacion = ConectorSQL.traerDataTable("EP_TRAER_PUBLICACION", publicacion_actual.id);

            //separa casos de subasta y compra inmediata
            Object aux = tb_publicacion.Rows[0]["tipo_publicacion"];
            publicacion_actual.tipo_publicacion = Convert.ToInt32(aux);
            if (publicacion_actual.tipo_publicacion == 1)
            {
                //llena la variable de publicacion_actual y publicacion_modificada
                cargar_pub_actual_compra_inmediata(tb_publicacion);
                //carga los datos en la parte grafica
                llenar_interfaz_compra_inmediata();
            }
            else if (publicacion_actual.tipo_publicacion == 2)
            {
                //llena la variable de publicacion_actual y publicacion_modificada
                cargar_pub_actual_subasta(tb_publicacion);
                //carga los datos en la parte grafica
                llenar_interfaz_subasta();
            }
                

       

            bloquear_campos();

            //cargar los combos y listas con todas las posibilidades
            cargar_listas_combos();

            gb_datos.Show();

            //para guardar los rubros borrar todo y revincular
        }

        private void llenar_interfaz_compra_inmediata()
        {
            txt_descripcion.Text = publicacion_actual.descripcion;

            rb_compra_inmediata.Checked = true;
            rb_subasta.Checked = false;

            txt_stock.Text = Convert.ToString(publicacion_actual.stock);

            txt_precio.Text = Convert.ToString(publicacion_actual.precio);

            if (publicacion_actual.permitir_preguntas == 0)
                cmb_preguntas.SelectedIndex = cmb_preguntas.FindStringExact("SI");
            else
                cmb_preguntas.SelectedIndex = cmb_preguntas.FindStringExact("NO");

            //logica de estados
            if (publicacion_actual.estado.Equals("BORRADOR"))
            {
                rb_borrador.Enabled = true;
                rb_borrador.Checked = true;
                //posibilidades
                rb_activa.Enabled = true;
                rb_activa.Checked = false;

                rb_pausada.Enabled = true;
                rb_pausada.Checked = false;

                rb_finalizada.Enabled = false;
                rb_finalizada.Checked = false;

                habilitar_cosas_borrador_ci();
            }

            if (publicacion_actual.estado.Equals("ACTIVA"))
            {
                rb_activa.Enabled = true;
                rb_activa.Checked = true;

                
                //posibilidades
                rb_borrador.Enabled = false;
                rb_borrador.Checked = false;

                rb_pausada.Enabled = true;
                rb_pausada.Checked = false;

                rb_finalizada.Enabled = true;
                rb_finalizada.Checked = false;

                habilitar_cosas_activa_ci();
            }

            if (publicacion_actual.estado.Equals("PAUSADA"))
            {
                rb_pausada.Enabled = true;
                rb_pausada.Checked = true;

                //posibilidades
                rb_borrador.Enabled = false;
                rb_borrador.Checked = false;

                rb_activa.Enabled = true;
                rb_activa.Checked = false;

                rb_finalizada.Enabled = true;
                rb_finalizada.Checked = false;

                habilitar_cosas_pausada_ci();
            }

            if (publicacion_actual.estado.Equals("FINALIZADA"))
            {
                rb_finalizada.Enabled = false;
                rb_finalizada.Checked = true;

                //posibilidades
                rb_borrador.Enabled = false;
                rb_borrador.Checked = false;

                rb_activa.Enabled = false;
                rb_activa.Checked = false;

                rb_pausada.Enabled = false;
                rb_pausada.Checked = false;

                habilitar_cosas_finalizada_ci();
            }


        }

        private void habilitar_cosas_finalizada_ci()
        {
            txt_descripcion.Enabled = false;

            rb_subasta.Enabled = false;

            rb_compra_inmediata.Enabled = false;

            txt_stock.Enabled = false;

            txt_precio.Enabled = false;

            lst_visibilidad.Enabled = false;

            cmb_preguntas.Enabled = false;

            lst_pool_rubros.Enabled = false;

            lst_rubros_actuales.Enabled = false;

            btn_agregar_rubro.Enabled = false;

            btn_sacar_rubro.Enabled = false;

            bt_guardar.Enabled = false;
        }

        private void habilitar_cosas_pausada_ci()
        {
            txt_descripcion.Enabled = false;

            rb_subasta.Enabled = false;

            rb_compra_inmediata.Enabled = false;

            txt_stock.Enabled = false;

            txt_precio.Enabled = false;

            lst_visibilidad.Enabled = false;

            cmb_preguntas.Enabled = false;

            lst_pool_rubros.Enabled = false;

            lst_rubros_actuales.Enabled = false;

            btn_agregar_rubro.Enabled = false;

            btn_sacar_rubro.Enabled = false;

            bt_guardar.Enabled = true;

        }

        private void habilitar_cosas_activa_ci()
        {
            txt_descripcion.Enabled = true;

            rb_subasta.Enabled = false;

            rb_compra_inmediata.Enabled = false;

            txt_stock.Enabled = true;

            txt_precio.Enabled = false;

            lst_visibilidad.Enabled = false;

            cmb_preguntas.Enabled = false;

            lst_pool_rubros.Enabled = false;

            lst_rubros_actuales.Enabled = false;

            btn_agregar_rubro.Enabled = false;

            btn_sacar_rubro.Enabled = false;

            bt_guardar.Enabled = true;

        }


        private void habilitar_cosas_borrador_ci()
        {
            txt_descripcion.Enabled = true;

            rb_subasta.Enabled = true;

            rb_compra_inmediata.Enabled = true;

            txt_stock.Enabled = true;

            txt_precio.Enabled = true;

            lst_visibilidad.Enabled = true;

            cmb_preguntas.Enabled = true;

            lst_pool_rubros.Enabled = true;

            lst_rubros_actuales.Enabled = true;

            btn_agregar_rubro.Enabled = true;

            btn_sacar_rubro.Enabled = true;

            bt_guardar.Enabled = true;

        }




        private void llenar_interfaz_subasta()
        {

            txt_descripcion.Text = publicacion_actual.descripcion;

            rb_compra_inmediata.Checked = false;
            rb_subasta.Checked = true;

            txt_stock.Text = Convert.ToString(publicacion_actual.stock);

            txt_precio.Text = Convert.ToString(publicacion_actual.precio);

            if (publicacion_actual.permitir_preguntas == 0)
                cmb_preguntas.SelectedIndex = cmb_preguntas.FindStringExact("SI");
            else
                cmb_preguntas.SelectedIndex = cmb_preguntas.FindStringExact("NO");

            //logica de estados
            if (publicacion_actual.estado.Equals("BORRADOR"))
            {
                rb_borrador.Enabled = true;
                rb_borrador.Checked = true;
                //posibilidades
                rb_activa.Enabled = true;
                rb_activa.Checked = false;

                rb_pausada.Enabled = true;
                rb_pausada.Checked = false;

                rb_finalizada.Enabled = false;
                rb_finalizada.Checked = false;

                habilitar_cosas_borrador_su();
            }

            if (publicacion_actual.estado.Equals("ACTIVA"))
            {
                rb_activa.Enabled = true;
                rb_activa.Checked = true;


                //posibilidades
                rb_borrador.Enabled = false;
                rb_borrador.Checked = false;

                rb_pausada.Enabled = false;
                rb_pausada.Checked = false;

                rb_finalizada.Enabled = false;
                rb_finalizada.Checked = false;

                habilitar_cosas_activa_pausada_finalizada_su();
            }

            if (publicacion_actual.estado.Equals("PAUSADA"))
            {
                rb_pausada.Enabled = true;
                rb_pausada.Checked = true;

                //posibilidades
                rb_borrador.Enabled = false;
                rb_borrador.Checked = false;

                rb_activa.Enabled = false;
                rb_activa.Checked = false;

                rb_finalizada.Enabled = false;
                rb_finalizada.Checked = false;

                habilitar_cosas_activa_pausada_finalizada_su();
            }

            if (publicacion_actual.estado.Equals("FINALIZADA"))
            {
                rb_finalizada.Enabled = false;
                rb_finalizada.Checked = true;

                //posibilidades
                rb_borrador.Enabled = false;
                rb_borrador.Checked = false;

                rb_activa.Enabled = false;
                rb_activa.Checked = false;

                rb_pausada.Enabled = false;
                rb_pausada.Checked = false;

                habilitar_cosas_activa_pausada_finalizada_su();
            }

        }

        private void habilitar_cosas_activa_pausada_finalizada_su()
        {
            txt_descripcion.Enabled = false;

            rb_subasta.Enabled = false;

            rb_compra_inmediata.Enabled = false;

            txt_stock.Enabled = false;

            txt_precio.Enabled = false;

            lst_visibilidad.Enabled = false;

            cmb_preguntas.Enabled = false;

            lst_pool_rubros.Enabled = false;

            lst_rubros_actuales.Enabled = false;

            btn_agregar_rubro.Enabled = false;

            btn_sacar_rubro.Enabled = false;

            bt_guardar.Enabled = false;

        }

        private void habilitar_cosas_borrador_su()
        {
            txt_descripcion.Enabled = true;

            rb_subasta.Enabled = true;

            rb_compra_inmediata.Enabled = true;

            txt_stock.Enabled = true;

            txt_precio.Enabled = true;

            lst_visibilidad.Enabled = true;

            cmb_preguntas.Enabled = true;

            lst_pool_rubros.Enabled = true;

            lst_rubros_actuales.Enabled = true;

            btn_agregar_rubro.Enabled = true;

            btn_sacar_rubro.Enabled = true;

            bt_guardar.Enabled = true;

        }

        private void cargar_listas_combos()
        {

            //Cargar en la lista de rubros los que haya en tabla
            lst_pool_rubros.DataSource = ConectorSQL.traerDataTable("EP_LISTAR_RUBROS_FALTANTES", publicacion_actual.id);
            lst_pool_rubros.DisplayMember = "descripcion";
            lst_pool_rubros.ValueMember = "id_rubro";

            lst_rubros_actuales.DataSource = ConectorSQL.traerDataTable("EP_LISTAR_RUBROS_PUBLICACION", publicacion_actual.id);
            lst_rubros_actuales.DisplayMember = "descripcion";
            lst_rubros_actuales.ValueMember = "id_rubro";

            //cargar combo visibilidad
            lst_visibilidad.DataSource = ConectorSQL.traerDataTable("CP_LISTAR_VISIBILIDADES", publicacion_actual.id_usuario);
            lst_visibilidad.DisplayMember = "descripcion";
            lst_visibilidad.ValueMember = "id_visibilidad";

            //cargar combo permitir preguntas
            cmb_preguntas.Items.Clear();
            cmb_preguntas.Items.Add("SI");
            cmb_preguntas.Items.Add("NO");

            //agregar que seleccione de cada lista y combo el valor de la publicacion actual



            //cargar rubros vinculados
            DataTable tb_rubros = ConectorSQL.traerDataTable("EP_TRAER_RUBROS", publicacion_actual.id);

        }

        private void cargar_pub_actual_compra_inmediata(DataTable pub)
        {
            Object aux;

            //descripcion
            aux =  pub.Rows[0]["descripcion"];
            publicacion_actual.descripcion = Convert.ToString(aux);
            publicacion_modificada.descripcion = Convert.ToString(aux);

            //tipo publicacion
            aux = pub.Rows[0]["tipo_publicacion"];
            publicacion_actual.tipo_publicacion = Convert.ToInt32(aux);
            publicacion_modificada.tipo_publicacion = Convert.ToInt32(aux);

            //stock
            aux = pub.Rows[0]["stock"];
            publicacion_actual.stock = Convert.ToInt32(aux);
            publicacion_modificada.stock = Convert.ToInt32(aux);

            //precio
            aux = pub.Rows[0]["precio"];
            publicacion_actual.precio = Convert.ToSingle(aux);
            publicacion_modificada.precio = Convert.ToSingle(aux);

            //visibilidad
            aux = pub.Rows[0]["id_visibilidad"];
            publicacion_actual.visibilidad = Convert.ToInt32(aux);
            publicacion_modificada.visibilidad = Convert.ToInt32(aux);

            //permite_preguntas
            aux = pub.Rows[0]["f_preguntas"];
            publicacion_actual.permitir_preguntas = Convert.ToInt32(aux);
            publicacion_modificada.permitir_preguntas = Convert.ToInt32(aux);

            //estado
            aux = pub.Rows[0]["desc_estado"];
            publicacion_actual.estado = Convert.ToString(aux);
            publicacion_modificada.estado = Convert.ToString(aux);
        }


        private void cargar_pub_actual_subasta(DataTable pub)
        {
            Object aux;

            //descripcion
            aux = pub.Rows[0]["descripcion"];
            publicacion_actual.descripcion = Convert.ToString(aux);
            publicacion_modificada.descripcion = Convert.ToString(aux);

            //tipo publicacion
            aux = pub.Rows[0]["tipo_publicacion"];
            publicacion_actual.tipo_publicacion = Convert.ToInt32(aux);
            publicacion_modificada.tipo_publicacion = Convert.ToInt32(aux);

            //stock
            publicacion_actual.precio = Convert.ToSingle(0);
            publicacion_modificada.precio = Convert.ToSingle(0);

            //precio
            aux = pub.Rows[0]["precio_inicial"];
            publicacion_actual.precio = Convert.ToSingle(aux);
            publicacion_modificada.precio = Convert.ToSingle(aux);

            //visibilidad
            aux = pub.Rows[0]["id_visibilidad"];
            publicacion_actual.visibilidad = Convert.ToInt32(aux);
            publicacion_modificada.visibilidad = Convert.ToInt32(aux);

            //permite_preguntas
            aux = pub.Rows[0]["f_preguntas"];
            publicacion_actual.permitir_preguntas = Convert.ToInt32(aux);
            publicacion_modificada.permitir_preguntas = Convert.ToInt32(aux);

            //estado
            aux = pub.Rows[0]["desc_estado"];
            publicacion_actual.estado = Convert.ToString(aux);
            publicacion_modificada.estado = Convert.ToString(aux);

        }

        private void bloquear_campos()
        {

        }

        private void btn_agregar_rubro_Click(object sender, EventArgs e)
        {
            if (lst_pool_rubros.SelectedItems.Count > 0)
            {
                DataRowView rowView = lst_pool_rubros.SelectedItem as DataRowView;

                if (null == rowView)
                {
                    return;
                }

                //da.Rows.Remove(rowView.Row);

                //DataRowView aux = lst_pool_rubros.SelectedItem;
                //lst_rubros_actuales.Items.Add(aux);
                //lst_pool_rubros.Items.Remove(aux);
            }
        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int valor;
                string theText = textBox.Text;
                publicacion_modificada.descripcion = theText;
            }
        }

        private void rb_subasta_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_subasta.Checked)
                publicacion_modificada.tipo_publicacion = 2;
            
        }

        private void rb_compra_inmediata_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_compra_inmediata.Checked) 
                publicacion_modificada.tipo_publicacion = 1;
        }

        private void txt_stock_TextChanged(object sender, EventArgs e)
        {
            if (publicacion_actual.estado.Equals("ACTIVA"))
            {
                TextBox textBox = sender as TextBox;
                if(textBox != null)
                {
                    int valor;
                    string theText = textBox.Text;
                    if (int.TryParse(theText, out valor))
                    {
                        if (valor < publicacion_actual.stock)
                        {
                            MessageBox.Show("No puede ingresarse un stock menor al original", "Frba Commerce", MessageBoxButtons.OK);
                            txt_stock.Text = publicacion_actual.stock.ToString();
                        }
                        else
                        {
                            publicacion_modificada.stock = valor;
                        }
                    }
                    else 
                    {
                        MessageBox.Show("El stock debe estar solo en numeros enteros", "Frba Commerce", MessageBoxButtons.OK);
                        txt_stock.Text = publicacion_actual.stock.ToString();
                    }
                }
            }
            else if (publicacion_actual.estado.Equals("BORRADOR"))
            {
                TextBox textBox = sender as TextBox;
                if(textBox != null)
                {
                    int valor;
                    string theText = textBox.Text;
                    if (int.TryParse(theText, out valor))
                    {
                        publicacion_modificada.stock = valor;
                    }
                    else 
                    {
                        MessageBox.Show("El stock debe estar solo en numeros enteros", "Frba Commerce", MessageBoxButtons.OK);
                        txt_stock.Text = publicacion_actual.stock.ToString();
                    }
                }
            }
            else txt_stock.Text = publicacion_actual.stock.ToString();

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                float valor;
                string theText = textBox.Text;
                if (float.TryParse(theText, out valor))
                {
                    publicacion_modificada.precio = valor;
                }
                else
                {
                    MessageBox.Show("El precio no permite caracteres alfanumericos", "Frba Commerce", MessageBoxButtons.OK);
                    txt_precio.Text = publicacion_actual.precio.ToString();
                }
            }
        }

        private void lst_visibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lista = sender as ListBox;
            string visibStr = ((DataRowView)lista.SelectedItem)["id_visibilidad"].ToString();
            int visibInt = -1;
            if (int.TryParse(visibStr, out visibInt))
            {
                publicacion_modificada.visibilidad = visibInt;
            }
            else publicacion_modificada.visibilidad = publicacion_actual.visibilidad;
        }

        private void cmb_preguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;

            if (combo.Text.Equals("SI"))
                publicacion_modificada.permitir_preguntas = 0;
            if (combo.Text.Equals("NO"))
                publicacion_modificada.permitir_preguntas = 1;

        }

        private void rb_borrador_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_borrador.Checked)
            {
                publicacion_modificada.estado = "BORRADOR";
            }
        }

        private void rb_activa_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_activa.Checked)
            {
                publicacion_modificada.estado = "ACTIVA";
            }
        }

        private void rb_pausada_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_pausada.Checked)
            {
                publicacion_modificada.estado = "PAUSADA";
            }
        }

        private void rb_finalizada_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_finalizada.Checked)
            {
                publicacion_modificada.estado = "FINALIZADA";
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {

            int a = validaciones_de_datos();
            if (a == -1) return

        }

        private int validaciones_de_datos()
        {

            //descripcion de publicacion no vacia
            if (txt_descripcion.Text.Length <= 0)
            {
                MessageBox.Show("La descripcion no puede ser vacia", "Frba Commerce", MessageBoxButtons.OK);
                return -1;
            }

            //tipo de publicacion
            if (!rb_compra_inmediata.Checked && !rb_subasta.Checked)
            {
                MessageBox.Show("Se debe seleccionar un tipo de publicacion", "Frba Commerce", MessageBoxButtons.OK);
                return -1;
            }

            //stock numerico entero no nulo ni menor que cero
            int a;
            if (int.TryParse(txt_stock.Text, out a))
            {
                if (a <= 0)
                {
                    MessageBox.Show("El stock no puede ser cero o menor", "Frba Commerce", MessageBoxButtons.OK);
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Se debe ingresar un valor de stock entero", "Frba Commerce", MessageBoxButtons.OK);
                return -1;
            }

            //precio float no nulo ni menor que cero
            float b;
            if (float.TryParse(txt_precio.Text, out b))
            {
                if (b <= 0)
                {
                    MessageBox.Show("El precio no puede ser cero o menor", "Frba Commerce", MessageBoxButtons.OK);
                    return -1;
                }
            }
            else
            {
                MessageBox.Show("Se debe ingresar un valor para el precio", "Frba Commerce", MessageBoxButtons.OK);
                return -1;
            }

            //visibilidad obligatoria (solo una)
            if (lst_visibilidad.SelectedItems.Count != 1)
            {
                MessageBox.Show("Se debe seleccionar una visibilidad de la lista", "Frba Commerce", MessageBoxButtons.OK);
                return -1;
            }

            //permitir preguntas
            if (!cmb_preguntas.Text.Equals("SI") && !cmb_preguntas.Text.Equals("NO"))
            {
                MessageBox.Show("Se debe seleccionar si se permiten o no preguntas", "Frba Commerce", MessageBoxButtons.OK);
                return -1;
            }

            //rubros obligatoria
            if (lst_rubros_actuales.Items.Count == 0)
            {
                MessageBox.Show("Se debe seleccionar al menos un rubro de la lista", "Frba Commerce", MessageBoxButtons.OK);
                return -1;
            }

            //estados de publicacion
            if (!rb_activa.Checked && !rb_pausada.Checked && !rb_borrador.Checked && !rb_finalizada.Checked)
            {
                MessageBox.Show("Se debe seleccionar un estado de publicacion", "Frba Commerce", MessageBoxButtons.OK);
                return -1;
            }

            return 0;

        }
    }
}
