using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Empresa
{
    public partial class Alta_Empresa : Form
    {

        private string usr_nombre;
        private string usr_pass;

        public string nombre { get { return usr_nombre; } set { usr_nombre = value; } }

        public string pass { get { return usr_pass; } set { usr_pass = value; } }

        public Alta_Empresa()
        {
            InitializeComponent();
        }

        private void Alta_Empresa_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int nro_calle_val = 0;
            int nro_piso_val = 0;
            int cuit_val = 0;

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
                cuit_val = Convert.ToInt32(this.empCuit.Text);
            }
            catch
            {
                listaValidacion.Add("El CUIT debe ser numerico");
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

            /////////////////////////////////////////////////////////////
            //ACA TENGO QUE AGREGAR EL CODIGO DE VALIDACION DEL CUIL/CUIT
            /////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////
            //Verifico que el CUIT / CUIL no este repetido//
            ////////////////////////////////////////////////
            System.Data.SqlClient.SqlCommand comDupCUIT = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getUsuarioXCUIT");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter pcuit1 = new System.Data.SqlClient.SqlParameter("@cuit", empCuit.Text.Trim());
            comDupCUIT.Parameters.Add(pcuit1);

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

            ////////////////////////
            // Persisto la Empresa//
            ////////////////////////

            // Nombre del SP
            string sql_qry = "LOS_GESTORES.sp_app_creaUsuarioEmpresa";

            //comando pasado como parametro
            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql_qry);

            //Defino los parametros y los agrego a la lista de parametros
            System.Data.SqlClient.SqlParameter nombre_usu = new System.Data.SqlClient.SqlParameter("@nombre_usu", this.usr_nombre);
            com.Parameters.Add(nombre_usu);

            System.Data.SqlClient.SqlParameter pass_usu = new System.Data.SqlClient.SqlParameter("@pass", this.usr_pass);
            com.Parameters.Add(pass_usu);

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

            MessageBox.Show("Felicitaciones se ha registrado exitosamente");

            // Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();

            this.Close();

        }
    }
}
