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
    public partial class ModificarMarca : Form
    {
        public ModificarMarca()
        {
            InitializeComponent();
        }
        private Marca marca;
        private MarcaServer marcaServer;

        public ModificarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca " + marca.Descripcion;
            this.marcaServer = new MarcaServer();
        }

        private void ModificarMarca_Load(object sender, EventArgs e)
        {
            lblMarcaTitulo.Text = "ID " + marca.Id + " " + marca.Descripcion;

        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = tbxNombreMarca.Text;
                int idMarca = marca.Id;
                if (descripcion == "")
                {
                    MessageBox.Show("No se puede guardar una Marca vacía");
                }
                else
                {
                    int rowsAffected = marcaServer.modificar(descripcion, idMarca);
                    if (rowsAffected != 1)
                    {
                        MessageBox.Show("Algo paso al intentar modificar la marca");
                        return;
                    }
                    MessageBox.Show("Marca modificada correctamente");
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
