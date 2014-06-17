using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ( comboBox1.GetItemText(comboBox1.SelectedItem) )
            {
                case "Producto 1":
                    label2.Text = "Vendedor 1";
                    break;
                case "Producto 2":
                    label2.Text = "Vendedor 2";
                    break;
                case "Producto 3":
                    label2.Text = "Vendedor 3";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calificacion otorgada");
            this.Close();
        }
    }
}
