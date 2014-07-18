using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaCommerce.Model;

namespace FrbaCommerce.Calificar_Vendedor
{
    public partial class Form1 : Form
    {

        private int id_usuario;

        public Form1(int p_id_usuario)
        {
            InitializeComponent();
            id_usuario = p_id_usuario;
        }



        private void Calificar_Click(object sender, EventArgs e)
        {
            
            // Validación

            if (Producto.SelectedValue == null)
                MessageBox.Show("Seleccione un Producto");

            if (Calificacion.SelectedValue == null)
                MessageBox.Show("Seleccione una Calificación");

            if (Estrellas.SelectedItem == null)
                MessageBox.Show("Seleccione la cantidad de Estrellas");

            if ((Producto.SelectedValue != null) &&
                 (Calificacion.SelectedValue != null) &&
                 (Estrellas.SelectedItem != null))
            {

                // Calificación

                ConectorSQL.traerDataTable( "setCalificarVendedor", 
                                            Producto.SelectedValue,
                                            Calificacion.SelectedValue,
                                            Estrellas.SelectedItem,
                                            Comentario.Text);
                
                MessageBox.Show("Calificacion otorgada");
                
                this.Close();
            
            }
            
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Cargo Publicaciones
            Producto.DataSource = ConectorSQL.traerDataTable("getPublicacionesSinCalificar", id_usuario);
            Producto.ValueMember = "id_venta";
            Producto.DisplayMember = "descripcion";

            // Cargo Tipo Calificaciones
            Calificacion.DataSource = ConectorSQL.traerDataTable("getTipoCalificacion");
            Calificacion.ValueMember = "id_tipo_calificacion";
            Calificacion.DisplayMember = "descripcion";

            Calificacion.SelectedValue = 2;

            // Defino valor default Estrellas
            Estrellas.SelectedItem = "";

        }
    }
}
