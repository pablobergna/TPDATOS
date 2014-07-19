﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FrbaCommerce.Model;
using System.Collections;

namespace FrbaCommerce.Facturar_Publicaciones
{
    public partial class FacturarPublicaciones : Form
    {

        private int id_usuario;
        private DateTime fecha_sistema;

        public FacturarPublicaciones(int p_id_usuario, DateTime p_fecha_sistema)
        {
            InitializeComponent();
            id_usuario = p_id_usuario;
            fecha_sistema = p_fecha_sistema;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ( FormaDePago.GetItemText( FormaDePago.SelectedItem ) )
            {
                case "Efectivo":
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    label6.Hide();
                    Emisora.Hide();
                    Banco.Hide();
                    Numero.Hide();
                    Vencimiento.Hide();
                    CodigoDeSeguridad.Hide();
                    break;
                case "Tarjeta de Credito":
                    //label2.Show();
                    label3.Show();
                    label4.Show();
                    label5.Show();
                    //label6.Show();
                    //Emisora.Show();
                    Banco.Show();
                    Numero.Show();
                    Vencimiento.Show();
                    //CodigoDeSeguridad.Show();
                    break;
            }
        }

        private void FacturarPublicaciones_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            Emisora.Hide();
            Banco.Hide();
            Numero.Hide();
            Vencimiento.Hide();
            CodigoDeSeguridad.Hide();

            dgFacturarPublicaciones.DataSource = ConectorSQL.traerDataTable("getFacturarPublicaciones", id_usuario); // Test User

        }

        private void Pagar_Click(object sender, EventArgs e)
        {
            
            // Validaciones
            if (dgFacturarPublicaciones.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Seleccione lo que desea rendir");
                return;
            }
            
            if (!( (FormaDePago.Text == "Efectivo") || (FormaDePago.Text == "Tarjeta de Credito") ))
            {
                MessageBox.Show("Seleccione un Medio de Pago");
                return;                
            }

            if (FormaDePago.Text == "Tarjeta de Credito")
            {
                if (Banco.Text == "")
                {
                    MessageBox.Show("Completar Banco");
                    return;
                }
                if (Numero.Text == "")
                {
                    MessageBox.Show("Completar Numero de Tarjeta de Credito");
                    return;
                }
            }

            /*
            
            int cont;
            int id_publicacion_sel;
            int id_publicacion_dg;

            //DataGridView mi_dg = new DataGridView();
            //DataGridViewSelectedRowCollection mi_dg

            //mi_dg.DataSource = dgFacturarPublicaciones.SelectedRows;

            //MessageBox.Show(Convert.ToString( mi_dg.Rows[0].Cells[1] ));

            //mi_dg.Sort(mi_dg.Columns[4], ListSortDirection.Ascending);






            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dgFacturarPublicaciones.Columns)
                dt.Columns.Add(column.Name, column.CellType); //better to have cell type
            for (int i = 0; i < dgFacturarPublicaciones.SelectedRows.Count; i++)
            {
                dt.Rows.Add();
                for (int j = 0; j < dgFacturarPublicaciones.Columns.Count; j++)
                {
                    dt.Rows[i][j] = dgFacturarPublicaciones.SelectedRows[i].Cells[j];
                    //^^^^^^^^^^^
                }
            }

            MessageBox.Show(Convert.ToString(dt.Rows[0][0]));



            
            for (cont = 0; cont < (dgFacturarPublicaciones.SelectedRows.Count); cont++)
            {
                id_publicacion_sel = Convert.ToInt32(dt.Rows[cont][1].ToString());
                //id_publicacion_sel = Convert.ToInt32(mi_dg.Rows[cont].Cells[1].Value);
                id_publicacion_dg = Convert.ToInt32(this.dgFacturarPublicaciones.Rows[cont].Cells[1].Value);

                if (id_publicacion_sel != id_publicacion_dg)
                {
                    MessageBox.Show("No se puede saltear comisiones por rendir");
                    return;
                }

            }
            ¨*/

            // END Validacion
         
            // Creo los objetos
            DataTable id_factura = new DataTable();
            DataTable id_item = new DataTable();

            // Generar factura y obtener su ID
            id_factura = ConectorSQL.traerDataTable("crearFactura", id_usuario, fecha_sistema.ToString("dd/MM/yyyy"));
            //MessageBox.Show(Convert.ToString( fecha_sistema.ToString("dd/MM/yyyy") ));
            //MessageBox.Show(Convert.ToString(Convert.ToString(fecha_sistema.ToString("dd/mm/yyyy"))));
            //MessageBox.Show(Convert.ToString(id_factura.Rows[0][0]));

            
            int counter;
            int id_publicacion;
            string tipo_comision;
            double monto;
            int cantidad;

            for (counter = 0; counter < (dgFacturarPublicaciones.SelectedRows.Count); counter++)
            {

                id_publicacion = Convert.ToInt32(this.dgFacturarPublicaciones.SelectedRows[counter].Cells[1].Value);
                tipo_comision = Convert.ToString(this.dgFacturarPublicaciones.SelectedRows[counter].Cells[0].Value);
                monto = Convert.ToDouble(this.dgFacturarPublicaciones.SelectedRows[counter].Cells[3].Value);
                cantidad = Convert.ToInt32(this.dgFacturarPublicaciones.SelectedRows[counter].Cells[5].Value);

                // Insertar items y obtengo su ID
                id_item = ConectorSQL.traerDataTable(   "addItemFactura",
                                                        id_factura.Rows[0][0],
                                                        id_publicacion,
                                                        tipo_comision,
                                                        monto,
                                                        cantidad);
                //MessageBox.Show(Convert.ToString( id_item.Rows[0][0] ));

            }

            // Actualizar el Total de la Factura
            ConectorSQL.ejecutarProcedure("updateFacturaTotal", id_factura.Rows[0][0]);
            
            // Registrar pago

            if (FormaDePago.Text == "Efectivo")
                ConectorSQL.ejecutarProcedure("registrarPagoEfectivo", id_factura.Rows[0][0]);

            if (FormaDePago.Text == "Tarjeta de Credito")
                ConectorSQL.ejecutarProcedure(  "registrarPagoTC", 
                                                id_factura.Rows[0][0],
                                                Numero.Text,
                                                Banco.Text,
                                                Vencimiento.Text );

            
            MessageBox.Show("Su pago se ha realizado con exito");
            this.Close();
      


        }



    }
}
