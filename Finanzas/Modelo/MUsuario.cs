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
    public class MUsuario
    {
        string usuario;
        string contraseña;
        string rol;

        public MUsuario () { }

        public MUsuario (string usuario, string contraseña, string rol)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.rol = rol;
        }


        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }

        public int consulta (string usuario, string contraseña, string rol)
        {

            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            DataRow dr;
            try
            {
                SqlCon.ConnectionString = Conexion.cadena;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Acceso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@usuario";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 50;
                ParDato.Value = usuario;
                SqlCmd.Parameters.Add(ParDato);

                SqlParameter ParDato1 = new SqlParameter();
                ParDato1.ParameterName = "@contraseña";
                ParDato1.SqlDbType = SqlDbType.VarChar;
                ParDato1.Size = 100;
                ParDato1.Value = contraseña;
                SqlCmd.Parameters.Add(ParDato1);

                SqlParameter ParDato2 = new SqlParameter();
                ParDato2.ParameterName = "@rol";
                ParDato2.SqlDbType = SqlDbType.VarChar;
                ParDato2.Size = 50;
                ParDato2.Value = rol;
                SqlCmd.Parameters.Add(ParDato2);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if (DtResultado.Rows.Count > 0)
                {
                    dr = DtResultado.Rows [0];
                    return Convert.ToInt32(dr ["IdUsuario"].ToString());
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
        }

        public DataTable buscar (object objeto)
        {
            throw new NotImplementedException();
        }

        public DataTable editar (object objeto)
        {
            throw new NotImplementedException();
        }

        public DataTable eliminar (object objeto)
        {
            throw new NotImplementedException();
        }

        public DataTable Insertar (object objeto)
        {
            throw new NotImplementedException();
        }
    }
}
