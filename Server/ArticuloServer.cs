using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Data.SqlTypes;
using System.Net;

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
                datos.setConsulta("select A.Id, A.Codigo,A.Descripcion,A.Nombre,A.Precio,I.ImagenUrl, M.Descripcion as Marca,C.Descripcion as Categoria from ARTICULOS as A \r\ninner join IMAGENES as I on A.Id = I.Id\r\ninner join MARCAS as M on A.Id = M.Id\r\nleft join CATEGORIAS as C on A.Id = C.Id "); // falta ruta
                datos.ejecutarConsulta();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.ID = (int)datos.lector["Id"];
                    aux.Descripcion = (String)datos.lector["Descripcion"];
                    aux.Nombre = (String)datos.lector["Nombre"];
                    aux.Codigo = (String)datos.lector["Codigo"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Marca = (String)datos.lector["Marca"];
                    aux.linkImagen = (String)datos.lector["ImagenUrl"];
                    if (datos.lector.IsDBNull(datos.lector.GetOrdinal("Categoria")))
                    {
                        aux.Categoria = "";
                    }
                    else
                    {
                        aux.Categoria = (String)datos.lector["Categoria"];
                    }
                    
                    
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
