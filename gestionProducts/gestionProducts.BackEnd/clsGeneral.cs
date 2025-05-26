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
        public DataSet cargarSQL(string sSQL, Dictionary<string, object> parametros, out string sError)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(sSQL, cn);
                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        comando.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                }
                cn.Open();
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(comando);
                da.Fill(ds);
                cn.Close();
                sError = "";
                return ds;
            }
            catch (Exception ex)
            {
                sError = ex.Message;
                cn.Close();
                return null;
            }
        }
        public bool Ejecutar(string sql, Dictionary<string, object> parametros)
        {
            try
            {
                using (var cmd = new MySqlCommand(sql, cn))
                {
                    if (parametros != null)
                    {
                        foreach (var param in parametros)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }
                    cn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    cn.Close();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error si lo deseas
                return false;
            }
        }

    }
}