using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FrbaCommerce.Usuario_Rol
{
    public partial class SeleccionRol : Form
    {
        public SeleccionRol()
        {
            InitializeComponent();
        }

        public SeleccionRol(ArrayList lista)
        {
            InitializeComponent();

            lstRol.DataSource = lista;
            lstRol.DisplayMember = "descRol";
            lstRol.ValueMember = "idRol";
        }
        
        private void SeleccionRol_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
