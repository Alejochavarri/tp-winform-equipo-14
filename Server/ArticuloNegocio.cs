using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();
			AccesoDatos datos = new AccesoDatos();

			try
			{
				datos.setearConsulta("SELECT A.Codigo,A.Nombre,A.Descripcion,C.Descripcion Categoria,M.Descripcion Marca,A.Precio,I.ImagenUrl from Articulos A\r\ninner join Categorias C on C.Id = A.IdCategoria\r\ninner join MARCAS M on M.Id = A.IdMarca\r\ninner join IMAGENES I on A.Id = I.IdArticulo ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
				    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen = new Imagen(); // Aca deberia hacer que al constructor de la imagen se le asigne el id del articulo
                    aux.Imagen.UrlImagen = (string)datos.Lector["ImagenUrl"]; 
                    lista.Add(aux);
                }

                return lista;
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
