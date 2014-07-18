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
        private int id_comprador;
        private DateTime fecha_hoy;
        private int id_vendedor = 0;

        public DateTime fechaHoy { get { return fecha_hoy; } set { fecha_hoy = value; } }       

        public int idPublicacion { get { return id_pub; } set { id_pub = value; } }

        public int idComprador { get { return id_comprador; } set { id_comprador = value; } }

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
                this.txtCant.Enabled = false;
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

            //id del vendedor
            this.id_vendedor = pub.GetInt32(8);

            // Cierro la conexion
            pub.Close();
            AccesoDatos.getInstancia().cerrarConexion();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int cant_compra=0;
            //Valido los campos numericos
            try
            {
                cant_compra = int.Parse(this.txtCant.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar una cantidad a comprar numerica");
                return;
            }

            if (cant_compra > int.Parse(this.lblStock.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad menor o igual al stock disponible");
                return;
            }


            // Creo la venta

            //Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlCommand comVenta = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_creaVenta");

            System.Data.SqlClient.SqlParameter p1V = new System.Data.SqlClient.SqlParameter("@id_publ", this.id_pub);
            comVenta.Parameters.Add(p1V);

            System.Data.SqlClient.SqlParameter p2V = new System.Data.SqlClient.SqlParameter("@id_comprador", this.id_comprador);
            comVenta.Parameters.Add(p2V);

            System.Data.SqlClient.SqlParameter p3V = new System.Data.SqlClient.SqlParameter("@fecha", this.fecha_hoy);
            comVenta.Parameters.Add(p3V);

            System.Data.SqlClient.SqlParameter p4V = new System.Data.SqlClient.SqlParameter("@cant", cant_compra);
            comVenta.Parameters.Add(p4V);
            
            System.Data.SqlClient.SqlDataReader rolReader = AccesoDatos.getInstancia().ejecutaSP(comVenta);

            //Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();
            
            
            Comprar_Ofertar.VisVendedor fVend = new VisVendedor();
            fVend.idVendedor = this.id_vendedor;
            fVend.ShowDialog();
            this.Close();
        }

        
    }
}
