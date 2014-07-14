using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Model;
using System.Collections;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Alta_Cliente : Form
    {

        private string usr_nombre;
        private string usr_pass;


        public string nombre { get { return usr_nombre; } set { usr_nombre = value; } }

        public string pass { get { return usr_pass; } set { usr_pass = value; } }

        public Alta_Cliente()
        {
            InitializeComponent();
        }


        private void Alta_Cliente_Load(object sender, EventArgs e)
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
            cliTipoDoc.DataSource = listado;
            cliTipoDoc.DisplayMember = "descRol";
            cliTipoDoc.ValueMember = "idRol";
            
        }
        
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int documento = 0;
            int nro_calle_val = 0;
            int nro_piso_val = 0;
            int cuil_val = 0;
            string tipoDoc = "";

            List<string> listaValidacion = new List<string>();

            //Validamos los campos obligatorios
            if (this.cliNombre.Text == String.Empty)
            {
                listaValidacion.Add("El campo Nombre es obligatorio");
            }

            if (this.cliApellido.Text == String.Empty)
            {
                listaValidacion.Add("El campo Apellido es obligatorio");
            }

            if (this.cliDni.Text == String.Empty)
            {
                listaValidacion.Add("El campo Dni es obligatorio");
            }

            if (this.cliEmail.Text == String.Empty)
            {
                listaValidacion.Add("El campo de Email es obligatorio");
            }

            if (this.cliTelefono.Text == String.Empty)
            {
                listaValidacion.Add("El campo de Telefono es obligatorio");
            }

            if (this.cliDireccion.Text == String.Empty)
            {
                listaValidacion.Add("El campo de Calle es obligatorio");
            }

            if (this.nroCalle.Text == String.Empty)
            {
                listaValidacion.Add("El campo de Numero de calle es obligatorio");
            }

            if (this.cuil.Text == String.Empty)
            {
                listaValidacion.Add("El campo de CUIL es obligatorio");
            }
            if (this.cliLocalidad.Text == String.Empty)
            {
                listaValidacion.Add("El campo Localidad es obligatorio");
            }
            if (this.cliCiudad.Text == String.Empty)
            {
                listaValidacion.Add("El campo Ciudad es obligatorio");
            }
            if (this.cliFechaNac.Text == String.Empty)
            {
                listaValidacion.Add("El campo Fecha de nacimiento es obligatorio");
            }


            //Valido los campos numericos
            try
            {
                documento = Convert.ToInt32(this.cliDni.Text);
            }
            catch
            {
                listaValidacion.Add("El Documento debe ser numerico");
            }

            try
            {
                nro_calle_val = Convert.ToInt32(this.nroCalle.Text);
            }
            catch
            {
                listaValidacion.Add("El Nro de calle debe ser numerico");
            }

            try
            {
                cuil_val = Convert.ToInt32(this.cuil.Text);
            }
            catch
            {
                listaValidacion.Add("El CUIL debe ser numerico");
            }

            try
            {
                if(this.cliPiso.Text != String.Empty)
                    nro_piso_val = Convert.ToInt32(this.cliPiso.Text);
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

            //Verifico que el TELEFONO no este repetido
            System.Data.SqlClient.SqlCommand comDupTel = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getUsuarioXTelefono");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter pTel = new System.Data.SqlClient.SqlParameter("@telefono", cliTelefono.Text.Trim());
            comDupTel.Parameters.Add(pTel);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader dupTel = AccesoDatos.getInstancia().ejecutaSP(comDupTel);

            if (dupTel.HasRows)
            {
                MessageBox.Show("Ya existe un usuario con ese numero de Telefono.");
                // Cierro la conexion
                dupTel.Close();
                AccesoDatos.getInstancia().cerrarConexion();
                return;
            }

            // Cierro la conexion
            dupTel.Close();
            AccesoDatos.getInstancia().cerrarConexion();


            /////////////////////////////////////////////////////////////
            //ACA TENGO QUE AGREGAR EL CODIGO DE VALIDACION DEL CUIL/CUIT
            /////////////////////////////////////////////////////////////
            
            //Verifico que el CUIT / CUIL no este repetido
            System.Data.SqlClient.SqlCommand comDupCUIT = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getUsuarioXCUIT");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter pcuit1 = new System.Data.SqlClient.SqlParameter("@cuit", cuil.Text.Trim());
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
            
            
            //Verifico que el dni no este repetido
            System.Data.SqlClient.SqlCommand comDup = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getClienteXTipoNroDoc");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter p1 = new System.Data.SqlClient.SqlParameter("@tipo_doc", int.Parse(cliTipoDoc.SelectedValue.ToString()));
            comDup.Parameters.Add(p1);

            System.Data.SqlClient.SqlParameter p2 = new System.Data.SqlClient.SqlParameter("@nro_doc", documento);
            comDup.Parameters.Add(p2);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader dup = AccesoDatos.getInstancia().ejecutaSP(comDup);

            if (dup.HasRows)
            {
                MessageBox.Show("Ya existe un usuario con ese tipo y numero de documento.");
                // Cierro la conexion
                dup.Close();
                AccesoDatos.getInstancia().cerrarConexion();
                return;
            }

            // Cierro la conexion
            dup.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            ///////////////////////////////
            //Persisto el usuario cliente//
            ///////////////////////////////

            tipoDoc = this.cliTipoDoc.SelectedValue.ToString();

            // Nombre del SP
            string sql_qry = "LOS_GESTORES.sp_app_creaUsuarioCliente";

            //comando pasado como parametro
            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql_qry);

            //Defino los parametros y los agrego a la lista de parametros
            System.Data.SqlClient.SqlParameter nombre_usu = new System.Data.SqlClient.SqlParameter("@nombre_usu", this.usr_nombre);
            com.Parameters.Add(nombre_usu);

            System.Data.SqlClient.SqlParameter pass_usu = new System.Data.SqlClient.SqlParameter("@pass", this.usr_pass);
            com.Parameters.Add(pass_usu);

            System.Data.SqlClient.SqlParameter calle_usu = new System.Data.SqlClient.SqlParameter("@calle", this.cliDireccion.Text);
            com.Parameters.Add(calle_usu);

            System.Data.SqlClient.SqlParameter nro_calle_usu = new System.Data.SqlClient.SqlParameter("@nro_calle", nro_calle_val);
            com.Parameters.Add(nro_calle_usu);

            if (this.cliPiso.Text != String.Empty)
            {
                System.Data.SqlClient.SqlParameter piso_usu = new System.Data.SqlClient.SqlParameter("@piso", nro_piso_val);
                com.Parameters.Add(piso_usu);
            }

            System.Data.SqlClient.SqlParameter depto_usu = new System.Data.SqlClient.SqlParameter("@depto", this.cliDpto.Text);
            com.Parameters.Add(depto_usu);

            System.Data.SqlClient.SqlParameter cp_usu = new System.Data.SqlClient.SqlParameter("@cp", this.cliCodPostal.Text);
            com.Parameters.Add(cp_usu);

            System.Data.SqlClient.SqlParameter loc_usu = new System.Data.SqlClient.SqlParameter("@loc", this.cliLocalidad.Text);
            com.Parameters.Add(loc_usu);

            System.Data.SqlClient.SqlParameter ciudad_usu = new System.Data.SqlClient.SqlParameter("@ciudad", this.cliCiudad.Text);
            com.Parameters.Add(ciudad_usu);

            System.Data.SqlClient.SqlParameter mail_usu = new System.Data.SqlClient.SqlParameter("@mail", this.cliEmail.Text);
            com.Parameters.Add(mail_usu);

            System.Data.SqlClient.SqlParameter tipo_doc_usu = new System.Data.SqlClient.SqlParameter("@id_tipodoc", int.Parse(this.cliTipoDoc.SelectedValue.ToString()));
            com.Parameters.Add(tipo_doc_usu);

            System.Data.SqlClient.SqlParameter nro_doc_usu = new System.Data.SqlClient.SqlParameter("@nro_doc", documento);
            com.Parameters.Add(nro_doc_usu);

            System.Data.SqlClient.SqlParameter apellido_usu = new System.Data.SqlClient.SqlParameter("@apellido", this.cliApellido.Text);
            com.Parameters.Add(apellido_usu);

            System.Data.SqlClient.SqlParameter nombre_cli = new System.Data.SqlClient.SqlParameter("@nombre_cli", this.cliNombre.Text);
            com.Parameters.Add(nombre_cli);

            System.Data.SqlClient.SqlParameter fnac_usu = new System.Data.SqlClient.SqlParameter("@f_nac", this.cliFechaNac.Value);
            com.Parameters.Add(fnac_usu);

            System.Data.SqlClient.SqlParameter cuil_usu = new System.Data.SqlClient.SqlParameter("@cuil", this.cuil.Text);
            com.Parameters.Add(cuil_usu);

            System.Data.SqlClient.SqlParameter tel_usu = new System.Data.SqlClient.SqlParameter("@tel", cliTelefono.Text.Trim());
            com.Parameters.Add(tel_usu);


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
