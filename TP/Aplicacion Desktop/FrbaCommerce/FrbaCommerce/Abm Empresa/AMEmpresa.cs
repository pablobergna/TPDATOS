using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class AMEmpresa : Form
    {
        private string usr_nombre;
        private string usr_pass;
        private int id_usuario = -1;

        public string nombre { get { return usr_nombre; } set { usr_nombre = value; } }

        public string pass { get { return usr_pass; } set { usr_pass = value; } }

        public int idusuario { get { return id_usuario; } set { id_usuario = value; } }

        public AMEmpresa()
        {
            InitializeComponent();
        }

        private void AMEmpresa_Load(object sender, EventArgs e)
        {
            //Chequeo si es una modificacion
            if (this.id_usuario != -1)
            {

                //Traigo la informacion del usuario
                System.Data.SqlClient.SqlCommand comUsu = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getUsuarioEmpresaXId");

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
                this.empRazSocial.Text = usuario.GetString(2);
                this.empMail.Text = usuario.GetString(3).Trim();
                this.empTelefono.Text = usuario.GetString(4).Trim();
                this.empDireccion.Text = usuario.GetString(5).Trim();
                this.empNroCalle.Text = usuario.GetDecimal(6).ToString().Trim();
                this.empNroPiso.Text = usuario.GetDecimal(7).ToString().Trim();
                this.empDpto.Text = usuario.GetString(8).Trim();
                this.empLocalidad.Text = usuario.GetString(9).Trim();
                this.empCodPostal.Text = usuario.GetString(10).Trim();
                this.ciudad.Text = usuario.GetString(11).Trim();
                this.empCuit.Text = usuario.GetString(12).Trim();
                this.empFechaCre.Value = usuario.GetDateTime(13);
                this.empContacto.Text = usuario.GetString(14);
                

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
            if (this.empRazSocial.Text == String.Empty)
            {
                listaValidacion.Add("El campo Razon social es obligatorio");
            }
            if (this.empMail.Text == String.Empty)
            {
                listaValidacion.Add("El campo Email es obligatorio");
            }
            if (this.empTelefono.Text == String.Empty)
            {
                listaValidacion.Add("El campo Telefono es obligatorio");
            }
            if (this.empDireccion.Text == String.Empty)
            {
                listaValidacion.Add("El campo Calle es obligatorio");
            }
            if (this.empNroCalle.Text == String.Empty)
            {
                listaValidacion.Add("El campo Nro. Calle es obligatorio");
            }
            if (this.empLocalidad.Text == String.Empty)
            {
                listaValidacion.Add("El campo Localidad es obligatorio");
            }
            if (this.ciudad.Text == String.Empty)
            {
                listaValidacion.Add("El campo Ciudad es obligatorio");
            }
            if (this.empCuit.Text == String.Empty)
            {
                listaValidacion.Add("El campo CUIT es obligatorio");
            }
            if (this.empContacto.Text == String.Empty)
            {
                listaValidacion.Add("El campo Nombre de contacto es obligatorio");
            }
            if (this.empFechaCre.Text == String.Empty)
            {
                listaValidacion.Add("El campo Fecha de creacion es obligatorio");
            }

            //Valido los campos numericos
            try
            {
                nro_calle_val = Convert.ToInt32(this.empNroCalle.Text);
            }
            catch
            {
                listaValidacion.Add("El Nro. de calle debe ser numerico");
            }

            try
            {
                if (this.empNroPiso.Text != String.Empty)
                    nro_piso_val = Convert.ToInt32(this.empNroPiso.Text);
            }
            catch
            {
                listaValidacion.Add("El Piso debe ser numerico");
            }

            //Valido el formato del CUIL
            if (Tools.Validacion.validarCUIT(this.empCuit.Text) == -1)
                listaValidacion.Add("El CUIL esta mal formado");
            
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

            ////////////////////////////////////////////////
            //Verifico que el CUIT / CUIL no este repetido//
            ////////////////////////////////////////////////
            System.Data.SqlClient.SqlCommand comDupCUIT = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getUsuarioXCUIT");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter pcuit1 = new System.Data.SqlClient.SqlParameter("@cuit", empCuit.Text.Trim());
            comDupCUIT.Parameters.Add(pcuit1);

            if (this.id_usuario != -1)
            {
                System.Data.SqlClient.SqlParameter pid_usu = new System.Data.SqlClient.SqlParameter("@id_usuario", this.id_usuario);
                comDupCUIT.Parameters.Add(pid_usu);
            }

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader dupCUIT = AccesoDatos.getInstancia().ejecutaSP(comDupCUIT);

            if (dupCUIT.HasRows)
            {
                MessageBox.Show("Ya existe un usuario con ese numero de CUIT - CUIL.");
                // Cierro la conexion
                dupCUIT.Close();
                AccesoDatos.getInstancia().cerrarConexion();
                return;
            }

            // Cierro la conexion
            dupCUIT.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            /////////////////////////////////////////////////
            //Verifico que LA RAZON SOCIAL no este repetida//
            /////////////////////////////////////////////////
            System.Data.SqlClient.SqlCommand comDup = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getEmpresaXRazon");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter p1 = new System.Data.SqlClient.SqlParameter("@razon", empRazSocial.Text.Trim());
            comDup.Parameters.Add(p1);

            if (this.id_usuario != -1)
            {
                System.Data.SqlClient.SqlParameter pid_usu = new System.Data.SqlClient.SqlParameter("@id_usuario", this.id_usuario);
                comDup.Parameters.Add(pid_usu);
            }

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader dup = AccesoDatos.getInstancia().ejecutaSP(comDup);

            if (dup.HasRows)
            {
                MessageBox.Show("Ya existe un usuario con esa Razon Social.");
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
                sql_qry = "LOS_GESTORES.sp_app_creaUsuarioEmpresa";
                txt_confirmacion = "Se ha creado el usuario correctamente";
            }
            else
            {
                // Nombre del SP para modificacion
                sql_qry = "LOS_GESTORES.sp_app_modificaUsuarioEmpresa";
                txt_confirmacion = "Se ha modificado el usuario correctamente";
            }

                        
            ////////////////////////
            // Persisto la Empresa//
            ////////////////////////

            //comando pasado como parametro
            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql_qry);

            //Fuerzo el cambio de pass
            System.Data.SqlClient.SqlParameter forzar_cambio = new System.Data.SqlClient.SqlParameter("@forzar", Convert.ToInt16(1));
            com.Parameters.Add(forzar_cambio);

            //Defino los parametros y los agrego a la lista de parametros
            if (this.id_usuario == -1)
            {
                // Solo paso nombre usuario y pass si es un usuario nuevo
                // Los genero automaticamente
                string nombre_generado = "AUTO_" + this.empRazSocial.Text.Trim();
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

            System.Data.SqlClient.SqlParameter calle_usu = new System.Data.SqlClient.SqlParameter("@calle", this.empDireccion.Text);
            com.Parameters.Add(calle_usu);

            System.Data.SqlClient.SqlParameter nro_calle_usu = new System.Data.SqlClient.SqlParameter("@nro_calle", nro_calle_val);
            com.Parameters.Add(nro_calle_usu);

            if (this.empNroPiso.Text != String.Empty)
            {
                System.Data.SqlClient.SqlParameter piso_usu = new System.Data.SqlClient.SqlParameter("@piso", nro_piso_val);
                com.Parameters.Add(piso_usu);
            }

            System.Data.SqlClient.SqlParameter depto_usu = new System.Data.SqlClient.SqlParameter("@depto", this.empDpto.Text);
            com.Parameters.Add(depto_usu);

            System.Data.SqlClient.SqlParameter cp_usu = new System.Data.SqlClient.SqlParameter("@cp", this.empCodPostal.Text);
            com.Parameters.Add(cp_usu);

            System.Data.SqlClient.SqlParameter loc_usu = new System.Data.SqlClient.SqlParameter("@loc", this.empLocalidad.Text);
            com.Parameters.Add(loc_usu);

            System.Data.SqlClient.SqlParameter ciudad_usu = new System.Data.SqlClient.SqlParameter("@ciudad", this.ciudad.Text);
            com.Parameters.Add(ciudad_usu);

            System.Data.SqlClient.SqlParameter mail_usu = new System.Data.SqlClient.SqlParameter("@mail", this.empMail.Text);
            com.Parameters.Add(mail_usu);

            System.Data.SqlClient.SqlParameter razon_usu = new System.Data.SqlClient.SqlParameter("@razon", empRazSocial.Text.Trim());
            com.Parameters.Add(razon_usu);

            System.Data.SqlClient.SqlParameter cuit_usu = new System.Data.SqlClient.SqlParameter("@cuit", empCuit.Text.Trim());
            com.Parameters.Add(cuit_usu);

            System.Data.SqlClient.SqlParameter fcrea_usu = new System.Data.SqlClient.SqlParameter("@f_crea", this.empFechaCre.Value);
            com.Parameters.Add(fcrea_usu);

            System.Data.SqlClient.SqlParameter contacto_usu = new System.Data.SqlClient.SqlParameter("@nom_contacto", empContacto.Text.Trim());
            com.Parameters.Add(contacto_usu);

            System.Data.SqlClient.SqlParameter telefono_usu = new System.Data.SqlClient.SqlParameter("@telefono", empTelefono.Text.Trim());
            com.Parameters.Add(telefono_usu);


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
