﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using FrbaCommerce.Model;

namespace FrbaCommerce
{
    public partial class Form1 : Form
    {
        private DataAccessLayer dataAccess;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
			//hasta aca YP
			//esta logica no debería ir acá
            Form hc = new Historial_Cliente.Form1();
			 hc.Show();
        }

        private void CalificarVendedor_Click(object sender, EventArgs e)
        {
            Form cv = new Calificar_Vendedor.Form1();
            cv.Show();
        }
		
		
		 private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        private void FacturarPublicaciones_Click(object sender, EventArgs e)
        {
            Form fp = new Facturar_Publicaciones.FacturarPublicaciones();
            fp.Show();
        }

        private void ListadoEstadistico_Click(object sender, EventArgs e)
        {
            Form le = new Listado_Estadistico.Form1();
            le.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro_de_Usuario.Registro_Form regF = new FrbaCommerce.Registro_de_Usuario.Registro_Form();
            regF.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
