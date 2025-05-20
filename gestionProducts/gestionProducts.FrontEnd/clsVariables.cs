using static gestionProducts.BackEnd.objGeneral;

namespace gestionProducts.FrontEnd
{
    public class clsVariables
    {
        private static string sSqlMysql;

        private static objUsuario objU = new objUsuario();
        public static string SSqlMysql { get => sSqlMysql; set => sSqlMysql = value; }
        public static objUsuario ObjU { get => objU; set => objU = value; }
    }
}