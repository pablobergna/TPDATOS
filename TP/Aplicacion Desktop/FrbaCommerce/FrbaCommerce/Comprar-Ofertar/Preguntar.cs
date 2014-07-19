using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Preguntar : Form
    {
        private int id_pub;
        private int id_comprador;
        private DateTime fecha_hoy;

        public DateTime fechaHoy { get { return fecha_hoy; } set { fecha_hoy = value; } }

        public int idPublicacion { get { return id_pub; } set { id_pub = value; } }

        public int idComprador { get { return id_comprador; } set { id_comprador = value; } }
        


        public Preguntar()
        {
            InitializeComponent();
        }

        private void Preguntar_Load(object sender, EventArgs e)
        {

        }

        private void btnPreg_Click(object sender, EventArgs e)
        {
            if (this.txtPreg.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un texto para la pregunta");
                return;
            }

            // Creo la pregunta

            //Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlCommand comVenta = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_creaPregunta");

            System.Data.SqlClient.SqlParameter p1V = new System.Data.SqlClient.SqlParameter("@id_usu", this.id_comprador);
            comVenta.Parameters.Add(p1V);

            System.Data.SqlClient.SqlParameter p2V = new System.Data.SqlClient.SqlParameter("@id_pub", this.id_pub);
            comVenta.Parameters.Add(p2V);

            System.Data.SqlClient.SqlParameter p3V = new System.Data.SqlClient.SqlParameter("@txt", this.txtPreg.Text.Trim());
            comVenta.Parameters.Add(p3V);

            System.Data.SqlClient.SqlParameter p4V = new System.Data.SqlClient.SqlParameter("@fecha", this.fecha_hoy);
            comVenta.Parameters.Add(p4V);

            System.Data.SqlClient.SqlDataReader rolReader = AccesoDatos.getInstancia().ejecutaSP(comVenta);

            //Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();

            MessageBox.Show("Su pregunta se ha registrado con exito");
            this.Close();

        }
    }
}
