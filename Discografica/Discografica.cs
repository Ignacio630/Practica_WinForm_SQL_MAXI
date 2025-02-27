using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using SQLQuerys;

namespace NegocioDiscografica
{
    public class Discografica
    {
        public List<Edicion>listaEdiciones()
        {
            List<Edicion> listaEdiciones = new List<Edicion>();
            DB accesoDB = new DB();

            try
            {
                accesoDB.conectarDB();
                accesoDB.setConsultaDB("Select Id, Descripcion From TIPOSEDICION");
                accesoDB.ejecutarConsultaSelectDB();

                while (accesoDB.Lector.Read())
                {
                    Edicion aux = new Edicion();

                    aux.Id = (int)accesoDB.Lector["Id"];
                    aux.Descripcion = (string)accesoDB.Lector["Descripcion"];

                    listaEdiciones.Add(aux);
                }

                return listaEdiciones;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Estilos> listaEstilos()
        {
            List<Estilos> listaEstilos = new List<Estilos>();
            DB accesoDB = new DB();

            try
            {
                accesoDB.conectarDB();
                accesoDB.setConsultaDB("Select Id, Descripcion From ESTILOS");
                accesoDB.ejecutarConsultaSelectDB();

                while (accesoDB.Lector.Read())
                {
                    Estilos aux = new Estilos();

                    aux.Id = (int)accesoDB.Lector["Id"];
                    aux.Descripcion = (string)accesoDB.Lector["Descripcion"];

                    listaEstilos.Add(aux);
                }

                return listaEstilos;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Discos> listarDiscos()
        {
            List<Discos> listaDiscos = new List<Discos>();
            DB accesoDB = new DB();
            try
            {
                accesoDB.conectarDB("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
                accesoDB.setConsultaDB("Select D.Titulo, D.CantidadCanciones, D.FechaLanzamiento, D.UrlImagenTapa, E.Descripcion as Estilos , T.Descripcion as Tipos from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id\r\n");
                accesoDB.ejecutarConsultaSelectDB();

                while(accesoDB.Lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Titulo = (string)accesoDB.Lector["Titulo"];
                    aux.Canciones = (int)accesoDB.Lector["CantidadCanciones"];
                    aux.FechaLanzamiento = (DateTime)accesoDB.Lector["FechaLanzamiento"];
                    aux.Url = (string)accesoDB.Lector["UrlImagenTapa"];
                    aux.Estilo = new Estilos();
                    aux.Estilo.Descripcion = (string)accesoDB.Lector["Estilos"];
                    aux.Edicion = new Edicion();
                    aux.Edicion.Descripcion = (string)accesoDB.Lector["Tipos"];

                    listaDiscos.Add(aux);

                }

                return listaDiscos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDB.finalizarConexionDB();
            }
        }
        public void agregarDisco(Discos nuevoDisco)
        {
            DB accesoDatos = new DB();

            try
            {
                accesoDatos.conectarDB("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
                accesoDatos.setConsultaDB($"INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) VALUES ('{nuevoDisco.Titulo}', '{nuevoDisco.FechaLanzamiento:yyyy-MM-dd}', {nuevoDisco.Canciones}, '{nuevoDisco.Url}', {nuevoDisco.Estilo.Id}, {nuevoDisco.Edicion.Id})");
                
                accesoDatos.ejecutarConsultaInsertDB();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally 
            {
                accesoDatos.finalizarConexionDB();
            }
        }
    }
}
