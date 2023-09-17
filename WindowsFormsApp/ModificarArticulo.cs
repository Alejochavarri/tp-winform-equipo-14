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
    public partial class ModificarArticulo : Form
    {
        private MarcaServer marcaNegocio;
        private CategoriaServer categoriaNegocio;
        private ArticuloServer articuloNegocio;
        private ImagenServer imagenNegocio;
        private bool previsualizado;
        private Articulos articulo;


        public ModificarArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo #" + this.articulo.Codigo;
            previsualizado = false;
            categoriaNegocio = new CategoriaServer();
            marcaNegocio = new MarcaServer();
            articuloNegocio = new ArticuloServer();
            imagenNegocio = new ImagenServer();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarArticulo_Load(object sender, EventArgs e)
        {
            tbxUrlImagen.Visible = false;
            lblCodigoArt.Text = "Cod: " + articulo.Codigo + " / " + articulo.Nombre;

            try
            {
                tbxCodigo.Text = articulo.Codigo;
                tbxNombre.Text = articulo.Nombre;
                rtbxDescripcion.Text = articulo.Descripcion;
                tbxPrecio.Text = articulo.Precio.ToString();
                tbxUrlImagen.Text = articulo.Imagen[0].UrlImagen;

                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.SelectedValue = articulo.Categoria.Id;

                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.SelectedValue = articulo.Marca.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void chbxImagen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxImagen.Checked)
            {
                tbxUrlImagen.Visible = true;
                lblAgregarImg.Visible = true;
                lblModificarImg.Visible = true;
                chbxModificarImg.Visible = true;
                chbxAgregarImg.Visible = true;
            }
            else
            {
                tbxUrlImagen.Visible = false;
                lblAgregarImg.Visible = false;
                lblModificarImg.Visible = false;
                chbxModificarImg.Visible = false;
                chbxAgregarImg.Visible = false;
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

        private void btnVisualizarArticulo_Click(object sender, EventArgs e)
        {
            lvPrevisualizacion.Clear();
            string codigo, nombre, descripcion, marca, categoria, precio;
            previsualizado = true;
            if (tbxCodigo.Text == "" || tbxNombre.Text == "" || rtbxDescripcion.Text == "" || tbxPrecio.Text == "")
            {
                MessageBox.Show("No se puede visualizar un Articulo con CAMPOS VACIOS");
                return;
            }

            codigo = "Codigo: " + tbxCodigo.Text;

             nombre = "Nombre: " + tbxNombre.Text;

             descripcion = "Descripcion: " + rtbxDescripcion.Text;

             marca = "Marca: " + cbxMarca.Text;

             categoria = "Categoria: " + cbxCategoria.Text;

             precio = "Precio: $" + tbxPrecio.Text;

            lvPrevisualizacion.Items.Add(codigo);
            lvPrevisualizacion.Items.Add(nombre);
            lvPrevisualizacion.Items.Add(descripcion);
            lvPrevisualizacion.Items.Add(marca);
            lvPrevisualizacion.Items.Add(categoria);
            lvPrevisualizacion.Items.Add(precio);
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            if (!previsualizado)
            {
                MessageBox.Show("Previzualiza el articulo antes de modificarlo!");
                return;
            }

            try
            {
                    articulo.Codigo = tbxCodigo.Text;
                
                    articulo.Nombre = tbxNombre.Text;
                
                    articulo.Descripcion = (string)rtbxDescripcion.Text;
                
                    articulo.Precio = decimal.Parse(tbxPrecio.Text);
                
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
             
                if (chbxImagen.Checked)
                {
                    Imagen imagen = new Imagen();
                    imagen.IdArticulo = articulo.ID;
                    imagen.UrlImagen = tbxUrlImagen.Text;
                    if (imagen.UrlImagen == "")
                    {
                        MessageBox.Show("No se puede modificar sin una imagen");
                        return;
                    }
                    foreach (var item in articulo.Imagen)
                    {
                        if (item.ToString() == imagen.UrlImagen)
                        {
                            MessageBox.Show("No se puede modificar o agregar un ARTICULO con la misma IMAGEN");
                            return;
                        }
                    }
                    if (chbxModificarImg.Checked)
                    {
                        int posicion = int.Parse(txtNImagen.Text);
                        if (posicion > articulo.Imagen.Count)
                        {
                            MessageBox.Show("La cantidad de imagenes es de " + articulo.Imagen.Count + " seleccione un numero menor a este.");
                            return;
                        }
                        articulo.Imagen[posicion - 1].UrlImagen = imagen.UrlImagen;
                        int modificado = imagenNegocio.modificar(articulo.Imagen[posicion - 1].Id, articulo.Imagen[posicion - 1].UrlImagen);
                        if (modificado != 1)
                        {
                            MessageBox.Show("No se pudo modificar el articulo");
                            return;
                        }
                        MessageBox.Show("Articulo modificado correctamente!");
                        return;
                    }

                    int idImagen = imagenNegocio.guardar(imagen);
                    imagen.Id = idImagen;
                    articulo.Imagen.Add(imagen);
                }

                if (articulo.Codigo == "" || articulo.Nombre == "" || articulo.Descripcion == "")
                {
                    MessageBox.Show("No pueden ir campos vacios");
                    return;
                }
                else
                {
                    int modificado = articuloNegocio.modificar(articulo);
                    if (modificado != 1)
                    {
                        MessageBox.Show("No se pudo modificar el articulo");
                        return;
                    }

                    MessageBox.Show("Articulo modificado correctamente!");
                    previsualizado = false;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void chbxModificarImg_CheckedChanged(object sender, EventArgs e)
        {
            chbxModificarImg.Checked = true;
            lblNImagen.Visible = true;
            txtNImagen.Visible = true;
            if (chbxAgregarImg.Checked)
            {
                chbxAgregarImg.Checked = false;
                return;
            }
        }

        private void chbxAgregarImg_CheckedChanged(object sender, EventArgs e)
        {
            chbxAgregarImg.Checked = true;
            if (chbxModificarImg.Checked)
            {
                chbxModificarImg.Checked = false;
                lblNImagen.Visible = false;
                txtNImagen.Visible = false;
                return;

            }
        }
    }
}
