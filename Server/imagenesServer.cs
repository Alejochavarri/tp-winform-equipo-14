using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class imagenesServer
    {
        public List<Imagenes> listar()
        {
            List<Imagenes> Catalogo = new List<Imagenes>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("select * from IMAGENES"); // falta ruta
                datos.ejecutarConsulta();
                while (datos.lector.Read())
                {
                    Imagenes aux = new Imagenes();
                    aux.ID = (int)datos.lector["Id"];
                    aux.IDArticulo = (int)datos.lector["IdArticulo"];
                    aux.linkImagen = (String)datos.lector["ImagenUrl"];
                    
                    Catalogo.Add(aux);

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
