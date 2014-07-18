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
        private DateTime fecha_sistema;

        public Editar_Publicacion(int usuario, DateTime fecha)
        {
            InitializeComponent();
            publicacion_actual.id_usuario = usuario;
            publicacion_modificada.id_usuario = usuario;
            fecha_sistema = fecha;
        }

        private void Editar_Publicacion_Load(object sender, EventArgs e)
        {

            DataTable tabla;

            tabla = ConectorSQL.traerDataTable("EP_LISTAR_PUBLICACIONES", publicacion_actual.id_usuario);

            dg_publicaciones.DataSource = tabla;

        }

        private void dg_publicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

            //para guardar los rubros borrar todo y revincular
        }

        private void llenar_interfaz_compra_inmediata()
        {
            txt_descripcion.Show();
            txt_descripcion.Text = publicacion_actual.descripcion;

            rb_compra_inmediata.Checked = true;
            rb_subasta.Checked = false;

            lbl_stock.Show();
            txt_stock.Show();
            txt_stock.Text = Convert.ToString(publicacion_actual.stock);

            txt_precio.Text = Convert.ToString(publicacion_actual.precio);

            if (publicacion_actual.permitir_preguntas == 0)
                cmb_preguntas.SelectedIndex = cmb_preguntas.FindStringExact("SI");
            else
                cmb_preguntas.SelectedIndex = cmb_preguntas.FindStringExact("NO");


        }


        private void llenar_interfaz_subasta()
        {

        }

        private void cargar_listas_combos()
        {

            //Cargar en la lista de rubros los que haya en tabla
            lst_rubros.DataSource = ConectorSQL.traerDataTable("CP_LISTAR_RUBROS");
            lst_rubros.DisplayMember = "descripcion";
            lst_rubros.ValueMember = "id_rubro";

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

    }
}
