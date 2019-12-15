using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finazas.Modelo;

namespace Finanzas.Controlador
{
    class Consultas
    {

        public static DataTable Consulta(int año,string tipo)
        {
            return new Conexion().Consulta(año, tipo);
        }

    }
}
