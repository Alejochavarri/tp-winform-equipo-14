using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace PruebaProyecto
{
    public partial class Principal : Form
    {
        public List<Articulo> lista;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            lista = negocio.listar();
            dgvArticulos.DataSource = lista;
            pcbImagenArticulo.Load(lista[0].Imagen.UrlImagen);

            dgvArticulos.Columns["Imagen"].Visible = false;

        }

        public void cargarImagen(string url)
        {
            try
            {
                pcbImagenArticulo.Load(url);
            }
            catch (Exception)
            {
                pcbImagenArticulo.Load("https://www.generationsforpeace.org/wp-content/uploads/2018/03/empty.jpg");

            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.UrlImagen);
        }
    }
}
