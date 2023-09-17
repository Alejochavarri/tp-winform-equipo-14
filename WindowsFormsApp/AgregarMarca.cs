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
    public partial class AgregarMarca : Form
    {
        public AgregarMarca()
        {
            InitializeComponent();
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = txbDescripcion.Text;
                MarcaServer marcaNegocio = new MarcaServer();
                Marca aux = marcaNegocio.buscarPorDescripcion(descripcion);
                if (aux != null)
                {
                    lblNuevaMarca.Text = $"Ya existe una marca con el nombre '{descripcion}'";
                    lblNuevaMarca.ForeColor = Color.Red;
                    return;
                }


                if (descripcion == "")
                {
                    MessageBox.Show("No se puede guardar una Marca vacía");
                }
                else
                {
                    int ok = marcaNegocio.guardar(descripcion);
                    if (ok == -1)
                    {
                        lblNuevaMarca.Text = $"No se pudo guardar la marca '{descripcion}'";
                        MessageBox.Show("No se pudo guardar la marca!");
                        lblNuevaMarca.ForeColor = Color.Red;
                        return;
                    }
                    lblNuevaMarca.ForeColor = Color.Green;
                    lblNuevaMarca.Text = "Marca guardada correctamente!";
                    MessageBox.Show("Marca guardada correctamente!");
                    this.Close();
                }


            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar la marca!");
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
