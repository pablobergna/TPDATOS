using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class FacturarPublicaciones : Form
    {
        public FacturarPublicaciones()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ( comboBox1.GetItemText( comboBox1.SelectedItem ) )
            {
                case "Efectivo":
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    Emisora.Hide();
                    Banco.Hide();
                    Numero.Hide();
                    Vencimiento.Hide();
                    CodigoDeSeguridad.Hide();
                    break;
                case "Tarjeta de Credito":
                    label2.Show();
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    label6.Show();
                    Emisora.Show();
                    Banco.Show();
                    Numero.Show();
                    Vencimiento.Show();
                    CodigoDeSeguridad.Show();
                    break;
            }
        }

        private void FacturarPublicaciones_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            Emisora.Hide();
            Banco.Hide();
            Numero.Hide();
            Vencimiento.Hide();
            CodigoDeSeguridad.Hide();
        }

        private void Pagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su pago se ha realizado con exito");
            this.Close();
        }
    }
}
