using gestionProducts.FrontEnd.usuario;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace gestionProducts.FrontEnd
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            clsVariables.SSqlMysql = ConfigurationManager.ConnectionStrings["SQLMysql"].ConnectionString;

            #region loguin

            frmLogin frml = new frmLogin();
            if (frml.ShowDialog() == DialogResult.OK)
            {
                tblUsuario.Text = "Personal: " + clsVariables.ObjU.SNombreApellido;
                administracionToolStripMenuItem.Visible = clsVariables.ObjU.BAdministrador;
            }
            else
            {
                this.Close();
            }

            #endregion loguin
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}