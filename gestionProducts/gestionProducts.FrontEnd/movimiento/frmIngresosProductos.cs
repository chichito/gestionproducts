using System;
using System.Data;
using System.Linq;
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
                userGrilla.BringToFront();
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
            lblIDDet.Text = "NEW";
            txtIDProd.Text = "";
            lblProducto.Text = "";
            txtIDMod.Text = "";
            lblModelo.Text = "";
            txtSerial.Text = "";
            txtObservacionDetalle.Text = "";
            pnlA.Enabled = true;
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtIDProd.Text.Trim() == "" && lblProducto.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtIDMod.Text.Trim() == "" && lblModelo.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar un modelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblIDDet.Text == "NEW")
            {
                if (dtDetalle.AsEnumerable().Any(r => r.Field<int>("idproducto") == int.Parse(txtIDProd.Text) && r.Field<int>("idmodelo") == int.Parse(txtIDMod.Text)))
                {
                    MessageBox.Show("This product and model combination already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataRow row = dtDetalle.NewRow();
                row["codigo"] = dtDetalle.Rows.Count + 1; // Assuming auto-increment
                row["idproducto"] = txtIDProd.Text.Trim();
                row["Producto"] = lblProducto.Text.Trim();
                row["idmodelo"] = txtIDMod.Text.Trim();
                row["Modelo"] = lblModelo.Text.Trim();
                row["Serial"] = txtSerial.Text.Trim();
                row["observacion"] = txtObservacionDetalle.Text.Trim();
                row["disponible"] = true; // Default value, can be changed later
                row["estado"] = "N";
                dtDetalle.Rows.Add(row);
                grDetalle.DataSource = dtDetalle;
            }
            else
            {
                // Update existing row
                DataRow row = dtDetalle.Rows.Find(new object[] { int.Parse(txtIDProd.Text), int.Parse(txtIDMod.Text) });
                if (row != null)
                {
                    row["serial"] = txtSerial.Text.Trim();
                    row["observacion"] = txtObservacionDetalle.Text.Trim();
                    row["disponible"] = true; // Default value, can be changed later
                    row["estado"] = "A"; // New state
                }
            }
        }

        private void lstImportaciones_Click(object sender, EventArgs e)
        {
            string sError = "";
            lblImportacion.Text = lstImportaciones.SelectedValue.ToString();
            lblImpoNombre.Text = lstImportaciones.GetItemText(lstImportaciones.SelectedItem);
            string sSQL = $"SELECT * FROM ingresosproductoscabecera WHERE idimportacion={lstImportaciones.SelectedValue}";
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
                lblUsuario.Text = ds.Tables[0].Rows[0]["idusuario"].ToString();
                txtObservacionCabecera.Text = ds.Tables[0].Rows[0]["observacion"].ToString();
                sSQL = $"SELECT dt.codigo,idproducto,p.nombre producto,idmodelo,m.nombre modelo,dt.serial,dt.observacion,dt.disponible,'R' estado " +
                    $" FROM ingresosproductosdetalle dt" +
                    $" inner join producto p on dt.idproducto=p.codigo" +
                    $" inner join modelo m on dt.idmodelo=m.codigo" +
                    $" WHERE codigocabecera={lblNew.Text}";
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
            grDetalle.DataSource = dtDetalle;

            grDetalle_CellDoubleClick(grDetalle, new DataGridViewCellEventArgs(0, 0));
            if (grDetalle.Rows.Count == 0)
            {
                cmdNuevo_Click(null, null);
                pnlGrdProd.Enabled = true;
                pnlD.BackColor = System.Drawing.Color.LightGreen;
                lblMensaje.Text = "Este producto está disponible.";
                cmdGrabar.Visible = true;
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
            dt.Columns.Add("Serial", typeof(string));
            dt.Columns.Add("observacion", typeof(string));
            dt.Columns.Add("disponible", typeof(bool));
            dt.Columns.Add("estado", typeof(string));
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idproducto"], dt.Columns["idmodelo"] };
            if (dtT != null)
                foreach (DataRow row in dtT.Rows)
                    dt.Rows.Add(row.ItemArray);
            return dt;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string sError = "";
            string sSQL = "";
            if (dtDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblNew.Text == "NEW")
                sSQL = $"INSERT INTO ingresosproductoscabecera (idimportacion, idusuario, observacion) " +
                                $"VALUES ({lblImportacion.Text},{clsVariables.ObjU.SIdUsuario},'{txtObservacionCabecera.Text}')";
            else
                sSQL = $"UPDATE ingresosproductoscabecera SET idimportacion={lblImportacion.Text}, " +
                       $"idusuario={clsVariables.ObjU.SIdUsuario}, observacion='{txtObservacionCabecera.Text}' " +
                       $"WHERE codigo={lblNew.Text}";
            if (clsVariables.ObjBD.Ejecutar(sSQL, null, out sError))
            {
                if (lblNew.Text == "NEW")
                {
                    lblNew.Text = clsVariables.ObjBD.ObtenerUltimoCodigo("ingresosproductoscabecera", "codigodd", out sError).ToString();
                    if (sError != "")
                    {
                        MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                foreach (DataRow row in dtDetalle.Rows)
                {
                    if (row["estado"] == null || row["estado"].ToString() == "N")
                        sSQL = $"INSERT INTO ingresosproductosdetalle (codigocabecera, idproducto, idmodelo, serial, observacion, disponible) " +
                               $"VALUES ({lblNew.Text}, {row["idproducto"]}, {row["idmodelo"]}, '{row["serial"]}', '{row["observacion"]}', {Convert.ToInt32(row["disponible"])})";
                    if (row["estado"] == null || row["estado"].ToString() == "A")
                        sSQL = " UPDATE ingresosproductosdetalle " +
                               $"SET serial = '{row["serial"]}', observacion = '{row["observacion"]}' " +
                               $"WHERE codigocabecera = {lblNew.Text} AND idproducto = {row["idproducto"]} AND idmodelo = {row["idmodelo"]}";
                    if (!clsVariables.ObjBD.grabarSQL(sSQL, out sError))
                    {
                        MessageBox.Show(sError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Datos grabados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo obtener el código de la cabecera.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grDetalle.Rows.Count)
            {
                DataGridViewRow row = grDetalle.Rows[e.RowIndex];
                lblIDDet.Text = row.Cells["codigo"].Value.ToString();
                txtIDProd.Text = row.Cells["idproducto"].Value.ToString();
                lblProducto.Text = row.Cells["Producto"].Value.ToString();
                txtIDMod.Text = row.Cells["idmodelo"].Value.ToString();
                lblModelo.Text = row.Cells["Modelo"].Value.ToString();
                txtSerial.Text = row.Cells["Serial"].Value.ToString();
                txtObservacionDetalle.Text = row.Cells["observacion"].Value.ToString();
                pnlA.Enabled = false;
                if (Convert.ToBoolean(row.Cells["disponible"].Value.ToString()) == false)
                {
                    pnlGrdProd.Enabled = false;
                    pnlD.BackColor = System.Drawing.Color.LightCoral;
                    lblMensaje.Text = "Este producto no está disponible.";
                    cmdGrabar.Visible = false;
                }
                else
                {
                    pnlGrdProd.Enabled = true;
                    pnlD.BackColor = System.Drawing.Color.LightGreen;
                    lblMensaje.Text = "Este producto está disponible.";
                    cmdGrabar.Visible = true;
                }
            }
        }

        private void grDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Convert.ToBoolean(this.grDetalle.Rows[e.RowIndex].Cells["disponible"].Value.ToString()))
            {
                this.grDetalle.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                this.grDetalle.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                this.grDetalle.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                this.grDetalle.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            }
        }
    }
}