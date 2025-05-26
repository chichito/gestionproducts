using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionProducts.FrontEnd.usercontrol
{
    public partial class userControlGrilla : UserControl
    {
        string _nombreTabla;
        public string NombreTabla
        {
            get { return _nombreTabla; }
            set { _nombreTabla = value; }
        }
        string _nombreCampo;
        public string NombreCampo
        {
            get { return _nombreCampo; }
            set { _nombreCampo = value; }
        }
        string _valorCampo;
        public string ValorCampo
        {
            get { return _valorCampo; }
            set { _valorCampo = value; }
        }
        string _valorBuscar;
        public string ValorBuscar
        {
            get { return _valorBuscar; }
            set { _valorBuscar = value; }
        }
        string _valorSeleccionado;
        public string ValorSeleccionado
        {
            get { return _valorSeleccionado; }
            set { _valorSeleccionado = value; }
        }
        string _formName;
        public string FormName
        {
            get { return _formName; }
            set { _formName = value; }
        }
        public userControlGrilla()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string sError = "";
            string sSQL = $"SELECT {ValorCampo},{NombreCampo} FROM {_nombreTabla} where {ValorBuscar} like '%{txtBuscar.Text}%'";
            DataSet ds = clsVariables.ObjBD.cargarSQL(sSQL, null, out sError);
            if (sError != "")
            {
                MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            grdDatos.DataSource = ds.Tables[0];
        }

        DataGridViewTextBoxColumn AddCampo(string nombreCampo, Boolean bVisible)
        {
            DataGridViewTextBoxColumn campo = new DataGridViewTextBoxColumn();
            campo.Name = nombreCampo;
            campo.Visible = bVisible;
            campo.HeaderText = nombreCampo;
            campo.DataPropertyName = nombreCampo;
            return campo;
        }

        private void cmdCall_Click(object sender, EventArgs e)
        {
            OpenForm(FormName);
        }

        private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ValorSeleccionado = grdDatos.Rows[e.RowIndex].Cells[ValorCampo].Value.ToString();
            this.Visible = false;
        }

        static void OpenForm(string formName)
        {
            Form form = (Form)Activator.CreateInstance(Type.GetType(formName));
            form.ShowDialog();
        }
        public void LimpiarGrilla() {
            grdDatos.DataSource = null;
            grdDatos.Rows.Clear();
            grdDatos.Columns.Add(AddCampo(ValorCampo, false));
            grdDatos.Columns.Add(AddCampo(NombreCampo, true));
            grdDatos.Columns[1].Width = grdDatos.Width-70;
        }
    }
}
