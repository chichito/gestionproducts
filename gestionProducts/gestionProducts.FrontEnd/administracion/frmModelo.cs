using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionProducts.FrontEnd.administracion
{
    public partial class frmModelo : Form
    {
        public frmModelo()
        {
            InitializeComponent();
            cargarModelo();
        }

        void cargarModelo()
        {
            string sSql = "SELECT codigo, nombre FROM modelo";
            string sError = "";
            DataSet ds = clsVariables.ObjBD.cargarSQL(sSql, null, out sError);
            lstModelo.DisplayMember = "nombre";
            lstModelo.ValueMember = "codigo";
            lstModelo.DataSource = ds.Tables[0];
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            lblNew.Text = "NEW";
            txtNombre.Text = "";
            txtCaracteristicas.Text = "";
            lblUsuarioCreado.Text = clsVariables.ObjU.SIdUsuario;
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            string sSql = "";
            Dictionary<string, object> parametros = null; // Explicitly define the type to fix CS0815
            if (lblNew.Text.Equals("NEW"))
            {
                // Para insertar
                sSql = "INSERT INTO modelo (nombre, descripcion, usuariocreo) VALUES (@nombre, @descripcion, @usuario)";
                parametros = new Dictionary<string, object>
                    {
                        { "@nombre", txtNombre.Text },
                        { "@descripcion", txtCaracteristicas.Text },
                        { "@usuario", clsVariables.ObjU.SIdUsuario}
                    };
            }
            else
            {
                // Para actualizar
                sSql = "UPDATE modelo SET nombre = @nombre, descripcion = @descripcion WHERE codigo = @id";
                parametros = new Dictionary<string, object>
                    {
                        { "@nombre", txtNombre.Text },
                        { "@descripcion", txtCaracteristicas.Text },
                        { "@id", lblNew.Text }
                    };
            }
            if (clsVariables.ObjBD.Ejecutar(sSql, parametros))
            {
                MessageBox.Show("Modelo guardado correctamente", "Modelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarModelo();
            }
            else
            {
                MessageBox.Show("Error al guardar el modelo", "Modelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstModelo_Click(object sender, EventArgs e)
        {
            string sSql = "SELECT nombre, descripcion FROM modelo WHERE codigo = @id";
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@id", lstModelo.SelectedValue }
            };
            string sError = "";
            DataSet ds = clsVariables.ObjBD.cargarSQL(sSql, parametros, out sError);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                    txtCaracteristicas.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                    lblNew.Text = lstModelo.SelectedValue.ToString();
                    lblUsuarioCreado.Text = clsVariables.ObjU.SIdUsuario;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar el modelo", "Modelo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
