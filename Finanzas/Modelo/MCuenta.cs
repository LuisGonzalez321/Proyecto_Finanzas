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


        /* Muestra el catálogo de cuentas sobre el tipo de cuenta del BG */
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

        /* Realiza un consulta sobre el tipo de cuenta del BG en determinado año*/
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

        public bool Insertar_monto (int idCuenta,double monto, DateTime fecha,string concepto)
        {
            SqlConnection sqlcon = new SqlConnection();
            bool flag = false;
            try
            {
                sqlcon.ConnectionString = Conexion.cadena;
                sqlcon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlcon;
                SqlCmd.CommandText = "Insertar_monto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCuenta = new SqlParameter();
                ParIdCuenta.ParameterName = "@IdCuenta";
                ParIdCuenta.SqlDbType = SqlDbType.Int;
                ParIdCuenta.Value = idCuenta;
                SqlCmd.Parameters.Add(ParIdCuenta);

                SqlParameter ParMonto = new SqlParameter();
                ParMonto.ParameterName = "@Monto";
                ParMonto.SqlDbType = SqlDbType.Money;
                ParMonto.Value = monto;
                SqlCmd.Parameters.Add(ParMonto);

                SqlParameter Parfecha = new SqlParameter();
                Parfecha.ParameterName = "@Fecha";
                Parfecha.SqlDbType = SqlDbType.Date;
                Parfecha.Value = fecha;
                SqlCmd.Parameters.Add(Parfecha);

                SqlParameter ParConcepto = new SqlParameter();
                ParConcepto.ParameterName = "@Concepto";
                ParConcepto.SqlDbType = SqlDbType.VarChar;
                ParConcepto.Size = 5;
                ParConcepto.Value = concepto;
                SqlCmd.Parameters.Add(ParConcepto);

                SqlCmd.ExecuteNonQuery();

                flag = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            return flag;
        }


    }
}
