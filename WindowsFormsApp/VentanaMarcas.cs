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
    public partial class Marcas : Form
    {
        private List<Marca> listaMarcas;
        private MarcaServer marcas = new MarcaServer();
        public Marcas()
        {
            InitializeComponent();
        }
        

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            AgregarMarca marca = new AgregarMarca();
            marca.ShowDialog();
            Marcas_Load(sender, e);
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            MarcaServer marcaServer = new MarcaServer();
            listaMarcas = marcaServer.listar();
            dgvMarcas.DataSource = listaMarcas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            ModificarMarca modificarMarca = new ModificarMarca(marca);
            modificarMarca.ShowDialog();
            Marcas_Load(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            try
            {
                ArticuloServer articuloNegocio = new ArticuloServer();
                List<Articulos> lista = articuloNegocio.listarPorMarca(marca.Id);
                if (lista.Count > 0)
                {
                    MessageBox.Show("No se puede eliminar la marca " + marca.Descripcion + ". Existen " + lista.Count + " articulos cargados con esa marca.");
                    return;
                }

                if (MessageBox.Show("¿Seguro desea eliminar la marca " + marca.Descripcion + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowsAffected = marcas.eliminar(marca.Id);
                    if (rowsAffected == 1)
                        MessageBox.Show("Eliminado correctamente.");
                    else
                        MessageBox.Show("No se pudo eliminar..");
                }

                Marcas_Load(sender, e);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
