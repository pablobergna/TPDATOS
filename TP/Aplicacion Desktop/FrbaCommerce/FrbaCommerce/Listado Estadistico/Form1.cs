using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.GetItemText(comboBox3.SelectedItem))
            {
                case "Vendedores con mayor cantidad de productos no vendidos":
                    label4.Show();
                    label5.Show();
                    Visibilidad.Show();
                    MesAnio.Show();
                    dataGridView1.Show();
                    dataGridView2.Hide();
                    dataGridView3.Hide();
                    dataGridView4.Hide();
                    break;
                case "Vendedores con mayor facturación":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    MesAnio.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Show();
                    dataGridView3.Hide();
                    dataGridView4.Hide();
                    break;
                case "Vendedores con mayores calificaciones":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    MesAnio.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Hide();
                    dataGridView3.Show();
                    dataGridView4.Hide();
                    break;
                case "Clientes con mayor cantidad de publicaciones sin calificar":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    MesAnio.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Hide();
                    dataGridView3.Hide();
                    dataGridView4.Show();
                    break;            
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();
        }
    }
}
