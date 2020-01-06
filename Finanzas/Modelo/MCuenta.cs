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
    public class MCuenta
    {
  
        string nombre;
        float monto;
        DateTime fecha;
        string concepto;

        public MCuenta () { }

        public MCuenta (int idCuenta, string nombre, float monto, DateTime fecha, string concepto)
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


        public DataTable Catalogo_Cuentas (string tipo)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cadena;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Catalogo_Cuentas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato2 = new SqlParameter();
                ParDato2.ParameterName = "@tipo";
                ParDato2.SqlDbType = SqlDbType.VarChar;
                ParDato2.Size = 10;
                ParDato2.Value = tipo;
                SqlCmd.Parameters.Add(ParDato2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable Consulta (int año, string tipo)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cadena;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarBalanceGeneral";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato1 = new SqlParameter();
                ParDato1.ParameterName = "@fecha";
                ParDato1.SqlDbType = SqlDbType.Int;
                ParDato1.Value = año;
                SqlCmd.Parameters.Add(ParDato1);

                SqlParameter ParDato2 = new SqlParameter();
                ParDato2.ParameterName = "@tipo";
                ParDato2.SqlDbType = SqlDbType.VarChar;
                ParDato2.Size = 10;
                ParDato2.Value = tipo;
                SqlCmd.Parameters.Add(ParDato2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable Consultas_query (string sql)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.cadena;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = sql;
                SqlCmd.CommandType = CommandType.Text;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DtResultado = null;
            }
            return DtResultado;
        }

    }
}
