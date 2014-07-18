using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaCommerce.Model;

namespace FrbaCommerce.Listado_Estadistico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Habilitamos el botón
            button1.Enabled = true;

            // Mostramos u ocultamos los items
            switch (Reporte.GetItemText(Reporte.SelectedItem))
            {
                case "Vendedores con mayor cantidad de productos no vendidos":
                    label4.Show();
                    label5.Show();
                    Visibilidad.Show();
                    Mes.Show();
                    dataGridView1.Show();
                    dataGridView2.Hide();
                    dataGridView3.Hide();
                    dataGridView4.Hide();
                    break;
                case "Vendedores con mayor facturación":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    Mes.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Show();
                    dataGridView3.Hide();
                    dataGridView4.Hide();
                    break;
                case "Vendedores con mayores calificaciones":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    Mes.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Hide();
                    dataGridView3.Show();
                    dataGridView4.Hide();
                    break;
                case "Clientes con mayor cantidad de publicaciones sin calificar":
                    label4.Hide();
                    label5.Hide();
                    Visibilidad.Hide();
                    Mes.Hide();
                    dataGridView1.Hide();
                    dataGridView2.Hide();
                    dataGridView3.Hide();
                    dataGridView4.Show();
                    break;            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Ocultamos los items
            label2.Hide();
            Trimestre.Hide();
            label3.Hide();
            Reporte.Hide();
            label5.Hide();
            Mes.Hide();
            label4.Hide();
            Visibilidad.Hide();

            // Ocultamos todos los reportes
            dataGridView1.Hide();
            dataGridView2.Hide();
            dataGridView3.Hide();
            dataGridView4.Hide();

            // Cargamos el Combo Visibilidad
            Visibilidad.DataSource = ConectorSQL.traerDataTable("getVisibilidadLE");
            Visibilidad.DisplayMember = "descripcion";
            Visibilidad.ValueMember = "id_visibilidad";
            Visibilidad.SelectedValue = -1;

            // Deshabilitamos el botón
            button1.Enabled = false;

            // Seteamos el valor default del combo
            Mes.SelectedItem = "Seleccionar";

        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            int v_mes;

            if (Mes.Text.Equals("Seleccionar"))
                v_mes = 0;
            else
                v_mes = Convert.ToInt32(Mes.Text);


            // Aplicamos los filtros
            switch (Reporte.GetItemText(Reporte.SelectedItem))
            {

                case "Vendedores con mayor cantidad de productos no vendidos":
                    dataGridView1.DataSource = ConectorSQL.traerDataTable( "getListadoEstadistico1",
                                                                            Anio.Text,
                                                                            Trimestre.Text,
                                                                            v_mes,
                                                                            Visibilidad.SelectedValue );
                    break;

                case "Vendedores con mayor facturación":
                    dataGridView2.DataSource = ConectorSQL.traerDataTable( "getListadoEstadistico2",
                                                                            Anio.Text,
                                                                            Trimestre.Text );
                    break;

                case "Vendedores con mayores calificaciones":
                    dataGridView3.DataSource = ConectorSQL.traerDataTable( "getListadoEstadistico3",
                                                                            Anio.Text,
                                                                            Trimestre.Text );
                    break;

                case "Clientes con mayor cantidad de publicaciones sin calificar":
                    dataGridView4.DataSource = ConectorSQL.traerDataTable( "getListadoEstadistico4",
                                                                            Anio.Text,
                                                                            Trimestre.Text );
                    break;

            }
        }



        private void Visibilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            //DataRow selectedDataRow = ((DataRowView)Visibilidad.SelectedItem).Row;
            //int visibilidadID = Convert.ToInt32(selectedDataRow["id_visibilidad"]);
            //string visibilidadName = selectedDataRow["descripcion"].ToString();

            //int selectedValue = Convert.ToInt32(Visibilidad.SelectedValue);

            //MessageBox.Show( visibilidadName );

        }

        private void Anio_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Show();
            Trimestre.Show();
        }

        private void Trimestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Show();
            Reporte.Show();
        }

    }
}
