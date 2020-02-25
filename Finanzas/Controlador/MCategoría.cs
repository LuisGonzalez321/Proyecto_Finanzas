using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finazas.Modelo
{
    public class Categoría
    {
        string nombre;
        string descripión;


        public string Nombre { get; set; }

        public string Descripción { get; set; }

        public Categoría (){}

        public Categoría (string nombre, string descripión)
        {
            this.nombre = nombre;
            this.descripión = descripión;
        }

        public DataTable Mostrar_categoría ()
        {
            return null;
        }

    }
}
