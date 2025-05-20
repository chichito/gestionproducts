using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;

namespace gestionProducts.BackEnd
{
    public class clsConectar
    {
        protected MySqlConnection cn;

        public clsConectar(string sCadena)
        {
            cn = new MySqlConnection(sCadena);
        }

        public DataSet DevolverDataSet(MySqlCommand command, out string sError)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataSet ds = null;

            try
            {
                cn.Open();
                ds = new DataSet();
                da.Fill(ds);
                sError = "";
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message);
                sError = ex.Message;
            }
            finally
            {
                da.Dispose();
                cn.Close();
                cn.Dispose();
            }

            return ds;
        }

        public Boolean GrabarActualizarEliminar(MySqlCommand comando, out string sError)
        {
            Boolean ban;
            try
            {
                cn.Open();
                comando.ExecuteNonQuery();
                ban = true;
                sError = "";
            }
            catch (Exception ex)
            {
                Trace.Write(ex.Message);
                ban = false;
                sError = ex.Message;
            }
            finally
            {
                comando.Dispose();
                cn.Close();
            }
            return ban;
        }
    }
}