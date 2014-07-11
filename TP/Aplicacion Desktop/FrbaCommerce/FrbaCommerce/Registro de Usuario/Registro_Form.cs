using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace FrbaCommerce.Registro_de_Usuario
{
    public partial class Registro_Form : Form
    {
        public Registro_Form()
        {
            InitializeComponent();
        }

        private void Registro_Form_Load(object sender, EventArgs e)
        {
            string sql_qry = "select rol.id_rol, rol.nombre from LOS_GESTORES.rol";
            DataSet datos = new AccesoDatos("Data Source=localhost\\SQLSERVER2008;User ID=gd;Password=gd2014", sql_qry).consultaSimple();

            DataTable tabla = datos.Tables[0];

            // Creo la lista a cargar con los valores de la consulta
            ArrayList listado = new ArrayList();
            
            foreach (DataRow reg in tabla.Rows)
            {
                listado.Add(new DTO.RolDTO(int.Parse(reg[0].ToString()),reg[1].ToString()));
            }
            
            // Asigno los valores al combobox
            reg_comboRoles.DataSource = listado;
            reg_comboRoles.DisplayMember = "descRol";
            reg_comboRoles.ValueMember = "idRol";
                   
        }

        private void btn_reg_siguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(reg_comboRoles.SelectedValue.ToString());
        }

    }
}
