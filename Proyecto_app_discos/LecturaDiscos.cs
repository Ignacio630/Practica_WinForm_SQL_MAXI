using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelos;
namespace Proyecto_app_discos
{
    internal class LecturaDiscos
    {

        public List<Discos> Listar()
        {
            List<Discos> listaDiscos = new List<Discos>();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader data;

            try
            {
                con.ConnectionString = ("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
                cmd.CommandText = "Select D.Titulo, D.CantidadCanciones, D.FechaLanzamiento, D.UrlImagenTapa, E.Descripcion as Estilos , T.Descripcion as Tipos from DISCOS D, ESTILOS E, TIPOSEDICION T where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id\r\n";
                cmd.Connection = con;

                con.Open();

                data = cmd.ExecuteReader();

                while (data.Read())
                {
                    Discos aux = new Discos();
                    aux.Titulo = (string)data["Titulo"];
                    aux.Canciones = (int)data["CantidadCanciones"];
                    aux.FechaLanzamiento = (DateTime)data["FechaLanzamiento"];
                    aux.Url = (string)data["UrlImagenTapa"];
                    aux.Estilo = new Estilos();
                    aux.Estilo.Descripcion = (string)data["Estilos"];
                    aux.Edicion = new Edicion();
                    aux.Edicion.Descripcion = (string)data["Tipos"];

                    listaDiscos.Add(aux);

                }
                con.Close();


                return listaDiscos; 

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
