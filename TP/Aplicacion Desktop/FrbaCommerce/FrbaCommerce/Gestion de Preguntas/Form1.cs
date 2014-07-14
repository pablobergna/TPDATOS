using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Model;

namespace FrbaCommerce.Gestion_de_Preguntas
{
    public partial class Gestion_de_Preguntas : Form
    {
        public Gestion_de_Preguntas()
        {
            InitializeComponent();
        }

        private void Gestion_de_Preguntas_Load(object sender, EventArgs e)
        {
            //Codigo para cargar en el group box el usuario activo, rol y demas datos
            //lbl_usuario.Text = lbl_usuario.Text + "usuario"\
            gb_responder_preguntas.Hide();
            gb_ver_respuestas.Hide();
        }

        private void lst_respuestas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_ver_respuestas_Click(object sender, EventArgs e)
        {
            gb_responder_preguntas.Hide();
            gb_ver_respuestas.Show();
            //carga las respuestas
            dg_respuestas.DataSource = ConectorSQL.traerDataTable("TRAER_FACTURAS");
            //dg_respuestas.DataSource = ConectorSQL.traerDataTable("LISTAR_RESPUESTAS");

        }

    }
}
