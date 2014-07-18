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
    public partial class VisualizarPub : Form
    {
        private int id_pub;

        public int idPublicacion { get { return id_pub; } set { id_pub = value; } }

        public VisualizarPub()
        {
            InitializeComponent();
        }

        private void VisualizarPub_Load(object sender, EventArgs e)
        {
            //Traigo la informacion del la publicacion
            System.Data.SqlClient.SqlCommand comUsu = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getInfoPublicacionXId");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter pUsu = new System.Data.SqlClient.SqlParameter("@id_publ", this.id_pub);
            comUsu.Parameters.Add(pUsu);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader pub = AccesoDatos.getInstancia().ejecutaSP(comUsu);

            if (!pub.HasRows)
            {
                MessageBox.Show("Publicacion invalida");
                return;
            }

            pub.Read();
            this.lblUsu.Text = pub.GetString(0);
            this.txtBoxDesc.Text = pub.GetString(1);
            this.lblTipo.Text = pub.GetString(2);
            
            if (this.lblTipo.Text.Equals("Subasta"))
            {
                this.lblStock.Text = "NO APLICABLE";
                this.lblPrecio.Text = pub.GetDecimal(5).ToString();
                this.btnComprar.Enabled = false;
            }
            if (this.lblTipo.Text.Equals("Compra Inmediata"))
            {
                this.lblStock.Text = pub.GetDecimal(3).ToString();
                this.lblPrecio.Text = pub.GetDecimal(4).ToString();
                this.btnOfertar.Enabled = false;
            }

            this.lblFecVen.Text = pub.GetDateTime(6).ToShortDateString();

            if (pub.GetInt16(7) == 0)
                this.btnPreg.Enabled = false;

            // Cierro la conexion
            pub.Close();
            AccesoDatos.getInstancia().cerrarConexion();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Comprar_Ofertar.VisVendedor fVend = new VisVendedor();
            fVend.idVendedor = 2;
            fVend.ShowDialog();
        }

        
    }
}
