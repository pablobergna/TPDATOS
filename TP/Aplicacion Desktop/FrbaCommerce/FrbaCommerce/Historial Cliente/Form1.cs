using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        }
    }
}
