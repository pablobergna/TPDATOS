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

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Gestion_de_Preguntas : Form
    {
        private int usuario;
        private DateTime fecha_sistema;

        public Gestion_de_Preguntas(int id_usuario, DateTime fecha)
        {
            InitializeComponent();
            usuario = id_usuario;
            fecha_sistema = fecha;
        }

        private void Gestion_de_Preguntas_Load(object sender, EventArgs e)
        {
            //Codigo para cargar en el group box el usuario activo, rol y demas datos
            lbl_usuario.Text = "Usuario :" + usuario;
            gb_responder_preguntas.Hide();
            gb_ver_respuestas.Hide();

            //carga la lista con las preguntas pendientes
            lst_preguntas.DataSource = ConectorSQL.traerDataTable("GP_LISTAR_PREGUNTAS", usuario);
            lst_preguntas.DisplayMember = "txt_pregunta";
            lst_preguntas.ValueMember = "id_pregunta";

            //carga las respuestas
            dg_respuestas.DataSource = ConectorSQL.traerDataTable("GP_LISTAR_RESPUESTAS", usuario);


        }

        private void btn_ver_respuestas_Click(object sender, EventArgs e)
        {
            gb_responder_preguntas.Hide();
            gb_ver_respuestas.Show();
        }

        private void btn_responder_preguntas_Click(object sender, EventArgs e)
        {
            gb_responder_preguntas.Show();
            gb_ver_respuestas.Hide();
            txt_respuesta.Text = "";
        }

        private void btn_responder_Click(object sender, EventArgs e)
        {
            //validaciones
            if (txt_respuesta.Text.Length <= 0)
            {
                MessageBox.Show("La respuesta no puede ser vacia", "Frba Commerce",MessageBoxButtons.OK);
                return;
            }

            if (lst_preguntas.SelectedItems.Count != 1)
            {
                MessageBox.Show("Se debe seleccionar una pregunta de la lista", "Frba Commerce", MessageBoxButtons.OK);
                return;
            }

            //defino variable para llamar al SP
            int id_pregunta;
            string respuesta;
            int resultado;

            id_pregunta = Int32.Parse(lst_preguntas.GetItemText(lst_preguntas.SelectedItem));
            respuesta = txt_respuesta.Text;

            //llamada al SP
            DataTable dt_responder = ConectorSQL.traerDataTable("GP_RESPONDER_PREGUNTA", id_pregunta, respuesta, fecha_sistema);

            resultado = Convert.ToInt32(dt_responder.Rows[0][0]);

            if (resultado == 0)
            {
                MessageBox.Show("Respuesta grabada correctamente", "Frba Commerce", MessageBoxButtons.OK);
                btn_responder_preguntas_Click(null,null);
            }
            else
            {
                MessageBox.Show("Hubo algun error al grabar la respuesta", "Frba Commerce", MessageBoxButtons.OK);
            }
        }

        private void dg_respuestas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
