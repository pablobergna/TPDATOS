using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaCommerce
{
    class AccesoDatos
    {
        private string str_con;
        private string sql_qry;

        public string sql { set { sql_qry = value; } }

        public string str_conexion { set { str_con = value; } }

        public AccesoDatos(string string_conexion, string query)
        {
            str_con = string_conexion;
            sql_qry = query;
        }

        public System.Data.DataSet consultaSimple()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(str_con);
            
            con.Open();

            System.Data.SqlClient.SqlDataAdapter adaptador = new System.Data.SqlClient.SqlDataAdapter(sql_qry, con);

            System.Data.DataSet datos = new System.Data.DataSet();

            adaptador.Fill(datos, "resultado");

            con.Close();

            return datos;

        }
    }
}
