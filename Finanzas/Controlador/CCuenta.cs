using Finazas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Controlador
{
    public class CCuenta
    {

        public static DataTable Catalogo_Cuentas (string tipo)
        {
            return new MCuenta().Catalogo_Cuentas(tipo);
        }

    }
}
