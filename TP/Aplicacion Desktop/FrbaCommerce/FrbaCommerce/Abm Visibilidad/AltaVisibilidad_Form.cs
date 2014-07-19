using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Abm_Visibilidad
{
    public partial class Alta_Visibilidad : Form
    {
        public Alta_Visibilidad()
        {
            InitializeComponent();
        }

        private void Alta_Visibilidad_Load(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            List<string> listaValidacion = new List<string>();

            //Validamos los campos obligatorios
            if (this.visCodigo.Text == String.Empty)
            {
                listaValidacion.Add("El campo Código es obligatorio");
            }

            if (this.visDescrip.Text == String.Empty)
            {
                listaValidacion.Add("El campo Descripción es obligatorio");
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

            //Verifico que no se haya agregado la visibilidad
            System.Data.SqlClient.SqlCommand comDupCod = new System.Data.SqlClient.SqlCommand("LOS_GESTORES.sp_app_getVisibilidadXCodigo");
           
            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader dupVisib = AccesoDatos.getInstancia().ejecutaSP(comDupCod);

            if (dupVisib.HasRows)
            {
                MessageBox.Show("Ya existe una visibilidad con ese codigo.");
                // Cierro la conexion
                dupVisib.Close();
                AccesoDatos.getInstancia().cerrarConexion();
                return;
            }

            // Cierro la conexion
            dupVisib.Close();
            AccesoDatos.getInstancia().cerrarConexion();


            ///////////////////////////////
            //Persisto la Visibilidad    //
            ///////////////////////////////


            // Nombre del SP
            string sql_qry = "LOS_GESTORES.sp_app_crearVisibilidad";

            //comando pasado como parametro
            System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(sql_qry);

            //Defino los parametros y los agrego a la lista de parametros
            System.Data.SqlClient.SqlParameter visCodig = new System.Data.SqlClient.SqlParameter("@codigo", this.visCodigo);
            com.Parameters.Add(visCodig);

            System.Data.SqlClient.SqlParameter visDescrip = new System.Data.SqlClient.SqlParameter("@descripcion", this.visDescrip);
            com.Parameters.Add(visDescrip);

            //Defino los parametros y los agrego a la lista de parametros
            System.Data.SqlClient.SqlParameter visPrecio = new System.Data.SqlClient.SqlParameter("@precio", this.visPrecio);
            com.Parameters.Add(visPrecio);

            System.Data.SqlClient.SqlParameter visPorc = new System.Data.SqlClient.SqlParameter("@porcentaje", this.visPorc);
            com.Parameters.Add(visPorc);

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            System.Data.SqlClient.SqlDataReader datos = AccesoDatos.getInstancia().ejecutaSP(com);

            MessageBox.Show("Felicitaciones se ha dado de alta la visibilidad");

            // Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();

            this.Close();

        }
    }
}
