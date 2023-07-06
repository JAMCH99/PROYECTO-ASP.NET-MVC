using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Capadatos
{

    // se crea la conexion a la base de datos 
    public class Conexion
    {
        public static string cn = ConfigurationManager.ConnectionStrings["cadena"].ToString();

        /*
        private SqlConnection conexion;

        public void Abrir()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Initial Catalog=PRIMER PROYECTO CON ASP.NET; Data Source=LAPTOP-CHP508T2\SQLEXPRESS; Integrated Security=SSPI ";
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }

        private SqlCommand CrearComando(string sql,List<SqlParameter>parametros=null)
        {
            SqlCommand comando = new SqlCommand(sql,conexion);
            comando.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                comando.Parameters.AddRange(parametros.ToArray());

            }
            return comando;
        }

        public int LeerEscalar(string sql, List<SqlParameter> parametros = null)
        {
            object res = null;
            SqlCommand comando = CrearComando(sql, parametros);
            try
            {
                res = comando.ExecuteScalar();

            }
            catch
            {
                res = -1;
            }
            return int.Parse(res.ToString());
        }

        public int Escribir(string sql, List<SqlParameter> parametros = null)
        {

            SqlCommand comando = CrearComando(sql, parametros);
            int res;
            try
            {

                res = comando.ExecuteNonQuery();
            }
            catch
            {
                res = -1;
            }

            return res;
        }


        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {

            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = CrearComando(sql, parametros);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);


            return tabla;
        }


        #region "Parametros"
        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.Value = valor;
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.String;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.Value = valor;
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.Int32;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, long valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.Value = valor;
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.Int64;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.Value = valor;
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.DateTime;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, bool valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.Value = valor;
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.Boolean;
            return parametro;
        }
        public SqlParameter CrearParametro(string nombre, SqlDbType valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.Value = valor;
            parametro.ParameterName = nombre;
            parametro.DbType = DbType.String;
            return parametro;
        }
        #endregion
        */
    }
}
