using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finazas.Modelo;

namespace Finanzas.Controlador
{
    class CConsulta
    {

        public static DataTable Consulta(int año,string tipo)
        {
            return new MCuenta().Consulta(año, tipo);
        }

        public static DataTable Catalogo_Cuentas (string tipo)
        {
            return new MCuenta().Catalogo_Cuentas(tipo);
        }

    }
}
