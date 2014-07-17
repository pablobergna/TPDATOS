using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Model;
using FrbaCommerce;

namespace FrbaCommerce.Editar_Publicacion
{
    public partial class Editar_Publicacion : Form
    {
        private Publicacion publicacion_actual = new Publicacion();
        private Publicacion publicacion_modificada = new Publicacion();
        private DateTime fecha_sistema;

        public Editar_Publicacion(int usuario, DateTime fecha)
        {
            InitializeComponent();
            publicacion_actual.id_usuario = usuario;
            publicacion_modificada.id_usuario = usuario;
            fecha_sistema = fecha;
        }

        private void Editar_Publicacion_Load(object sender, EventArgs e)
        {

        }
    }
}
