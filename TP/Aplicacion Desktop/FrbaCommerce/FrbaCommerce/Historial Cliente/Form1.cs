using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace FrbaCommerce.Historial_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.GetItemText(comboBox1.SelectedItem).ToString())
            {
                case "Compras":
                    dgCompras.Show();
                    dgOfertas.Hide();
                    dgCalificaciones.Hide();
                    break;
                case "Ofertas":
                    dgCompras.Hide();
                    dgOfertas.Show();
                    dgCalificaciones.Hide();
                    break;
                case "Calificaciones":
                    dgCompras.Hide();
                    dgOfertas.Hide();
                    dgCalificaciones.Show();
                    break;
            
            }    
        }

        private void dgCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgCompras.Hide();
            dgOfertas.Hide();
            dgCalificaciones.Hide();

            puebaQuery();

        }

        /*
        private void pruebaSP()
        {

            using (SqlConnection conn = new SqlConnection("connection string"))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("<nombre del storedProcedure", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter paramId = new SqlParameter("Id", SqlDbType.Int);
                paramId.Direction = ParameterDirection.Output;
                command.Parameters.Add(paramId);

                command.Parameters.AddWithValue("Nombre", nombre);
                command.Parameters.AddWithValue("Direccion", direccion);
                command.Parameters.AddWithValue("FechaNacimiento", fechaNacimiento);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return Convert.ToInt32(command.Parameters["Id"].Value);
                }
                else
                    return -1;


            }
        

        }

*/


        public void puebaQuery()
        {

            //conn = new SqlConnection("Server=(local);DataBase=master;Integrated Security=SSPI");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("dbo.test", conn);

            SqlConnection sqlConnection1 = new SqlConnection("Server=(local);DataBase=GD1C2014;Integrated Security=SSPI;User ID=gd; Password=gd2014;");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            DataTable dataTable = new DataTable();

            cmd.CommandText = "SELECT top 10 id_factura FROM LOS_GESTORES.Factura";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            dataTable.Load(reader);

            dgCalificaciones.DataSource = dataTable;

            /*
            reader.Read();

            while (reader.Read())
            {
                dgCalificaciones.Rows.Add(reader.GetInt32(0));
            } 

             */ 
            
            sqlConnection1.Close();
        
        }
    }
}
