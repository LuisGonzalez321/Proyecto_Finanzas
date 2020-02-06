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

        public static DataTable ConsultaAV(int año, string tipo)
        {
            return new MCuenta().Consulta_AV(año, tipo);
        }

        public static DataTable ConsultaAH(int añoA, int añoB, string tipo)
        {
            return new MCuenta().Consulta_AH(añoA, añoB, tipo);
        }

        public static DataTable Catalogo_Cuentas (string tipo)
        {
            return new MCuenta().Catalogo_Cuentas(tipo);
        }

        public static List<string> Consultas_query ()
        {
            DataTable dt = new MCuenta().Consultas_query("select distinct year(fecha) as fecha from transacción");
            List<string> lista_fecha = new List<string>();

            for (int i = 0 ;i < dt.Rows.Count ;i++)
            {
                lista_fecha.Add(dt.Rows[i]["fecha"].ToString());
            }
            return lista_fecha;
        }

    }
}
