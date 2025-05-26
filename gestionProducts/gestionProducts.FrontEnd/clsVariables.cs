using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using static gestionProducts.BackEnd.objGeneral;
using gestionProducts.BackEnd;
using System.Configuration;

namespace gestionProducts.FrontEnd
{
    public class clsVariables
    {
        private static string sSqlMysql= ConfigurationManager.ConnectionStrings["SQLMysql"].ConnectionString;
        private static objUsuario objU = new objUsuario();
        public static string SSqlMysql { get => sSqlMysql; set => sSqlMysql = value; }
        public static objUsuario ObjU { get => objU; set => objU = value; }
        private static clsGeneral objBD = new clsGeneral(sSqlMysql);
        public static clsGeneral ObjBD { get => objBD; }
    }
}