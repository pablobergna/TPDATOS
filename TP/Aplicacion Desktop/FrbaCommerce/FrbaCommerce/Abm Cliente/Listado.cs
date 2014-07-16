using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            this.panelEmpresa.Hide();
            this.panelCliente.Show();

            string sql_qry = "LOS_GESTORES.sp_app_getTipoDoc";

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

            DataTable tabla = datos.Tables[0];

            // Creo la lista a cargar con los valores de la consulta
            ArrayList listado = new ArrayList();

            foreach (DataRow reg in tabla.Rows)
            {
                listado.Add(new DTO.RolDTO(int.Parse(reg[0].ToString()), reg[1].ToString()));
            }

            // Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();

            // Asigno los valores al combobox
            cmbTipoDoc.DataSource = listado;
            cmbTipoDoc.DisplayMember = "descRol";
            cmbTipoDoc.ValueMember = "idRol";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panelCliente.Hide();
            this.panelEmpresa.Show();
        }
    }
}
