using System;

namespace gestionProducts.BackEnd
{
    public class objGeneral
    {
        public class objUsuario
        {
            private string sIdUsuario, sNombreApellido;
            private Boolean bAdministrador;

            public string SIdUsuario { get => sIdUsuario; set => sIdUsuario = value; }
            public string SNombreApellido { get => sNombreApellido; set => sNombreApellido = value; }
            public bool BAdministrador { get => bAdministrador; set => bAdministrador = value; }
        }
    }
}