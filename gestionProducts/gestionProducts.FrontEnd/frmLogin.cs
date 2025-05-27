using gestionProducts.BackEnd;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestionProducts.FrontEnd
{
    public partial class frmLogin : Form
    {
        private string sError;
        private int iInte = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            string sSQL = $"select * from user u where username='{txtUser.Text}' and password='{txtPassword.Text}' and habilitado=1";
            DataSet dt = clsVariables.ObjBD.cargarSQL(sSQL, null, out sError);
            if (sError.Trim().Length > 0)
            {
                MessageBox.Show("Error de Autentificacion del SQL Server");
                return;
            }
            if (dt.Tables[0].Rows.Count > 0)
            {
                clsVariables.ObjU.SIdUsuario = dt.Tables[0].Rows[0]["cedula"].ToString();
                clsVariables.ObjU.SNombreApellido = dt.Tables[0].Rows[0]["nombre"].ToString() + " " + dt.Tables[0].Rows[0]["apellido"].ToString();
                clsVariables.ObjU.BAdministrador = dt.Tables[0].Rows[0]["administrador"].ToString().Equals("1") ? true : false;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                iInte++;
                if (iInte > 3)
                {
                    MessageBox.Show("Supero los Limites");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El Usuario y Contraseña Incorrectas");
                }
            }
        }
    }
}