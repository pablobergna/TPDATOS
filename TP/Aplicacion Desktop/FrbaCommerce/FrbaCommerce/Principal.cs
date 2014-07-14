using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class Principal : Form
    {
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
            
            this.panelInicio.Hide();
            this.panel1.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panelInicio.Show();
            this.panel1.Hide();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();
            this.panelInicio.Show();
        }
    }
}
