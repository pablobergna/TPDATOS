using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;

namespace FrbaCommerce
{
    public partial class Principal : Form
    {
        private int ppal_id_usuario;
        private int ppal_id_rol;
        private DateTime ppal_fecha_sistema;
        
        public Principal()
        {
            InitializeComponent();
        }

        private void link_registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro_de_Usuario.Registro_Form regF = new FrbaCommerce.Registro_de_Usuario.Registro_Form();
            regF.ShowDialog();
        }

        private void login_btnIngresar_Click(object sender, EventArgs e)
        {
            //Valido el usuario y contraseña
            List<string> listaValidacion = new List<string>();
            string pass_BD;
            string pass_ingresada;
            int id_usuario;
            int intentos_fallidos;
            string estado_usu;
            int forzar_cambio;
            SHA256Managed encriptacionSha256 = new SHA256Managed();

            //Validamos los campos obligatorios
            if (this.login_txtUsr.Text == String.Empty)
            {
                listaValidacion.Add("El Nombre de usuario es obligatorio");
            }

            if (this.login_txtpass.Text == String.Empty)
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
            
            /////////////////////////
            //Validacion del login //
            /////////////////////////
            pass_ingresada =
                Convert.ToBase64String(encriptacionSha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(this.login_txtpass.Text)));

            //Traigo la contraseña de la BD
            System.Data.SqlClient.SqlCommand comPass = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getPassXNombre");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter p1 = new System.Data.SqlClient.SqlParameter("@nombre", this.login_txtUsr.Text.Trim());

            //Agrego el parametro a la lista de parametros
            comPass.Parameters.Add(p1);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader dup = AccesoDatos.getInstancia().ejecutaSP(comPass);

            if (!dup.HasRows)
            {
                // Cierro la conexion
                dup.Close();
                AccesoDatos.getInstancia().cerrarConexion();

                MessageBox.Show("Usuario Inexistente");
                return;
            }

            dup.Read();
            pass_BD = dup.GetString(0);
            intentos_fallidos = dup.GetInt16(1);
            estado_usu = dup.GetString(2);
            forzar_cambio = dup.GetInt16(3);

            // Cierro la conexion
            dup.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            if (!estado_usu.Equals("Habilitado"))
            {
                MessageBox.Show("Su usuario no puede ingresar al sistema, contactese con los administradores");
                return;
            }
            
            if (!pass_ingresada.Equals(pass_BD))
            {
                //Registro el intento fallido
                System.Data.SqlClient.SqlCommand comFalla = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_setFallaLoginXNombre");

                //Defino los parametros
                System.Data.SqlClient.SqlParameter pFalla = new System.Data.SqlClient.SqlParameter("@nombre", this.login_txtUsr.Text.Trim());

                //Agrego el parametro a la lista de parametros
                comFalla.Parameters.Add(pFalla);

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                System.Data.SqlClient.SqlDataReader falla = AccesoDatos.getInstancia().ejecutaSP(comFalla);

                // Cierro la conexion
                falla.Close();
                AccesoDatos.getInstancia().cerrarConexion();
                
                MessageBox.Show("Contraseña incorrecta");
                return;
            }

            //Reseteo los intentos fallidos
            System.Data.SqlClient.SqlCommand comReset = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_resetIntentosXNombre");

            //Defino los parametros
            System.Data.SqlClient.SqlParameter pReset = new System.Data.SqlClient.SqlParameter("@nombre", this.login_txtUsr.Text.Trim());

            //Agrego el parametro a la lista de parametros
            comReset.Parameters.Add(pReset);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader reset = AccesoDatos.getInstancia().ejecutaSP(comReset);

            // Cierro la conexion
            reset.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            ////////////////////////////////
            //     Roles del usuario      //
            ////////////////////////////////
            //Primero traigo el ID de Usuario
            System.Data.SqlClient.SqlCommand comUsuario = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getIdUsuarioXNombre");
            //Defino los parametros
            System.Data.SqlClient.SqlParameter pUsu = new System.Data.SqlClient.SqlParameter("@nombre", this.login_txtUsr.Text.Trim());
            //Agrego el parametro a la lista de parametros
            comUsuario.Parameters.Add(pUsu);
            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();
            System.Data.SqlClient.SqlDataReader idusuario = AccesoDatos.getInstancia().ejecutaSP(comUsuario);

            idusuario.Read();
            id_usuario = idusuario.GetInt32(0);

            // Cierro la conexion
            reset.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            //Traigo los roles asociados
            System.Data.SqlClient.SqlCommand comRoles = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getRolesUsuario");
            System.Data.SqlClient.SqlParameter pRoles = new System.Data.SqlClient.SqlParameter("@id_usuario", id_usuario);
            comRoles.Parameters.Add(pRoles);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();
            System.Data.SqlClient.SqlDataReader roles = AccesoDatos.getInstancia().ejecutaSP(comRoles);

            //Cargo el array del resultado
            ArrayList listaRoles = new ArrayList();
            int it=0;
            while (roles.Read())
            {
                listaRoles.Add(new DTO.RolDTO(roles.GetInt32(0),roles.GetString(1)));
                it++;
            }

