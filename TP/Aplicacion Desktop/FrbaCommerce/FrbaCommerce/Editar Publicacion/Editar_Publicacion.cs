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

            //Cargar en la lista de rubros los que haya en tabla
            lst_rubros.DataSource = ConectorSQL.traerDataTable("CP_LISTAR_RUBROS");
            lst_rubros.DisplayMember = "descripcion";
            lst_rubros.ValueMember = "id_rubro";

            //cargar combo visibilidad
            lst_visibilidad.DataSource = ConectorSQL.traerDataTable("CP_LISTAR_VISIBILIDADES", publicacion_actual.id_usuario);
            lst_visibilidad.DisplayMember = "descripcion";
            lst_visibilidad.ValueMember = "id_visibilidad";

            //cargar combo permitir preguntas
            cmb_preguntas.Items.Add("SI");
            cmb_preguntas.Items.Add("NO");

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

            //cargar rubros vinculados
            DataTable tb_rubros = ConectorSQL.traerDataTable("EP_TRAER_RUBROS", publicacion_actual.id);

            //campos que devuelve
            //P.descripcion, P.tipo_publicacion,PS.precio_inicial, P.id_visibilidad, P.f_preguntas, UPPER(E.descripcion) desc_estado

            bloquear_campos();

            //para guardar los rubros borrar todo y revincular
        }

        private void bloquear_campos()
        {

        }

    }
}
