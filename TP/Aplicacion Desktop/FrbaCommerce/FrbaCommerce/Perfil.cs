using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce;
using System.Collections;

namespace FrbaCommerce
{
    public partial class Perfil : Form
    {
        private int id_rol;

        public int getRolSeleccionado()
        {
            return id_rol;
        }

        public Perfil(ArrayList lista)
        {
            InitializeComponent();

            cmbPerfil.DataSource = lista;
            cmbPerfil.DisplayMember = "descRol";
            cmbPerfil.ValueMember = "idRol";
        }


        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            id_rol = Convert.ToInt32(cmbPerfil.SelectedValue);
            this.Close();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {

        }

        


    }
}
