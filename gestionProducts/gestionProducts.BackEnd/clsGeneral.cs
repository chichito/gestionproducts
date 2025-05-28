using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace gestionProducts.BackEnd
{
    public class clsGeneral : clsConectar
    {
        public clsGeneral(string sCadena) : base(sCadena)
        {
        }

        public DataSet cargarSQL(string sSQL, out string sError)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sSQL;
            return DevolverDataSet(comando, out sError);
        }

        public Boolean grabarSQL(string sSQL, out string sError)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sSQL;
            return GrabarActualizarEliminar(comando, out sError);
        }

        public int ObtenerUltimoCodigo(string nombreTabla, string nombreColumna, out string sError)
        {
            string sSQL = $"SELECT MAX({nombreColumna}) FROM {nombreTabla}";
            DataSet ds = cargarSQL(sSQL, null, out sError);
            if (!string.IsNullOrEmpty(sError))
                return -1;

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
                return Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            else
                return 0;
        }

        public DataSet cargarSQL(string sSQL, Dictionary<string, object> parametros, out string sError)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(sSQL, cn);
                if (parametros != null)
                    foreach (var param in parametros)
                        comando.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                return DevolverDataSet(comando, out sError);
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                return null;
            }
        }

        public bool Ejecutar(string sql, Dictionary<string, object> parametros, out string sError)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, cn);
                if (parametros != null)
                    foreach (var param in parametros)
                        comando.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                return GrabarActualizarEliminar(comando, out sError);
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error si lo deseas
                sError = ex.Message;
                return false;
            }
        }
    }
}