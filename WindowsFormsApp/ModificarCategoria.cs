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
using Server;

namespace WindowsFormsApp
{
    public partial class ModificarCategoria : Form
    {
        private Categoria categoria;
        private CategoriaServer categoriaNegocio;
        public ModificarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria " + this.categoria.Descripcion;
            this.categoriaNegocio = new CategoriaServer();
        }
        private void ModificarCategoria_Load(object sender, EventArgs e)
        {
            lblCategoriaTitulo.Text = "ID " + categoria.Id + " " + categoria.Descripcion;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = tbxNombreCategoria.Text;
                int idCategoria = categoria.Id;
                if (descripcion == "")
                {
                    MessageBox.Show("No se puede guardar una Categoria vacía");
                }
                else
                {
                    int rowsAffected = categoriaNegocio.modificar(descripcion, idCategoria);
                    if (rowsAffected != 1)
                    {
                        MessageBox.Show("Algo paso al intentar modificar la categoria");
                        return;
                    }
                    MessageBox.Show("Categoria modificada correctamente");
                    this.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
