using Dominio;
using Server;
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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaServer marcas = new MarcaServer();
            List<Marca> listaMarcas = marcas.listar();
            foreach (var item in listaMarcas)
            {
                cbxMarca.Items.Add(item);
            }

            CategoriaServer categorias = new CategoriaServer();
            List<Categoria> listaCategorias = categorias.listar();
            foreach (var item in listaCategorias)
            {
                cbxCategoria.Items.Add(item);
            }
        }

        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && tbxPrecio.Text.Length > 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = ',';
                if (tbxPrecio.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }


            decimal value;
            if (!decimal.TryParse((sender as TextBox).Text + e.KeyChar, out value))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                e.Handled = true;
            }
        }

        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            string url = tbxUrlImagen.Text;
            cargarImagen(url);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);

            }
            catch (Exception)
            {

                pbImagen.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisualizarArticulo_Click(object sender, EventArgs e)
        {
            lvPrevisualizacion.Clear();
            string codigo = tbxCodigo.Text;
            string nombre = tbxNombre.Text;
            string descripcion = rtbxDescripcion.Text;
            string marca = cbxMarca.Text;
            string categoria = cbxCategoria.Text;
            string urlImagen = tbxUrlImagen.Text;
            string precio = tbxPrecio.Text;

            lvPrevisualizacion.Items.Add("* Codigo: " + codigo);
            lvPrevisualizacion.Items.Add("* Nombre: " + nombre);
            lvPrevisualizacion.Items.Add("* Descripcion: " + descripcion);
            lvPrevisualizacion.Items.Add("* Marca: " + marca);
            lvPrevisualizacion.Items.Add("* Categoria: " + categoria);
            lvPrevisualizacion.Items.Add("* UrlImagen: " + urlImagen);
            lvPrevisualizacion.Items.Add("* Pecio: $" + precio);
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = tbxCodigo.Text;
                string nombre = tbxNombre.Text;
                string descripcion = rtbxDescripcion.Text;
                decimal precio = decimal.Parse(tbxPrecio.Text);
                string inMarca = cbxMarca.Text;
                string inCategoria = cbxCategoria.Text;
                string inUrlImagen = tbxUrlImagen.Text;

                if (inUrlImagen.Trim() == "")
                {
                    MessageBox.Show("No se puede cargar un articulo sin una imagen");
                    return;
                }
                MarcaServer marcaNegocio = new MarcaServer();
                Marca marca = marcaNegocio.buscarPorDescripcion(inMarca);
                if (marca == null)
                {
                    MessageBox.Show("No se ha encontrado una marca con la descripcion: " + inMarca);
                    return;
                }

                CategoriaServer categoriaNegocio = new CategoriaServer();
                Categoria categoria = categoriaNegocio.buscarPorDescripcion(inCategoria);
                if (categoria == null)
                {
                    MessageBox.Show("No se ha encontrado una categoria con la descripcion: " + inCategoria);
                    return;
                }

                // Guardado de Articulo
                ArticuloServer articuloNegocio = new ArticuloServer();
                Articulos nuevoArticulo = new Articulos();
                nuevoArticulo.Codigo = codigo;
                nuevoArticulo.Nombre = nombre;
                nuevoArticulo.Descripcion = descripcion;
                nuevoArticulo.Precio = precio;
                nuevoArticulo.Marca = (Marca)cbxMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                int idArticulo = articuloNegocio.guardar(nuevoArticulo);

                // Guardado de Imagen
                ImagenServer imagenNegocio = new ImagenServer();
                Imagen nuevaImagen = new Imagen();
                nuevaImagen.IdArticulo = idArticulo;
                nuevaImagen.UrlImagen = inUrlImagen;
                imagenNegocio.guardar(nuevaImagen);

                MessageBox.Show("Guardado Correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }
    }
}

