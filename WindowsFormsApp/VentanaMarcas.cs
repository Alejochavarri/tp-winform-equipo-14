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
    }
}
