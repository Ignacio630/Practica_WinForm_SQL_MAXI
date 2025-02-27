using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLQuerys
{
    public class DB
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public void conectarDB()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public void conectarDB(string parametrosConexion)
        {
            conexion = new SqlConnection(parametrosConexion);
            comando = new SqlCommand();
        }

        public void setConsultaDB(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarConsultaSelectDB()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ejecutarConsultaInsertDB()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                finalizarConexionDB();
            }

        }
        public void finalizarConexionDB()
        {
            if(Lector != null)
            {
                Lector.Close();
            }
            conexion.Close();
        }
    }
}
