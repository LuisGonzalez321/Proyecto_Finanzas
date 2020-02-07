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

        public static DataTable Mostrar ()
        {
            return new MUsuario().Mostrar();
        }

        public static bool Insertar_usuario (string usuario, string contraseña, string rol)
        {
            MUsuario musuario = new MUsuario(usuario, contraseña, rol);
            bool flag = musuario.Insertar(musuario);
            return flag;
        }

        public static DataTable Editar (int id, string usuario, string contraseña, string rol)
        {
            MUsuario musuario = new MUsuario(usuario, contraseña, rol);
            return musuario.Editar(musuario, id);
        }

        public static bool Eliminar (int id)
        {
            return new MUsuario().Eliminar(id);
        }

    }
}
