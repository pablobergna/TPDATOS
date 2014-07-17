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
            string sql_qry = "SELECT U.id_usuario id, U.nombre_usuario Usuario, UC.nombre Nombre,"+ 
                                " UC.apellido Apellido, D.mail Mail, E.descripcion Estado" +
                                " FROM LOS_GESTORES.Usuario_Cliente UC" +
                                " JOIN LOS_GESTORES.Usuario U on U.id_usuario = UC.id_usuario"+
                                " JOIN LOS_GESTORES.Estado E on E.id_estado = U.id_estado"+
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

            dataGridClientes.Columns[0].Visible = false;

            // Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtApellido.Clear();
            this.txtDocumento.Clear();
            this.txtMail.Clear();
            this.txtNombre.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count != 1) return;
            
            int id_usuario = Convert.ToInt32(this.dataGridClientes.SelectedRows[0].Cells[0].Value);
            
            Abm_Cliente.AMCliente fCli = new AMCliente();
            fCli.idusuario = id_usuario;
            fCli.ShowDialog();
            this.btnBuscar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count != 1) return;
            
            int id_usuario = Convert.ToInt32(this.dataGridClientes.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("¿Confirma la baja del usuario?", "Baja", MessageBoxButtons.YesNo)
                   == DialogResult.Yes)
            {
                string sql_qry = "UPDATE LOS_GESTORES.Usuario SET id_estado = (select id_estado from LOS_GESTORES.Estado where descripcion = 'Baja') " +
                    " WHERE id_usuario = " + id_usuario.ToString();

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

                // Cierro la conexion
                AccesoDatos.getInstancia().cerrarConexion();

                this.btnBuscar.PerformClick();

            }
        
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count != 1) return;

            int id_usuario = Convert.ToInt32(this.dataGridClientes.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("¿Confirma la Inhabilitacion del usuario?", "Inhabilitacion", MessageBoxButtons.YesNo)
                   == DialogResult.Yes)
            {
                string sql_qry = "UPDATE LOS_GESTORES.Usuario SET id_estado = (select id_estado from LOS_GESTORES.Estado where descripcion = 'Inhabilitado') " +
                    " WHERE id_usuario = " + id_usuario.ToString();

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

                // Cierro la conexion
                AccesoDatos.getInstancia().cerrarConexion();

                this.btnBuscar.PerformClick();

            }

        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.SelectedRows.Count != 1) return;
            
            int id_usuario = Convert.ToInt32(this.dataGridClientes.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("¿Confirma la Habilitacion del usuario?", "Habilitacion", MessageBoxButtons.YesNo)
                   == DialogResult.Yes)
            {
                string sql_qry = "UPDATE LOS_GESTORES.Usuario SET id_estado = (select id_estado from LOS_GESTORES.Estado where descripcion = 'Habilitado') " +
                    " WHERE id_usuario = " + id_usuario.ToString();

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

                // Cierro la conexion
                AccesoDatos.getInstancia().cerrarConexion();

                this.btnBuscar.PerformClick();

            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Abm_Cliente.AMCliente fCli = new AMCliente();
            fCli.ShowDialog();
            this.btnBuscar.PerformClick();
        }

        private void lnkLimpiarEmp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtCUITEmp.Clear();
            this.txtEmpRazon.Clear();
            this.txtMailEmp.Clear();
        }

        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            string sql_qry = "SELECT U.id_usuario id, U.nombre_usuario Usuario, UE.razon_social Razon," +
                                " UE.cuit, E.descripcion Estado" +
                                " FROM LOS_GESTORES.Usuario_Empresa UE" +
                                " JOIN LOS_GESTORES.Usuario U on U.id_usuario = UE.id_usuario" +
                                " JOIN LOS_GESTORES.Estado E on E.id_estado = U.id_estado" +
                                " JOIN LOS_GESTORES.Domicilio D on D.id_domicilio = UE.id_domicilio WHERE 1=1";

            //Armo el string de acuerdo a los parametros de busqueda
            if (txtEmpRazon.Text.Trim() != string.Empty)
            {
                sql_qry = sql_qry + " AND UE.razon_social like '%" + txtEmpRazon.Text.Trim() + "%'";
            }

            if (txtCUITEmp.Text.Trim() != string.Empty)
            {
                sql_qry = sql_qry + " AND UE.cuit = '" + txtCUITEmp.Text.Trim() + "'";
            }

            if (txtMailEmp.Text.Trim() != string.Empty)
            {
                sql_qry = sql_qry + " AND D.Mail like '%" + txtMailEmp.Text.Trim() + "%'";
            }


            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

            dataGridEmpresa.AutoGenerateColumns = true;
            dataGridEmpresa.DataSource = datos.Tables[0];

            dataGridEmpresa.Columns[0].Visible = false;

            // Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();        

        }

        private void btnInhabilitarEmp_Click(object sender, EventArgs e)
        {

            if (dataGridEmpresa.SelectedRows.Count != 1) return;

            int id_usuario = Convert.ToInt32(this.dataGridEmpresa.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("¿Confirma la Inhabilitacion del usuario?", "Inhabilitacion", MessageBoxButtons.YesNo)
                   == DialogResult.Yes)
            {
                string sql_qry = "UPDATE LOS_GESTORES.Usuario SET id_estado = (select id_estado from LOS_GESTORES.Estado where descripcion = 'Inhabilitado') " +
                    " WHERE id_usuario = " + id_usuario.ToString();

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

                // Cierro la conexion
                AccesoDatos.getInstancia().cerrarConexion();

                this.btnBuscarEmp.PerformClick();

            }


        }

        private void btnHabilitarEmp_Click(object sender, EventArgs e)
        {
            if (dataGridEmpresa.SelectedRows.Count != 1) return;

            int id_usuario = Convert.ToInt32(this.dataGridEmpresa.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("¿Confirma la Habilitacion del usuario?", "Habilitacion", MessageBoxButtons.YesNo)
                   == DialogResult.Yes)
            {
                string sql_qry = "UPDATE LOS_GESTORES.Usuario SET id_estado = (select id_estado from LOS_GESTORES.Estado where descripcion = 'Habilitado') " +
                    " WHERE id_usuario = " + id_usuario.ToString();

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

                // Cierro la conexion
                AccesoDatos.getInstancia().cerrarConexion();

                this.btnBuscarEmp.PerformClick();

            }

        }

        private void btnBajaEmp_Click(object sender, EventArgs e)
        {
            if (dataGridEmpresa.SelectedRows.Count != 1) return;

            int id_usuario = Convert.ToInt32(this.dataGridEmpresa.SelectedRows[0].Cells[0].Value);

            if (MessageBox.Show("¿Confirma la baja del usuario?", "Baja", MessageBoxButtons.YesNo)
                   == DialogResult.Yes)
            {
                string sql_qry = "UPDATE LOS_GESTORES.Usuario SET id_estado = (select id_estado from LOS_GESTORES.Estado where descripcion = 'Baja') " +
                    " WHERE id_usuario = " + id_usuario.ToString();

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

                // Cierro la conexion
                AccesoDatos.getInstancia().cerrarConexion();

                this.btnBuscarEmp.PerformClick();

            }

        }

        private void btnCrearEmp_Click(object sender, EventArgs e)
        {
            Abm_Empresa.AMEmpresa fEmp = new FrbaCommerce.Abm_Empresa.AMEmpresa();
            fEmp.ShowDialog();
            this.btnBuscarEmp.PerformClick();
        }

        private void btnModificarEmp_Click(object sender, EventArgs e)
        {
            if (dataGridEmpresa.SelectedRows.Count != 1) return;

            int id_usuario = Convert.ToInt32(this.dataGridEmpresa.SelectedRows[0].Cells[0].Value);

            Abm_Empresa.AMEmpresa fEmp = new FrbaCommerce.Abm_Empresa.AMEmpresa();
            fEmp.idusuario = id_usuario;
            fEmp.ShowDialog();
            this.btnBuscarEmp.PerformClick();
        }

        

        

        


    }
}
