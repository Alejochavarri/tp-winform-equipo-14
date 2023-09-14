﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ImagenServer
    {
        public int guardar(Imagen imagen)
        {
            int idImagen = -1;
            int idArticulo = imagen.IdArticulo;
            string urlImagen = imagen.UrlImagen;
            string query = "INSERT INTO IMAGENES(IdArticulo, ImagenUrl) VALUES(@idArticulo, @urlImagen); SELECT CAST(SCOPE_IDENTITY() AS INT) AS ID";
            AccesoDatos db = new AccesoDatos();
            try
            {
                db.setConsulta(query);
                db.setearParametro("@idArticulo", idArticulo);
                db.setearParametro("@urlImagen", urlImagen);
                db.ejecutarLectura();

                if (db.Lector.Read())
                {
                    idImagen = (int)db.Lector["ID"];
                }

                return idImagen;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }


        public List<Imagen> imagenesArticulo(int idArticulo)
        {
            AccesoDatos db = new AccesoDatos();
            string query = "SELECT IdArticulo, ImagenUrl, Id FROM IMAGENES WHERE IdArticulo = @idArticulo";
            List<Imagen> imagenes = new List<Imagen>();

            try
            {
                db.setConsulta(query);
                db.setearParametro("@idArticulo", idArticulo);
                db.ejecutarLectura();
                while (db.Lector.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.Id = (int)db.Lector["Id"];
                    imagen.UrlImagen = (string)db.Lector["ImagenUrl"];
                    imagen.IdArticulo = (int)db.Lector["IdArticulo"];
                    imagenes.Add(imagen);
                }

                return imagenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
