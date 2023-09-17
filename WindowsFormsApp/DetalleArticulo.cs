using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class DetalleArticulo : Form
    {
        private Articulos articulo;
        private int countPic;

        public DetalleArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle Articulo #" + this.articulo.Codigo;
            this.countPic = 0;
        }

        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            if (articulo.Imagen.Count > 0)
                cargarImagen(articulo.Imagen.First().UrlImagen);
            else
                cargarImagen("asd");

            if (articulo.Imagen.Count > 1)
            {
                btnFotoIzq.Visible = true;
                btnFotoDer.Visible = true;
            }
            else
            {
                btnFotoDer.Visible = false;
                btnFotoIzq.Visible = false;
            }
            lblFotos.Text = "Foto " + (countPic + 1) + " / " + articulo.Imagen.Count;
            lblCodigo.Text = articulo.Codigo;
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblCategoria.Text = articulo.Categoria.Descripcion;
            lblMarca.Text = articulo.Marca.Descripcion;
            lblPrecio.Text = "$" + articulo.Precio.ToString();
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArt.Load(imagen);

            }
            catch (Exception)
            {

                pbxArt.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFotoIzq_Click(object sender, EventArgs e)
        {
            int cantImagenes = articulo.Imagen.Count;
            if (cantImagenes > 0)
            {
                if (countPic > 0) countPic--;
                else if (countPic == 0)
                    countPic = cantImagenes - 1;

                lblFotos.Text = "Foto " + (countPic + 1) + " / " + articulo.Imagen.Count;
                cargarImagen(articulo.Imagen[countPic].UrlImagen);
            }
            else
            {
                cargarImagen("asd");
                lblFotos.Text = "Foto 0 / 0";
            }
        }

        private void btnFotoDer_Click(object sender, EventArgs e)
        {
            int cantImagenes = articulo.Imagen.Count;
            if (cantImagenes > 0)
            {
                if (countPic < cantImagenes - 1)
                    countPic++;
                else
                    countPic = 0;

                lblFotos.Text = "Foto " + (countPic + 1) + " / " + articulo.Imagen.Count;
                if (articulo.Imagen.Count > 0)
                    cargarImagen(articulo.Imagen[countPic].UrlImagen);
            }
            else
            {
                cargarImagen("asd");
                lblFotos.Text = "Foto 0 / 0";
            }
        }
    }
}
