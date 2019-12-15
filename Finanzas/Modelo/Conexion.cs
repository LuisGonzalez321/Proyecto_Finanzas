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
        public static string cadena = "Data Source=GABRIEL-PC;Initial Catalog=Finanzas;Integrated Security=True";

        public SqlConnection con;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand comando;

        public void Conectar ()
        {
            con = new SqlConnection(cadena);
        }

        public Conexion ()
        {
           // Conectar();
        }


       /* public DataTable Consulta (string sql,string tabla)
        {
            DataTable datatable = new DataTable();
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            da.Fill(ds, tabla);
            datatable = ds.Tables [tabla];
            return datatable;
        }*/

        public DataTable Consulta (int año,string tipo)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = cadena;
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
    }
}
