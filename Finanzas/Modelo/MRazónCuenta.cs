using Finazas.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas.Modelo
{
    public class MRazónCuenta
    {
        public string nombre;
        public DateTime fecha;


        public MRazónCuenta () { }

        public MRazónCuenta (string nombre, DateTime fecha)
        {
            this.fecha = fecha;
            this.nombre = nombre;
        }

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public double Razon_cuenta (string nombre, DateTime fecha)
        {
            DataTable datatable = new DataTable();
            SqlConnection sqlcon = new SqlConnection();
            DataRow datarow;

            try
            {
                sqlcon.ConnectionString = Conexion.cadena;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = nombre;
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@año";
                ParDato.SqlDbType = SqlDbType.Int;
                ParDato.Value = fecha.Year;
                sqlcmd.Parameters.Add(ParDato);

                SqlDataAdapter SqlDat = new SqlDataAdapter(sqlcmd);
                SqlDat.Fill(datatable);
                if (datatable.Rows.Count > 0)
                {
                    datarow = datatable.Rows [0];
                    return Convert.ToDouble (datarow [nombre].ToString());
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        /*
         
            
         */

    }
}
