using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finanzas.Modelo.Herramientas
{
    class Toolkit
    {

        public static string Estado_Empresa (int valor)
        {
            if (valor > 0 && valor <= 20)
            {
                return "La empresa está en una excelente posición";
            }
            else if (valor > 21 && valor <= 40)
            {
                return "La empresa está en una buena posición";
            }
            else if (valor > 50 && valor <= 70)
            {
                return "La empresa está en una mala posició";
            }
            else
            {
                return "La empresa está en una pésima posición";
            }
        }


    }
}
