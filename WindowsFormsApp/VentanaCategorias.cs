using Dominio;
using System;
using Server;
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
    public partial class VentanaCategorias : Form
    {
        private List<Categoria> listaCategorias;
        CategoriaServer categorias = new CategoriaServer();
        public VentanaCategorias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria agregarCategoria = new AgregarCategoria();
            agregarCategoria.ShowDialog();
            VentanaCategorias_Load(sender, e);
        }


        private void VentanaCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                listaCategorias = categorias.listar();
                dgvCategorias.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            ModificarCategoria modificarCategoria = new ModificarCategoria(categoria);
            modificarCategoria.ShowDialog();
            VentanaCategorias_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            try
            {
                ArticuloServer articuloNegocio = new ArticuloServer();
                List<Articulos> lista = articuloNegocio.listarPorCategoria(categoria.Id);
                if (lista.Count > 0)
                {
                    MessageBox.Show("No se puede eliminar la categoria " + categoria.Descripcion + ". Existen " + lista.Count + " articulos cargados con esa categoria.");
                    return;
                }

                if (MessageBox.Show("¿Seguro desea eliminar la categoria " + categoria.Descripcion + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowsAffected = categorias.eliminar(categoria.Id);
                    if (rowsAffected == 1)
                        MessageBox.Show("Eliminado correctamente.");
                    else
                        MessageBox.Show("No se pudo eliminar..");
                }
                VentanaCategorias_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }
    }
}
