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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql_qry = "SELECT U.id_usuario id, U.nombre_usuario Usuario, UC.nombre Nombre, UC.apellido Apellido, D.mail Mail, UC.nro_doc" +
                                " FROM LOS_GESTORES.Usuario_Cliente UC" +
                                " JOIN LOS_GESTORES.Usuario U on U.id_usuario = UC.id_usuario"+
                                " JOIN LOS_GESTORES.Domicilio D on D.id_domicilio = UC.id_domicilio WHERE 1=1";
            
            //Armo el string de acuerdo a los parametros de busqueda
            if (txtNombre.Text.Trim() != string.Empty)
            {
                sql_qry = sql_qry + " AND UC.nombre like '%" + txtNombre.Text.Trim() + "%'";
            }

            if (txtApellido.Text.Trim() != string.Empty)
            {
                sql_qry = sql_qry + " AND UC.apellido like '%" + txtApellido.Text.Trim() + "%'";
            }

            if (txtMail.Text.Trim() != string.Empty)
            {
                sql_qry = sql_qry + " AND D.Mail like '%" + txtMail.Text.Trim() + "%'";
            }

            if (txtDocumento.Text.Trim() != string.Empty)
            {
                int documento;

                try
                {
                    documento = Convert.ToInt32(txtDocumento.Text.Trim()); 
                }
                catch (Exception)
                {

                    MessageBox.Show("El numero de documento debe ser numerico");
                    return;
                }
                sql_qry = sql_qry + " AND UC.nro_doc = " + documento;
            }




            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

            dataGridClientes.AutoGenerateColumns = true;
            dataGridClientes.DataSource = datos.Tables[0];

            // Cierro la conexion
            AccesoDatos.getInstancia().abrirConexion();
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtApellido.Clear();
            this.txtDocumento.Clear();
            this.txtMail.Clear();
            this.txtNombre.Clear();
        }

        



    }
}
