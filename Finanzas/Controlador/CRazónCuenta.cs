using Finanzas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Controlador
{
    public class CRazónCuenta
    {
        public static double Razon_cuenta (string nombre, DateTime fecha)
        {
            return new MRazónCuenta().Razon_cuenta(nombre, fecha);
        }
    }
}
