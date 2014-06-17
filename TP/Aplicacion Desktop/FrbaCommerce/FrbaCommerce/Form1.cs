﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HistorialClientes_Click(object sender, EventArgs e)
        {
            Form hc = new Historial_Cliente.Form1();
            hc.Show();
        }

        private void CalificarVendedor_Click(object sender, EventArgs e)
        {
            Form cv = new Calificar_Vendedor.Form1();
            cv.Show();
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
    }
}
