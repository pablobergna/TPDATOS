using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaCommerce.Model;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Reporte.GetItemText(Reporte.SelectedItem))
            {
                case "Vendedores con mayor cantidad de productos no vendidos":
                    label4.Show();
                    label5.Show();
                    Visibilidad.Show();
                    Mes.Show();
                    dataGridView1.Show();
                    dataGridView2.Hide();
                    dataGridView3.Hide();
                    dataGridView4.Hide();
                    break;
                case "Vendedores con mayor facturación":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    Mes.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Show();
                    dataGridView3.Hide();
                    dataGridView4.Hide();
                    break;
                case "Vendedores con mayores calificaciones":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    Mes.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Hide();
                    dataGridView3.Show();
                    dataGridView4.Hide();
                    break;
                case "Clientes con mayor cantidad de publicaciones sin calificar":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    Mes.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Hide();
                    dataGridView3.Hide();
                    dataGridView4.Show();
                    break;            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            




            Visibilidad.DataSource = ConectorSQL.traerDataTable("getVisibilidadLE");
            Visibilidad.DisplayMember = "descripcion";
            Visibilidad.ValueMember = "id_visibilidad";
            Visibilidad.SelectedValue = -1;




            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Reporte.GetItemText(Reporte.SelectedItem))
            {
                case "Vendedores con mayor cantidad de productos no vendidos":
                    dataGridView1.DataSource = ConectorSQL.traerDataTable("getListadoEstadistico1",
                                                                            Anio.Text,
                                                                            Trimestre.Text,
                                                                            Mes.Text,
                                                                            Visibilidad.SelectedValue);
                    break;
                case "Vendedores con mayor facturación":
                    dataGridView2.DataSource = ConectorSQL.traerDataTable("getListadoEstadistico2", 1, "1-2013"); // Reemplazar Parametros
                    break;
                case "Vendedores con mayores calificaciones":
                    dataGridView3.DataSource = ConectorSQL.traerDataTable("getListadoEstadistico3", 1, "1-2013"); // Reemplazar Parametros
                    break;
                case "Clientes con mayor cantidad de publicaciones sin calificar":
                    dataGridView4.DataSource = ConectorSQL.traerDataTable("getListadoEstadistico4", 1, "1-2013"); // Reemplazar Parametros
                    break;
            }
        }

        private void Visibilidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Visibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            //DataRow selectedDataRow = ((DataRowView)Visibilidad.SelectedItem).Row;
            //int visibilidadID = Convert.ToInt32(selectedDataRow["id_visibilidad"]);
            //string visibilidadName = selectedDataRow["descripcion"].ToString();

            //int selectedValue = Convert.ToInt32(Visibilidad.SelectedValue);

            //MessageBox.Show( visibilidadName );

        }
    }
}
