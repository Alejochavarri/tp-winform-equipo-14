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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
            Text = "Agregar Categoria";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txbDescripcion.Text;
                CategoriaServer categoriaNegocio = new CategoriaServer();
                Categoria aux = categoriaNegocio.buscarPorDescripcion(descripcion);
                if (aux != null)
                {
                    lblNuevaMarca.Text = $"Ya existe una categoria con el nombre '{descripcion}'";
                    lblNuevaMarca.ForeColor = Color.Red;
                    return;
                }
                if (descripcion == "")
                {
                    MessageBox.Show("No se puede guardar una Categoria vacía");
                }
                else
                {
                    int ok = categoriaNegocio.guardar(descripcion);
                    if (ok == -1)
                    {
                        lblNuevaMarca.Text = $"No se pudo guardar la categoria '{descripcion}'";
                        lblNuevaMarca.ForeColor = Color.Red;
                        MessageBox.Show("No se pudo guardar la categoria!");
                        return;
                    }

                    lblNuevaMarca.ForeColor = Color.Green;
                    lblNuevaMarca.Text = "Categoria guardada correctamente!";
                    MessageBox.Show("Categoria guardada correctamente!");
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return;
            }
        }
    }
}
