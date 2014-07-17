using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FrbaCommerce.Pass
{
    public partial class ModPass : Form
    {
        private int id_usuario = -1;

        public int idusuario { get { return id_usuario; } set { id_usuario = value; } }

        public ModPass()
        {
            InitializeComponent();
        }

        private void ModPass_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string pass_encriptado="";
            SHA256Managed encriptacionSha256 = new SHA256Managed();

            if (this.txtPass.Text.Trim() == string.Empty || this.txtConf.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe completar ambos campos para continuar");
                return;
            }

            if (!this.txtPass.Text.Equals(this.txtConf.Text.Trim()))
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden");
                return;
            }

            if (MessageBox.Show("¿Confirma la Modificacion de la contraseña del usuario?", "Contraseña", MessageBoxButtons.YesNo)
                   == DialogResult.Yes)
            {
                pass_encriptado = Convert.ToBase64String(encriptacionSha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(txtPass.Text.Trim())));

                string sql_qry = "UPDATE LOS_GESTORES.Usuario SET password = '" + pass_encriptado +
                    "' WHERE id_usuario = " + this.id_usuario.ToString();

                // Abro la conexion
                AccesoDatos.getInstancia().abrirConexion();

                DataSet datos = AccesoDatos.getInstancia().consultaSimple(sql_qry);

                // Cierro la conexion
                AccesoDatos.getInstancia().cerrarConexion();

                MessageBox.Show("Contraseña modificada con exito");
            }

            this.Close();
        }
    }
}
