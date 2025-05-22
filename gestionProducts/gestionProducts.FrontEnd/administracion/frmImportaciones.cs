using gestionProducts.BackEnd;
using System;
using System.Data;
using System.Windows.Forms;

namespace gestionProducts.FrontEnd.administracion
{
    public partial class frmImportaciones : Form
    {
        private string sError = "";

        public frmImportaciones()
        {
            InitializeComponent();
            cmdNuevo_Click(null, null);
            cargarDatosLista();
        }

        private void cargarDatosLista()
        {
            string sSQL = $"select codigo,nombre nombres from importacion";
            DataSet dt = (new clsGeneral(clsVariables.SSqlMysql)).cargarSQL(sSQL, out sError);
            lstImportaciones.DisplayMember = "nombres";
            lstImportaciones.ValueMember = "codigo";
            lstImportaciones.DataSource = dt.Tables[0];
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            lblNew.Text = "NEW";
            txtNombre.Text = "";
            txtLote.Value = 0;
            txtFecha.Value = DateTime.Now;
            lblUsuarioCreado.Text = clsVariables.ObjU.SNombreApellido;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            String sSql = "";
            if (lblNew.Text.Equals("NEW"))
            {
                sSql = $"INSERT INTO importacion (nombre, lote, fecha, usuariocreado) " +
                                $"VALUES ('{txtNombre.Text}',{txtLote.Value}, '{txtFecha.Value.ToString("yyyy-MM-dd")}', '{clsVariables.ObjU.SIdUsuario}')";
            }
            else
            {
                sSql = $"UPDATE importacion SET nombre = '{txtNombre.Text}', lote = {txtLote.Value}, fecha = '{txtFecha.Value.ToString("yyyy-MM-dd")}' " +
                                $"WHERE codigo = {lblNew.Text}";
            }
            if ((new clsGeneral(clsVariables.SSqlMysql)).grabarSQL(sSql, out sError))
            {
                cargarDatosLista();
                MessageBox.Show("Importacion grabada correctamente", "Importaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmdNuevo_Click(null, null);
            }
            else
            {
                MessageBox.Show("Error al grabar la importacion: " + sError, "Importaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstImportaciones_Click(object sender, EventArgs e)
        {
            string sSQL = $"select * from importacion where codigo='{lstImportaciones.SelectedValue.ToString()}'";
            DataTable dt = (new clsGeneral(clsVariables.SSqlMysql)).cargarSQL(sSQL, out sError).Tables[0];
            lblNew.Text = dt.Rows[0]["codigo"].ToString();
            txtNombre.Text = dt.Rows[0]["nombre"].ToString();
            txtLote.Value = Convert.ToInt32(dt.Rows[0]["lote"].ToString());
            txtFecha.Value = Convert.ToDateTime(dt.Rows[0]["fecha"].ToString());
            lblUsuarioCreado.Text = dt.Rows[0]["usuariocreado"].ToString();
        }
    }
}