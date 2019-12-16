using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finazas.Modelo
{
    public class Cuenta
    {
        int idCuenta;
        string nombre;
        float monto;
        DateTime fecha;
        string concepto;

        public Cuenta () { }

        public Cuenta (int idCuenta, string nombre, float monto, DateTime fecha, string concepto)
        {
            this.IdCuenta = idCuenta;
            this.nombre = nombre;
            this.monto = monto;
            this.fecha = fecha;
            this.concepto = concepto;
        }

        public int IdCuenta { get; set; }

        public string Nombre { get; set; }

        public float Monto { get; set; }

        public DateTime Fecha { get; set; }

        public string Concepto { get; set; }

        


    }
}
