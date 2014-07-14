using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class Registro_Form : Form
    {

        private FrbaCommerce.Abm_Cliente.Alta_Cliente regCliente;
        private FrbaCommerce.Abm_Empresa.Alta_Empresa regEmpresa;

        public Registro_Form()
        {
            InitializeComponent();
        }

        private void Registro_Form_Load(object sender, EventArgs e)
        {

            //Consulta o nombre del SP sin parametros
            string sql_qry = "LOS_GESTORES.sp_app_getRolesRegistro";

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();
            
            //Traigo el resultado
            DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);
            DataTable tabla = datos.Tables[0];

            // Creo la lista a cargar con los valores de la consulta
            ArrayList listado = new ArrayList();
            
            foreach (DataRow reg in tabla.Rows)
            {
                listado.Add(new DTO.RolDTO(int.Parse(reg[0].ToString()),reg[1].ToString()));
            }

            // Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();

            // Asigno los valores al combobox
            reg_comboRoles.DataSource = listado;
            reg_comboRoles.DisplayMember = "descRol";
            reg_comboRoles.ValueMember = "idRol";
                   
        }

        private void btn_reg_siguiente_Click(object sender, EventArgs e)
        {

            List<string> listaValidacion = new List<string>();
            string pass_encriptado;
            SHA256Managed encriptacionSha256 = new SHA256Managed();

            //Validamos los campos obligatorios
            if (this.usr_nombre.Text == String.Empty)
            {
                listaValidacion.Add("El Nombre es obligatorio");
            }

            if (this.usr_pass.Text == String.Empty)
            {
                listaValidacion.Add("La Contraseña es obligatoria");
            }

            //Muestro un mensaje con los datos mal cargados
            if (listaValidacion.Count > 0)
            {
                StringBuilder error = new StringBuilder();
                error.AppendLine("Por favor corrija los siguientes campos:");

                foreach (var i in listaValidacion)
                {
                    error.AppendLine(i);
                }

                MessageBox.Show(error.ToString());
                return;
            }

            //Verifico que el usuario no haya sido dado de alta
            System.Data.SqlClient.SqlCommand comDup = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getUsuarioXNombre");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter p1 = new System.Data.SqlClient.SqlParameter("@nombre", usr_nombre.Text.Trim());

            //Agrego el parametro a la lista de parametros
            comDup.Parameters.Add(p1);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();
            
            System.Data.SqlClient.SqlDataReader dup = AccesoDatos.getInstancia().ejecutaSP(comDup);

            if (dup.HasRows)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre.");
                // Cierro la conexion
                dup.Close();
                AccesoDatos.getInstancia().cerrarConexion();
                return;
            }

            // Cierro la conexion
            dup.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            pass_encriptado = Convert.ToBase64String(encriptacionSha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(usr_pass.Text)));
           
            if (reg_comboRoles.Text.Equals("Cliente"))
            {
                regCliente = new FrbaCommerce.Abm_Cliente.Alta_Cliente();
                //Paso los parametros
                regCliente.nombre = usr_nombre.Text;
                regCliente.pass = pass_encriptado;
                regCliente.ShowDialog();
                this.Close();
            }
            else
            {
                regEmpresa = new FrbaCommerce.Abm_Empresa.Alta_Empresa();
                //Paso los parametros
                regEmpresa.nombre = usr_nombre.Text;
                regEmpresa.pass = pass_encriptado;
                regEmpresa.ShowDialog();
                this.Close();
            }
        }

        private void btn_reg_canelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