            // Cierro la conexion
            roles.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            if (listaRoles.Count == 0)
            {
                MessageBox.Show("No posee roles habilitados en el sistema. Contactese con los administradores");
                return;
            }

            //Si tiene mas de un rol despliego el form de seleccion
            int id_rol_seleccionado;
            if (listaRoles.Count > 1)
            {
                Perfil fPerfil = new Perfil(listaRoles);
                fPerfil.ShowDialog();
                id_rol_seleccionado = fPerfil.getRolSeleccionado();
            }
            else
            {
                id_rol_seleccionado = ((DTO.RolDTO)listaRoles[0]).idRol;
            }

            if (forzar_cambio == 1)
            {
                MessageBox.Show("Debe modificar su contraseña.");

                Pass.ModPass fPass = new FrbaCommerce.Pass.ModPass();
                fPass.idusuario = this.ppal_id_usuario;
                fPass.ShowDialog();
                return;
            }

            this.ppal_id_rol = id_rol_seleccionado;
            this.ppal_id_usuario = id_usuario;

            //Traigo las funciones asociadas al rol
            System.Data.SqlClient.SqlCommand comFunc = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getFuncionesRol");
            System.Data.SqlClient.SqlParameter pFunc = new System.Data.SqlClient.SqlParameter("@id_rol", ppal_id_rol);
            comFunc.Parameters.Add(pFunc);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();
            System.Data.SqlClient.SqlDataReader funciones = AccesoDatos.getInstancia().ejecutaSP(comFunc);

            //Cargo el array del resultado
            ArrayList listaFunc = new ArrayList();
            while (funciones.Read())
            {
                listaFunc.Add(new DTO.RolDTO(funciones.GetInt32(0), funciones.GetString(1)));
            }

            // Cierro la conexion
            funciones.Close();
            AccesoDatos.getInstancia().cerrarConexion();

            listaFunciones.DataSource = listaFunc;
            listaFunciones.DisplayMember = "descRol";
            listaFunciones.ValueMember = "idRol";


            // Blanqueo y Habilito el proximo panel
            this.login_txtUsr.Clear();
            this.login_txtpass.Clear();
            this.panelInicio.Hide();
            this.panelPpal.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.panelPpal.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelInicio.Show();
            this.panelPpal.Hide();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelPpal.Hide();
            this.panelInicio.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.panelPpal.Hide();
            this.panelInicio.Show();
            
        }

        private void linkSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo)
                  == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void linkSalirLogueado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la sesion?", "Salir", MessageBoxButtons.YesNo)
                  == DialogResult.Yes)
            {
                this.panelPpal.Hide();
                this.panelInicio.Show();
            }
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            string funcion = listaFunciones.Text.Trim();

            //Muestro el form que corresponda segun la seleccion
            switch (funcion)
            {
                case "Gestionar Preguntas":
                    Gestion_de_Preguntas.Gestion_de_Preguntas fGpreg = new FrbaCommerce.Gestion_de_Preguntas.Gestion_de_Preguntas(ppal_id_usuario, ppal_fecha_sistema);
                    fGpreg.ShowDialog();
                    break;

                case "Publicar":
                    Generar_Publicacion.Form1 fPub = new FrbaCommerce.Generar_Publicacion.Form1(ppal_id_usuario, ppal_fecha_sistema);
                    fPub.ShowDialog();
                    break;
                
                case "Comprar":
                    
                    break;
                
                case "Facturar Publicaciones":
                    Facturar_Publicaciones.FacturarPublicaciones fFact = new FrbaCommerce.Facturar_Publicaciones.FacturarPublicaciones();
                    fFact.ShowDialog();
                    break;
                
                case "Listar Estadisticas":
                    Listado_Estadistico.Form1 fEst = new FrbaCommerce.Listado_Estadistico.Form1();
                    fEst.ShowDialog();
                    break;
                
                case "Visualizar Historial":
                    Historial_Cliente.Form1 fHis = new FrbaCommerce.Historial_Cliente.Form1(ppal_id_usuario);
                    fHis.ShowDialog();
                    break;
                
                case "ABM Roles":
                
                    break;
                
                case "ABM Usuarios":
                    Abm_Cliente.Listado fLista = new FrbaCommerce.Abm_Cliente.Listado();
                    fLista.ShowDialog();
                    break;
                
                case "ABM Rubros":
                
                    break;
                
                case "ABM Visibilidad":
                
                    break;

                case "Calificar Vendedor":
                    Calificar_Vendedor.Form1 fCalVen = new FrbaCommerce.Calificar_Vendedor.Form1(ppal_id_usuario);
                    fCalVen.ShowDialog();
                    break;
                
                default:
                
                    break;
            }
        }

        private void btnModifPass_Click(object sender, EventArgs e)
        {
            Pass.ModPass fPas = new FrbaCommerce.Pass.ModPass();

            fPas.idusuario = this.ppal_id_usuario;
            fPas.ShowDialog();
        }

        

        

        
    }
}
