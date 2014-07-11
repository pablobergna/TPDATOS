using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCommerce.Model;
using FrbaCommerce;

namespace FrbaCommerce
{
    public partial class Main : Form
    {
        private Usuario usuario;
        public Form parentForm;
        private DataAccessLayer dataAccess;

        public Main(Usuario user)
        {
            this.dataAccess = new DataAccessLayer();
            InitializeComponent();
            this.usuario = user;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void altaRolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        }
}
