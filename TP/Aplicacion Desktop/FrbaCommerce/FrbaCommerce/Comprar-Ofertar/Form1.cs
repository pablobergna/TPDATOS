using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Comprar_Ofertar
{
    public partial class Form1 : Form
    {
        private int id_usuario;
        private DateTime fecha_hoy;

        public int idUsu { get { return id_usuario; } set { id_usuario = value; } }

        public DateTime fechaHoy { get { return fecha_hoy; } set { fecha_hoy = value;} }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql_qry = "select P.id_publicacion, P.codigo CODIGO, P.descripcion DESCRIPCION," +
                            " P.descripcion_tipo TIPO, P.fecha_venc FECHA_VENCIMIENTO" +
                            " from LOS_GESTORES.Publicacion P" +
                            " join LOS_GESTORES.Visibilidad V on V.id_visibilidad = P.id_visibilidad " +
                            " left join LOS_GESTORES.Publicacion_Inmediata PI on PI.id_publicacion = P.id_publicacion and PI.stock > 0" +
                            " WHERE P.id_usuario <> "+ this.idUsu.ToString().Trim() +
                          //  " AND P.fecha_venc >= '" + new DateTime(2013, 01, 10).ToShortDateString() + "'";
                          " AND P.fecha_venc >= '"+ fecha_hoy.Date.ToShortDateString()+ "'";

            //FUNCIONALIDAD ADICIONAL PARA CONTEMPLAR ESTRATEGIA DE MIGRACION TOMADA
            if(this.checkBoxFin.Checked)
                sql_qry += " AND P.id_estado = (select E.id_estado from LOS_GESTORES.Estado E where E.descripcion = 'Activa')";
                            
            //Armo el string de acuerdo a los parametros de busqueda
            if (txtDesc.Text.Trim() != string.Empty)
            {
                sql_qry = sql_qry + " AND P.descripcion like '%" + txtDesc.Text.Trim() + "%'";
            }

            // Armo el query con los rubros
            if (this.lstRubros.SelectedIndices.Count > 0)
            {
                int primero = 1;

                sql_qry = sql_qry + " AND (select PRU.id_rubro from LOS_GESTORES.Publicacion_Rubro PRU"+
                    " where PRU.id_publicacion = P.id_publicacion) IN (";

                foreach (object item in lstRubros.SelectedItems)
                {
                    if (primero == 1)
                    {
                        sql_qry = sql_qry + ((DataRowView)item)["id_r"].ToString();
                        primero = 0;
                    }
                    else
                    {
                        sql_qry = sql_qry + ", " + ((DataRowView)item)["id_r"].ToString();
                    }
                }

                sql_qry += ")";

            }

            // Defino el order by por el precio de la visibilidad
            sql_qry = sql_qry + " ORDER BY V.precio desc";

            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();

            DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

            dataGridPublicaciones.AutoGenerateColumns = true;
            dataGridPublicaciones.DataSource = datos.Tables[0];

            dataGridPublicaciones.Columns[0].Visible = false;

            // Cierro la conexion
            AccesoDatos.getInstancia().cerrarConexion();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();
            DataSet roles = AccesoDatos.getInstancia().consultaSimple("select id_rubro id_r, descripcion nom from LOS_GESTORES.Rubro");

            this.lstRubros.DataSource = roles.Tables[0];
            this.lstRubros.DisplayMember = "nom";
            this.lstRubros.ValueMember = "id_r";

            AccesoDatos.getInstancia().cerrarConexion();

            this.lstRubros.ClearSelected();

        }

        private void linkLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lstRubros.ClearSelected();
            this.txtDesc.Clear();
        }

        private void btnVerPublicacion_Click(object sender, EventArgs e)
        {
            if (dataGridPublicaciones.SelectedRows.Count != 1) return;

            int id_pub = Convert.ToInt32(this.dataGridPublicaciones.SelectedRows[0].Cells[0].Value);

            Comprar_Ofertar.VisualizarPub fVis = new VisualizarPub();
            fVis.idPublicacion = id_pub;

            //test
            //fVis.fechaHoy = Convert.ToDateTime("2014-02-02");
            //fVis.idComprador = 2;

            fVis.fechaHoy = this.fechaHoy;
            fVis.idComprador = this.id_usuario;
            
            
            fVis.ShowDialog();
        }

        
    }
}
