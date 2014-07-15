using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;

namespace FrbaCommerce
{
    class AccesoDatos
    {
        private static System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        private static AccesoDatos instancia = null;

        public static AccesoDatos getInstancia()
        {
            if (instancia == null)
            {
                //con.ConnectionString = ConfigurationManager.AppSettings["GD1C2014"].ToString();
                con.ConnectionString = "Data Source=localhost\\SQLSERVER2008;User ID=gd;Password=gd2014";
                instancia = new AccesoDatos();
            }

            return instancia;
        }

        public void abrirConexion()
        {
            if(con.State.Equals(ConnectionState.Closed))
                con.Open();
        }

        public void cerrarConexion()
        {
            if (con.State.Equals(ConnectionState.Open))
                con.Close();
        }


        public System.Data.DataSet consultaSimple(string sql_qry)
        {
            System.Data.SqlClient.SqlDataAdapter adaptador = new System.Data.SqlClient.SqlDataAdapter(sql_qry, con);

            System.Data.DataSet datos = new System.Data.DataSet();

            adaptador.Fill(datos, "resultado");

            return datos;
        }

        public System.Data.SqlClient.SqlDataReader ejecutaSP(System.Data.SqlClient.SqlCommand  comando)
        {
            comando.Connection = con;
            comando.CommandType = CommandType.StoredProcedure;

            System.Data.SqlClient.SqlDataReader datos = comando.ExecuteReader();

            return datos;

        }
        

    }
}
