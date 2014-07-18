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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql_qry = "select P.codigo CODIGO, P.descripcion DESCRIPCION, U.nombre_usuario USUARIO,"+
		                    " P.descripcion_tipo TIPO, P.fecha_venc FECHA_VENCIMIENTO"+
                            " from LOS_GESTORES.Publicacion P"+
                            " join LOS_GESTORES.Usuario U on U.id_usuario = P.id_usuario WHERE"+
                            " P.id_estado = (select E.id_estado from LOS_GESTORES.Estado E where E.descripcion = 'Finalizada')";

            // HACER LEFT JOIN CON PUBLICACION INMEDIATA PARA VERIFICAR STOCK


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

            // Aca tengo que definir el ORDER BY POR PESO


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

        
    }
}
