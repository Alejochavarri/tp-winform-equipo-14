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
    public partial class EliminarArticulo : Form
    {
        private Articulos articulo;
        private ArticuloServer articuloNegocio;
        private ImagenServer imagenNegocio;

        public EliminarArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Eliminar Articulo #" + this.articulo.Codigo;
            articuloNegocio = new ArticuloServer();
            imagenNegocio = new ImagenServer();
        }

        private void EliminarArticulo_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "ATENCION: Se eliminara el articulo #" + articulo.Codigo;
            lblNombre.Text = articulo.Nombre;
            lblCodigo.Text = articulo.Codigo;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString();
            lblMarca.Text = articulo.Marca.Descripcion;
            lblCategoria.Text = articulo.Categoria.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea eliminar el articulo #" + articulo.Codigo + " " + articulo.Nombre + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                { 
                    int imgRows = imagenNegocio.eliminar(articulo.ID);
                    int rowsAffected = articuloNegocio.eliminar(articulo.ID);
                    if (rowsAffected == 1 && imgRows >= 1)
                    {
                        MessageBox.Show("Eliminado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo ha ocurrido al intentar eliminar el articulo");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                this.Close();
                return;
            }
        }
    }
}
