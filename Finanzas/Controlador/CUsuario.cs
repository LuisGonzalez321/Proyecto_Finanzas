using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finazas.Modelo;
using System.Data;

namespace Finazas.Controlador
{
    public class CUsuario
    {
        public static int MostrarUsuario (string usuario, string contraseña, string rol)
        {
            return new Modelo.MUsuario().consulta(usuario, contraseña, rol);
        }
    }
}
