using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCommerce.Model;

namespace FrbaCommerce.Abm_Cliente
{
    public partial class Alta_Cliente : Form
    {
        private DataAccessLayer dataAccess;

        public Alta_Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Alta_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefono_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void ACliPiso_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void LimpiarCampos() 
        {
            this.cliNombre.Clear();
            this.cliApellido.Clear();
            this.cliTipoDoc = null;
            this.cliDni.Clear();
            this.cliEmail.Clear();
            this.cliTelefono.Clear();
            this.cliDireccion.Clear();
            this.cliPiso.Clear();
            this.cliDpto.Clear();
            this.cliLocalidad.Clear();
            this.cliCodPostal.Clear();
            //this.cliFechaNac.Clear();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            int documento = 0;
            int telefono = 0;
            string tipoDoc = "";

            List<string> listaValidacion = new List<string>();
            Cliente cli = new Cliente();

            //Validamos los campos obligatorios
            if(this.cliNombre.Text == String.Empty)
            {
                listaValidacion.Add("El campo Nombre es obligatorio");
            }

            if(this.cliApellido.Text == String.Empty)
            {
                listaValidacion.Add("El campo Apellido es obligatorio");
            }

            if (this.cliDni.Text == String.Empty)
            {
                listaValidacion.Add("El campo Dni es obligatorio");

            }
            
            //Valido los campos numericos
            try {
                documento = Convert.ToInt32(this.cliDni.Text);
            } catch {
                listaValidacion.Add("El Documento debe ser numerico");
            }

            try {
                telefono = Convert.ToInt32(this.cliTelefono.Text);
            } catch {
                listaValidacion.Add("El Telefono debe ser numerico");
            }

            //Muestro un mensaje con los datos mal cargados
            if (listaValidacion.Count > 0)
            {
                StringBuilder error = new StringBuilder();
                error.AppendLine("Por favor corrija los siguientes campos:");

                foreach (var i in listaValidacion)
                {
                    error.AppendLine(i);
                }

                MessageBox.Show(error.ToString());
            }

            //Verifico que el usuario no haya sido dado de alta
            documento = Convert.ToInt32(this.cliDni.Text);
            tipoDoc = this.cliTipoDoc.SelectedValue.ToString();

            //realizar el metodo searchCliente
            bool DniRepetido = true;//this.dataAccess.searchCliente(null, tipoDoc, documento).Count() > 0;
                
            if (DniRepetido)
            {
                MessageBox.Show("Ya existe un cliente cargado con el documento ingresado.");
            }
            else {
                telefono = Convert.ToInt32(this.cliTelefono.Text);
                
                //Persisto el Cliente
                cli.cliNombre    = this.cliNombre.Text;
                cli.cliApellido  = this.cliApellido.Text;
                cli.cliTipoDoc   = this.cliTipoDoc.SelectedValue.ToString();
                cli.cliDni       = documento;
                cli.cliEmail     = this.cliEmail.Text;
                cli.cliTelefono  = telefono;
                cli.cliDireccion = this.cliDireccion.Text;
                cli.cliPiso      = this.cliPiso.Text;
                cli.cliDpto      = this.cliDpto.Text;
                cli.cliLocalidad = this.cliLocalidad.Text;
                cli.cliApellido  = this.cliCodPostal.Text;
                cli.cliFechaNac  = this.cliFechaNac.Value;

                //Realizar el metodo saveCliente
               // this.dataAccess.saveCliente(cli);
                LimpiarCampos();

            }

           

          
        }
    }
}
