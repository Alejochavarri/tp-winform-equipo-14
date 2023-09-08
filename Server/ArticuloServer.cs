using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Server
{
    public class ArticuloServer
    {
        public List<Articulos> listar()
        {
            List<Articulos> Catalogo = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta(""); // falta ruta
                datos.ejecutarConsulta();
                while (datos.lector.Read())
                {
                    // consultas
                }
                
                return Catalogo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }

        
        
    }
}
