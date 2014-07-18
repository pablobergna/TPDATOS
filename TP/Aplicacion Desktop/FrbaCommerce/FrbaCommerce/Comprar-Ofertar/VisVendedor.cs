using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class VisVendedor : Form
    {
        private int id_vendedor;

        public int idVendedor { get { return id_vendedor; } set { id_vendedor = value;} }

        public VisVendedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VisVendedor_Load(object sender, EventArgs e)
        {
            //Traigo la informacion del la publicacion
            System.Data.SqlClient.SqlCommand comUsu = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getInfoVendedorXId");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter pUsu = new System.Data.SqlClient.SqlParameter("@id_vend", this.id_vendedor);
            comUsu.Parameters.Add(pUsu);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader pub = AccesoDatos.getInstancia().ejecutaSP(comUsu);

            if (!pub.HasRows)
            {
                MessageBox.Show("Vendedor invalido");
                return;
            }

            pub.Read();

            ArrayList lista = new ArrayList();

            lista.Add("Usuario: " + pub.GetString(0));
            lista.Add("Calle: " + pub.GetString(1));
            lista.Add("Nro calle: " + pub.GetDecimal(2).ToString());
            lista.Add("Piso: " + pub.GetDecimal(3).ToString());
            lista.Add("Depto.: " + pub.GetString(4));
            lista.Add("Codigo Postal: " + pub.GetString(5));
            lista.Add("Correo electronico: " + pub.GetString(6));
            lista.Add("Localidad: " + pub.GetString(7));
            lista.Add("Ciudad: " + pub.GetString(8));

            this.listInfo.DataSource = lista;

            // Cierro la conexion
            pub.Close();
            AccesoDatos.getInstancia().cerrarConexion();
        }
    }
}
