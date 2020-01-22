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


        public static DataTable Cargar_EstadoResultado (int año)
        {
            DataTable tabla_ingresos = new MCuenta().Consulta(año, "INGRESOS");
            DataTable tabla_costos = new MCuenta().Consulta(año, "COSTOS");
            DataTable tabla_gastos = new MCuenta().Consulta(año, "GASTOS");

            tabla_ingresos.Merge(tabla_costos);
            tabla_ingresos.Merge(tabla_gastos);

            return tabla_ingresos;
        }

        public static List<string> Consultas_query ()
        {
            DataTable dt = new MCuenta().Consultas_query("select distinct year(fecha) as fecha from transacción");
            List<string> lista_fecha = new List<string>();

            for (int i = 0 ;i < dt.Rows.Count ;i++)
            {
                lista_fecha.Add(dt.Rows [i] ["fecha"].ToString());
            }
            return lista_fecha;
        }

    }
}
