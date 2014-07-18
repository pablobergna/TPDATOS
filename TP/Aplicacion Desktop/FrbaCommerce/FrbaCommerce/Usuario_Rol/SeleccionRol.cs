using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FrbaCommerce.Usuario_Rol
{
    public partial class SeleccionRol : Form
    {
        private ArrayList rolesSel = new ArrayList();

        public SeleccionRol()
        {
            InitializeComponent();
        }

        public ArrayList getRolesSeleccionados()
        {
            return rolesSel;
        }

        private void SeleccionRol_Load(object sender, EventArgs e)
        {
            // Abro la conexion
            AccesoDatos.getInstancia().abrirConexion();
            DataSet roles = AccesoDatos.getInstancia().consultaSimple("select id_rol id_r, nombre nom from LOS_GESTORES.Rol"+
                    " where id_estado = (select E.id_estado from LOS_GESTORES.Estado E where E.descripcion = 'Habilitado')");

            this.lstRol.DataSource = roles.Tables[0];
            this.lstRol.DisplayMember = "nom";
            this.lstRol.ValueMember = "id_r";
            
            AccesoDatos.getInstancia().cerrarConexion();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            if (lstRol.SelectedItems.Count < 1)
            {
                MessageBox.Show("Debe seleccionar al menos un rol");
                return;
            }

            foreach (object item in lstRol.SelectedItems)
            {
                rolesSel.Add(((DataRowView)item)["id_r"].ToString());
            }

            this.Close();

        }
    }
}
