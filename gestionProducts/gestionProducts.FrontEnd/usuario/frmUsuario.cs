using gestionProducts.BackEnd;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace gestionProducts.FrontEnd.usuario
{
    public partial class frmUsuario : Form
    {
        private string sError;

        public frmUsuario()
        {
            InitializeComponent();
            cargarDatosLista();
        }

        private void cargarDatosLista()
        {
            string sSQL = $"select cedula,CONCAT(nombre,' ',apellido,' [',CASE WHEN habilitado = 1 THEN 'Habilitado' ELSE 'InHabilitado' END,']') nombres from user";
            DataSet dt = (new clsGeneral(clsVariables.SSqlMysql)).cargarSQL(sSQL, out sError);
            lstUsuarios.DisplayMember = "nombres";
            lstUsuarios.ValueMember = "cedula";
            lstUsuarios.DataSource = dt.Tables[0];
            cmdNuevo_Click(null, null);
        }

        private void cmdNuevo_Click(object sender, System.EventArgs e)
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            chkAdministrador.Checked = true;
            chkHabilitado.Checked = true;
            lblNew.Text = "NEW";
        }

        private void lstUsuarios_Click(object sender, System.EventArgs e)
        {
            string sSQL = $"select * from user where cedula='{lstUsuarios.SelectedValue.ToString()}'";
            DataTable dt = (new clsGeneral(clsVariables.SSqlMysql)).cargarSQL(sSQL, out sError).Tables[0];
            txtCedula.Text = dt.Rows[0]["cedula"].ToString();
            txtNombre.Text = dt.Rows[0]["nombre"].ToString();
            txtApellido.Text = dt.Rows[0]["apellido"].ToString();
            txtCelular.Text = dt.Rows[0]["celular"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtUserName.Text = dt.Rows[0]["username"].ToString();
            txtPassword.Text = dt.Rows[0]["password"].ToString();
            chkAdministrador.Checked = dt.Rows[0]["administrador"].ToString().Equals("1") ? true : false;
            chkHabilitado.Checked = dt.Rows[0]["habilitado"].ToString().Equals("1") ? true : false;
            lblNew.Text = "ACT";
        }

        private void cmdGrabar_Click(object sender, System.EventArgs e)
        {
            int iA = chkAdministrador.Checked ? 1 : 0;
            int iH = chkHabilitado.Checked ? 1 : 0;
            string sQl = "";
            if (lblNew.Text.Equals("NEW"))
                sQl = $"insert into user values('{txtCedula.Text}','{txtNombre.Text}','{txtApellido.Text}','{txtCelular.Text}'," +
                                $"'{txtEmail.Text}','{txtUserName.Text}','{txtPassword.Text}',{iA},{iH})";
            else
                sQl = $"update user set nombre='{txtNombre.Text}',apellido='{txtApellido.Text}',celular='{txtCelular.Text}'," +
                        $"email='{txtEmail.Text}',username='{txtUserName.Text}',password='{txtPassword.Text}'," +
                        $"administrador={iA},habilitado={iH} where cedula='{txtCedula.Text}'";
            if ((new clsGeneral(clsVariables.SSqlMysql)).grabarSQL(sQl, out sError))
            {
                cargarDatosLista();
                MessageBox.Show("Transaccion Exitosa");
            }
            else
                MessageBox.Show(sError);
        }
    }
}