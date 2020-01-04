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

        public static bool Insertart_monto (int idCuenta, double monto, DateTime fecha, string concepto)
        {
            return new MCuenta().Insertar_monto(idCuenta, monto, fecha, concepto);
        }

        public static DataTable Mostrar_EstadoResultado ()
        {
            return new MCuenta().Mostrar_EstadoResultado();
        }
    }
}
