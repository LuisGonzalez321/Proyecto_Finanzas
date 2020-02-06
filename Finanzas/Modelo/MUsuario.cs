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

        public DataTable editar (MUsuario musuario, int id)
        {
            SqlConnection SqlCon = new SqlConnection();
            DataTable dt = new DataTable();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.cadena;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Modificar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter Parid = new SqlParameter();
                Parid.ParameterName = "@idUsuario";
                Parid.SqlDbType = SqlDbType.Int;
                Parid.Value = id;
                SqlCmd.Parameters.Add(Parid);

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@usuario";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Size = 50;
                parUsuario.Value = musuario.usuario;
                SqlCmd.Parameters.Add(parUsuario);

                SqlParameter parContraseña = new SqlParameter();
                parContraseña.ParameterName = "@contraseña";
                parContraseña.SqlDbType = SqlDbType.VarChar;
                parContraseña.Size = 50;
                parContraseña.Value = musuario.contraseña;
                SqlCmd.Parameters.Add(parContraseña);

                SqlParameter parRol = new SqlParameter();
                parRol.ParameterName = "@rol";
                parRol.SqlDbType = SqlDbType.VarChar;
                parRol.Size = 50;
                parRol.Value = musuario.rol;
                SqlCmd.Parameters.Add(parRol);

                //Ejecutamos nuestro comando
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dt = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return dt;
        }



        public bool eliminar (int id)
        {
            bool stat;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.cadena;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Eliminar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;//Se Puede ingredar una tabla una lista no solamente un procedimiento almacenado

                SqlParameter Parid= new SqlParameter();
                Parid.ParameterName = "@idUsuario";
                Parid.SqlDbType = SqlDbType.Int;
                Parid.Value = id;
                SqlCmd.Parameters.Add(Parid);

                //    //Ejecutamos nuestro comando
                SqlCmd.ExecuteNonQuery();

                stat = true;
            }
            catch (Exception on)
            {
                stat = false;
                MessageBox.Show(on.Message);
            }
            return stat;
        }

        public bool Insertar (MUsuario musuario)
        {
            bool state;
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexion.cadena;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter parUsuario = new SqlParameter();
                parUsuario.ParameterName = "@usuario";
                parUsuario.SqlDbType = SqlDbType.VarChar;
                parUsuario.Size = 50;
                parUsuario.Value = musuario.usuario;
                SqlCmd.Parameters.Add(parUsuario);

                SqlParameter parContraseña = new SqlParameter();
                parContraseña.ParameterName = "@contraseña";
                parContraseña.SqlDbType = SqlDbType.VarChar;
                parContraseña.Size = 50;
                parContraseña.Value = musuario.contraseña;
                SqlCmd.Parameters.Add(parContraseña);

                SqlParameter parRol = new SqlParameter();
                parRol.ParameterName = "@rol";
                parRol.SqlDbType = SqlDbType.VarChar;
                parRol.Size = 50;
                parRol.Value = musuario.rol;
                SqlCmd.Parameters.Add(parRol);

                //Ejecutamos nuestro comando
                SqlCmd.ExecuteNonQuery();// == 1 ? "OK" : "NO se Ingreso el Registro";

                state = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                state = false;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return state;
        }
    }
}
