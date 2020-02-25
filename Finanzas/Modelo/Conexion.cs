using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finazas.Modelo
{
    class Conexion
    {
        /**
         *
         * Se crea la variable de cadena de conexión.
         * También se es necesario cambiar al momento de iniciar con otro motor de base de datos
         * Recomendaciones: usar roles de usuario para la cadena de conexión
         */
        public static string cadena = "Data Source=(local);Initial Catalog=Finanzas;Integrated Security=True";

    }
}
