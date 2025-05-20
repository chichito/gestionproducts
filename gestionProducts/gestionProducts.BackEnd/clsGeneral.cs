using MySql.Data.MySqlClient;
using System;
using System.Data;

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
    }
}