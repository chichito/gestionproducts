using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace gestionProducts.FrontEnd.movimiento
{
    public partial class frmIngresosProductos : Form
    {
        private DataTable dtDetalle = null;

        public frmIngresosProductos()
        {
            InitializeComponent();
            cargarDatos();
            cmdNuevo_Click(null, null);
        }

        private void cargarDatos()
        {
            string sError = "";
            string sSQL = "SELECT codigo,CONCAT(nombre,' [',lote,'] ->[',DATE_FORMAT(fecha, '%d/%m/%Y'),']') nombre FROM importacion order by fecha desc";
            DataSet ds = clsVariables.ObjBD.cargarSQL(sSQL, null, out sError);
            if (sError != "")
            {
                MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lstImportaciones.DataSource = ds.Tables[0];
            lstImportaciones.DisplayMember = "nombre";
            lstImportaciones.ValueMember = "codigo";
            lstImportaciones_Click(null, null);
        }

        private void cmdProd_Click(object sender, EventArgs e)
        {
            if (txtIDProd.Text == "")
            {
                userGrilla.NombreTabla = "producto";
                userGrilla.NombreCampo = "nombre";
                userGrilla.ValorCampo = "codigo";
                userGrilla.ValorBuscar = "nombre";
                userGrilla.FormName = "gestionProducts.FrontEnd.administracion.frmProductos";
                userGrilla.Visible = true;
                return;
            }
            else
            {
                string sql = $"SELECT * FROM producto WHERE codigo={txtIDProd.Text.Trim()}";
                DataTable dataTable = DataTable(sql);
                if (dataTable.Rows.Count > 0)
                    lblProducto.Text = dataTable.Rows[0]["nombre"].ToString();
                else
                {
                    txtIDProd.Text = "";
                    lblProducto.Text = "";
                }
            }
        }

        private void cmdModelo_Click(object sender, EventArgs e)
        {
            if (txtIDMod.Text == "")
            {
                userGrilla.NombreTabla = "modelo";
                userGrilla.NombreCampo = "nombre";
                userGrilla.ValorCampo = "codigo";
                userGrilla.ValorBuscar = "nombre";
                userGrilla.FormName = "gestionProducts.FrontEnd.administracion.frmModelo";
                userGrilla.Visible = true;
                return;
            }
            else
            {
                string sql = $"SELECT * FROM modelo WHERE codigo={txtIDMod.Text.Trim()}";
                DataTable dataTable = DataTable(sql);
                if (dataTable.Rows.Count > 0)
                    lblModelo.Text = dataTable.Rows[0]["nombre"].ToString();
                else
                {
                    txtIDMod.Text = "";
                    lblModelo.Text = "";
                }
            }
        }

        private void userGrilla_VisibleChanged(object sender, EventArgs e)
        {
            if (!userGrilla.Visible)
            {
                switch (userGrilla.NombreTabla)
                {
                    case "producto":
                        txtIDProd.Text = userGrilla.ValorSeleccionado;
                        string sql = $"SELECT * FROM producto WHERE codigo={userGrilla.ValorSeleccionado}";
                        DataTable dataTable = DataTable(sql);
                        if (dataTable.Rows.Count > 0)
                            lblProducto.Text = dataTable.Rows[0]["nombre"].ToString();
                        else
                        {
                            txtIDProd.Text = "";
                            lblProducto.Text = "";
                        }
                        break;

                    case "modelo":
                        txtIDMod.Text = userGrilla.ValorSeleccionado;
                        string sqlModelo = $"SELECT * FROM modelo WHERE codigo={userGrilla.ValorSeleccionado}";
                        DataTable dataTableModelo = DataTable(sqlModelo);
                        if (dataTableModelo.Rows.Count > 0)
                            lblModelo.Text = dataTableModelo.Rows[0]["nombre"].ToString();
                        else
                        {
                            txtIDMod.Text = "";
                            lblModelo.Text = "";
                        }
                        break;
                        // Add more cases for different forms if needed
                }
            }
            else
            {
                userGrilla.LimpiarGrilla();
            }
        }

        private DataTable DataTable(string sSQL)
        {
            string sError = "";
            DataSet ds = clsVariables.ObjBD.cargarSQL(sSQL, null, out sError);
            if (sError != "")
            {
                MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return ds.Tables[0];
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtIDMod.Text = "";
            lblProducto.Text = "";
            txtIDMod.Text = "";
            lblModelo.Text = "";
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            DataRow row = dtDetalle.NewRow();
            row["codigo"] = dtDetalle.Rows.Count + 1; // Assuming auto-increment
            row["idproducto"] = txtIDProd.Text.Trim();
            row["Producto"] = lblProducto.Text.Trim();
            row["idmodelo"] = txtIDMod.Text.Trim();
            row["Modelo"] = lblModelo.Text.Trim();
            row["observacion"] = txtObservacionDetalle.Text.Trim();
            row["disponible"] = true; // Default value, can be changed later
            row["estado"] = "N";
            dtDetalle.Rows.Add(row);
            grDetalle.DataSource = dtDetalle;
        }

        private void lstImportaciones_Click(object sender, EventArgs e)
        {
            string sError = "";
            lblImportacion.Text = lstImportaciones.SelectedValue.ToString();
            lblImpoNombre.Text = lstImportaciones.GetItemText(lstImportaciones.SelectedItem);
            string sSQL = $"SELECT * FROM ingresosproductoscabecera WHERE codigo={lstImportaciones.SelectedValue}";
            DataSet ds = clsVariables.ObjBD.cargarSQL(sSQL, null, out sError);
            if (sError != "")
            {
                MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                lblNew.Text = ds.Tables[0].Rows[0]["codigo"].ToString();
                lblFecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
                lblUsuario.Text = ds.Tables[0].Rows[0]["usuariocreo"].ToString();
                txtObservacionCabecera.Text = ds.Tables[0].Rows[0]["observacion"].ToString();
                sSQL = $"SELECT * FROM ingresosproductosdetalle WHERE codigocabecera={lblNew.Text}";
                ds = clsVariables.ObjBD.cargarSQL(sSQL, null, out sError);
                if (sError != "")
                {
                    MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    dtDetalle = CrearDetalleProductos(ds.Tables[0]);
                }
            }
            else
            {
                lblNew.Text = "NEW";
                lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblUsuario.Text = clsVariables.ObjU.SNombreApellido;
                txtObservacionCabecera.Text = "";
                dtDetalle = CrearDetalleProductos(null);
            }
        }

        private DataTable CrearDetalleProductos(DataTable dtT)
        {
            DataTable dt = new DataTable();
            dt.TableName = "detalleproductos";
            dt.Columns.Add("codigo", typeof(int));
            dt.Columns.Add("idproducto", typeof(int));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("idmodelo", typeof(int));
            dt.Columns.Add("Modelo", typeof(string));
            dt.Columns.Add("observacion", typeof(string));
            dt.Columns.Add("disponible", typeof(bool));
            dt.Columns.Add("estado", typeof(String));
            if (dtT != null)
            {
            }
            return dt;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string sSqlCa = $"INSERT INTO ingresosproductoscabecera (idimportacion, idusuario, observacion) " +
                            $"VALUES ({lblImportacion.Text},{clsVariables.ObjU.SIdUsuario},'{txtObservacionCabecera.Text}')";
        }
    }
}