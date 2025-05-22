using gestionProducts.BackEnd;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestionProducts.FrontEnd.administracion
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            cmdNuevo_Click(null, null);
            cargargarLista();
        }

        private void cargargarLista()
        {
            string sSQL = $"select codigo,nombre nombres from producto";
            DataSet dt = (new clsGeneral(clsVariables.SSqlMysql)).cargarSQL(sSQL, out string sError);
            lstProductos.DisplayMember = "nombres";
            lstProductos.ValueMember = "codigo";
            lstProductos.DataSource = dt.Tables[0];
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            lblNuevo.Text = "NEW";
            txtNombre.Text = "";
            txtCaracteristicas.Text = "";
            lblUsuarioCreo.Text = clsVariables.ObjU.SNombreApellido;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string sSql = "";
            if (lblNuevo.Text.Equals("NEW"))
            {
                sSql = $"INSERT INTO producto (nombre, caracteristicas, usuariocreo) " +
                       $"VALUES ('{txtNombre.Text}', '{txtCaracteristicas.Text}', '{clsVariables.ObjU.SIdUsuario}')";
            }
            else
            {
                sSql = $"UPDATE producto SET nombre = '{txtNombre.Text}', caracteristicas = '{txtCaracteristicas.Text}' " +
                       $"WHERE codigo = {lblNuevo.Text}";
            }
            if ((new clsGeneral(clsVariables.SSqlMysql)).grabarSQL(sSql, out string sError))
            {
                cargargarLista();
                MessageBox.Show("Producto grabado correctamente", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmdNuevo_Click(null, null);
            }
            else
            {
                MessageBox.Show("Error al grabar el producto: " + sError, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstProductos_Click(object sender, EventArgs e)
        {
            string sSQL = $"select * from producto where codigo='{lstProductos.SelectedValue.ToString()}'";
            DataTable dt = (new clsGeneral(clsVariables.SSqlMysql)).cargarSQL(sSQL, out string sError).Tables[0];
            lblNuevo.Text = dt.Rows[0]["codigo"].ToString();
            txtNombre.Text = dt.Rows[0]["nombre"].ToString();
            txtCaracteristicas.Text = dt.Rows[0]["caracteristicas"].ToString();
            lblUsuarioCreo.Text = dt.Rows[0]["usuariocreo"].ToString();
        }
    }
}