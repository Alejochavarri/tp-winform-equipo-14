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
                datos.setConsulta("SELECT A.*, M.Descripcion AS Desc_Marca, C.Descripcion AS Desc_Categoria FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id");
                datos.ejecutarLectura();
                while (datos.lector.Read())
                {
                    Articulos aux = new Articulos();

                    int idArticulo = (int)datos.Lector["Id"];
                    aux.ID = idArticulo;
                    if (!(datos.Lector["Codigo"] is DBNull)) aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull)) aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull)) aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["Precio"] is DBNull)) aux.Precio = (decimal)datos.Lector["Precio"];

                    ImagenServer imagenNegocio = new ImagenServer();
                    aux.Imagen = imagenNegocio.imagenesArticulo(idArticulo);

                    if (!(datos.Lector["IdMarca"] is DBNull))
                    {
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)datos.Lector["Desc_Marca"];
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    }

                    if (!(datos.Lector["IdCategoria"] is DBNull))
                    {
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)datos.Lector["Desc_Categoria"];
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
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
