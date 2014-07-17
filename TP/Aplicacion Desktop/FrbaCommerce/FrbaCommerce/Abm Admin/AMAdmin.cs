using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FrbaCommerce.Abm_Admin
{
    public partial class AMAdmin : Form
    {
        private string usr_nombre;
        private string usr_pass;
        private int id_usuario = -1;

        public string nombre { get { return usr_nombre; } set { usr_nombre = value; } }

        public string pass { get { return usr_pass; } set { usr_pass = value; } }

        public int idusuario { get { return id_usuario; } set { id_usuario = value; } }

 
        public AMAdmin()
        {
            InitializeComponent();
        }

        private void AMAdmin_Load(object sender, EventArgs e)
        {
            //Chequeo si es una modificacion
            if (this.id_usuario != -1)
            {

                //Traigo la informacion del usuario
                System.Data.SqlClient.SqlCommand comUsu = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getUsuarioAdminXId");

                //Defino los parametros
                System.Data.SqlClient.SqlParameter pUsu = new System.Data.SqlClient.SqlParameter("@id", this.id_usuario);
                comUsu.Parameters.Add(pUsu);

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                System.Data.SqlClient.SqlDataReader usuario = AccesoDatos.getInstancia().ejecutaSP(comUsu);

                if (!usuario.HasRows)
                {
                    MessageBox.Show("Usuario invalido");
                    return;
                }

                usuario.Read();
                this.lblUsu.Text += usuario.GetString(0);
                this.lblEstado.Text += usuario.GetString(1);
                this.txtLegajo.Text = usuario.GetString(2);
                this.txtSuc.Text = usuario.GetString(3).Trim();
                this.txtMail.Text = usuario.GetString(4).Trim();
                this.txtCalle.Text = usuario.GetString(5).Trim();
                this.txtNroCalle.Text = usuario.GetDecimal(6).ToString().Trim();
                this.txtNroPiso.Text = usuario.GetDecimal(7).ToString().Trim();
                this.txtDepto.Text = usuario.GetString(8).Trim();
                this.txtLocalidad.Text = usuario.GetString(9).Trim();
                this.txtCP.Text = usuario.GetString(10).Trim();
                this.txtCiudad.Text = usuario.GetString(11).Trim();

                // Cierro la conexion
                usuario.Close();
                AccesoDatos.getInstancia().cerrarConexion();
            }
            else
            {
                this.lblUsu.Text += "AUTOGENERADO";
                this.lblEstado.Text += "Habilitado";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int nro_calle_val = 0;
            int nro_piso_val = 0;
            SHA256Managed encriptacionSha256 = new SHA256Managed();

            List<string> listaValidacion = new List<string>();

            //Validamos los campos obligatorios
            if (this.txtLegajo.Text == String.Empty)
            {
                listaValidacion.Add("El campo Legajo es obligatorio");
            }
            if (this.txtSuc.Text == String.Empty)
            {
                listaValidacion.Add("El campo Sucursal es obligatorio");
            }
            if (this.txtMail.Text == String.Empty)
            {
                listaValidacion.Add("El campo Correo electronico es obligatorio");
            }
            if (this.txtCalle.Text == String.Empty)
            {
                listaValidacion.Add("El campo Calle es obligatorio");
            }
            if (this.txtNroCalle.Text == String.Empty)
            {
                listaValidacion.Add("El campo Nro. Calle es obligatorio");
            }
            if (this.txtLocalidad.Text == String.Empty)
            {
                listaValidacion.Add("El campo Localidad es obligatorio");
            }
            if (this.txtCiudad.Text == String.Empty)
            {
                listaValidacion.Add("El campo Ciudad es obligatorio");
            }

            //Valido los campos numericos
            try
            {
                nro_calle_val = Convert.ToInt32(this.txtNroCalle.Text);
            }
            catch
            {
                listaValidacion.Add("El Nro. de calle debe ser numerico");
            }

            try
            {
                if (this.txtNroPiso.Text != String.Empty)
                    nro_piso_val = Convert.ToInt32(this.txtNroPiso.Text);
            }
            catch
            {
                listaValidacion.Add("El Piso debe ser numerico");
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

            /////////////////////////////////////////////////
            //Verifico que EL LEGAJO no este repetida//
            /////////////////////////////////////////////////
            System.Data.SqlClient.SqlCommand comLeg = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getAdminXLegajo");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter p1 = new System.Data.SqlClient.SqlParameter("@legajo", txtLegajo.Text.Trim());
            comLeg.Parameters.Add(p1);

            if (this.id_usuario != -1)
            {
                System.Data.SqlClient.SqlParameter pid_usu = new System.Data.SqlClient.SqlParameter("@id_usuario", this.id_usuario);
                comLeg.Parameters.Add(pid_usu);
            }

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader dup = AccesoDatos.getInstancia().ejecutaSP(comLeg);

            if (dup.HasRows)
            {
                MessageBox.Show("Ya existe un empleado con ese Legajo.");
                // Cierro la conexion
                dup.Close();
                AccesoDatos.getInstancia().cerrarConexion();
                return;
            }

            // Cierro la conexion
            dup.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            string sql_qry = "";
            string txt_confirmacion = "";

            if (this.id_usuario == -1)
            {
                // Nombre del SP para creacion
                sql_qry = "LOS_GESTORES.sp_app_creaUsuarioAdmin";
                txt_confirmacion = "Se ha creado el usuario correctamente";
            }
            else
            {
                // Nombre del SP para modificacion
                sql_qry = "LOS_GESTORES.sp_app_modificaUsuarioAdmin";
                txt_confirmacion = "Se ha modificado el usuario correctamente";
            }


            ////////////////////////
            // Persisto el Admin  //
            ////////////////////////

            //comando pasado como parametro
            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql_qry);

            //Defino los parametros y los agrego a la lista de parametros
            if (this.id_usuario == -1)
            {
                // Solo paso nombre usuario y pass si es un usuario nuevo
                // Los genero automaticamente
                string nombre_generado = "ADM_" + this.txtLegajo.Text.Trim();
                string pass_generada = Convert.ToBase64String(encriptacionSha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes("inicio1234"))); ;

                // Los agrego al txt de confirmacion
                txt_confirmacion += "\nUsuario: " + nombre_generado + "\nPass: inicio1234";

                System.Data.SqlClient.SqlParameter nombre_usu = new System.Data.SqlClient.SqlParameter("@nombre_usu", nombre_generado);
                com.Parameters.Add(nombre_usu);

                System.Data.SqlClient.SqlParameter pass_usu = new System.Data.SqlClient.SqlParameter("@pass", pass_generada);
                com.Parameters.Add(pass_usu);
            }
            else
            {
                // Solo paso nombre id si es una modificacion
                System.Data.SqlClient.SqlParameter id_usu = new System.Data.SqlClient.SqlParameter("@id_usuario", this.id_usuario);
                com.Parameters.Add(id_usu);
            }

            System.Data.SqlClient.SqlParameter calle_usu = new System.Data.SqlClient.SqlParameter("@calle", this.txtCalle.Text);
            com.Parameters.Add(calle_usu);

            System.Data.SqlClient.SqlParameter nro_calle_usu = new System.Data.SqlClient.SqlParameter("@nro_calle", nro_calle_val);
            com.Parameters.Add(nro_calle_usu);

            if (this.txtNroPiso.Text != String.Empty)
            {
                System.Data.SqlClient.SqlParameter piso_usu = new System.Data.SqlClient.SqlParameter("@piso", nro_piso_val);
                com.Parameters.Add(piso_usu);
            }

            System.Data.SqlClient.SqlParameter depto_usu = new System.Data.SqlClient.SqlParameter("@depto", this.txtDepto.Text);
            com.Parameters.Add(depto_usu);

            System.Data.SqlClient.SqlParameter cp_usu = new System.Data.SqlClient.SqlParameter("@cp", this.txtCP.Text);
            com.Parameters.Add(cp_usu);

            System.Data.SqlClient.SqlParameter loc_usu = new System.Data.SqlClient.SqlParameter("@loc", this.txtLocalidad.Text);
            com.Parameters.Add(loc_usu);

            System.Data.SqlClient.SqlParameter ciudad_usu = new System.Data.SqlClient.SqlParameter("@ciudad", this.txtCiudad.Text);
            com.Parameters.Add(ciudad_usu);

            System.Data.SqlClient.SqlParameter mail_usu = new System.Data.SqlClient.SqlParameter("@mail", this.txtMail.Text);
            com.Parameters.Add(mail_usu);

            System.Data.SqlClient.SqlParameter leg_usu = new System.Data.SqlClient.SqlParameter("@legajo", this.txtLegajo.Text);
            com.Parameters.Add(leg_usu);

            System.Data.SqlClient.SqlParameter suc_usu = new System.Data.SqlClient.SqlParameter("@sucursal", this.txtSuc.Text);
            com.Parameters.Add(suc_usu);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader datos
                = AccesoDatos.getInstancia().ejecutaSP(com);

            // Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();

            MessageBox.Show(txt_confirmacion);
            this.Close();
        }
    }
}
