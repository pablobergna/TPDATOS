using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce;

namespace FrbaCommerce
{
    public partial class Perfil : Form
    {
        private Int32 user_id;
        public Form parent;
        private DataAccessLayer dataAccess;


        public Perfil()
        {
            InitializeComponent();
        }

        public Perfil(Int32 usuario)
        {
            InitializeComponent();
            this.user_id = usuario;
        }


        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            Main menuPrincipal = new Main(this.dataAccess.getUser(this.user_id, Convert.ToInt32(comboBox1.SelectedValue)));
            menuPrincipal.Show();
            menuPrincipal.parentForm = parent;
            this.Hide();
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parent.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
