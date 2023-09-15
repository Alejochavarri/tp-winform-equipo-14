using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Server;
namespace WindowsFormsApp
{
    public partial class Form1 : Form

    {
        private List<Articulos> Listarticulos;

        private void mostrarDetalle(Articulos A)
        {
            MessageBox.Show(A.ToString());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloServer DB = new ArticuloServer();
            try
            {
                Listarticulos = DB.listar();
                dgvArticulos.DataSource = Listarticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }

        private void verCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloServer DB = new ArticuloServer();
            try
            {
                Listarticulos = DB.listar();
                dgvArticulos.DataSource = Listarticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvArticulos_DoubleClick(object sender, EventArgs e)
        {
            Articulos A;
            A = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            MessageBox.Show(A.ToString());
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulos A;
            if (dgvArticulos.CurrentRow != null)
            {
                A = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                try
                {
                    pictureBox1.Load(A.Imagen[0].UrlImagen);
                }
                catch (Exception ex)
                {
                    pictureBox1.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
                    //throw ex;
                }
            }


        }

        private void buscarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String Codigo = Microsoft.VisualBasic.Interaction.InputBox("Bucar", "Codigo de Articulo", "");
            Articulos A;
            bool flag = false;
            for (int i = 0; i < Listarticulos.Count(); i++)
            {
                A = Listarticulos[i];
                if (A.Codigo.Equals(Codigo))
                {
                    MessageBox.Show(A.ToString());
                    flag = true;
                }

            }
            if (!flag)
            {
                MessageBox.Show("No se encontro el articulo, reintente mas tarde ... ");
            }
        }





        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txtFiltro.Text;
            if (filtro.Length >= 2)
            {
                listaFiltrada = Listarticulos.FindAll(Obj => Obj.Nombre.ToUpper().Contains(filtro.ToUpper()) || Obj.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = Listarticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }


        private void marcasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Marcas ventanaMarcas = new Marcas();
            ventanaMarcas.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaCategorias ventanaCategorias = new VentanaCategorias();
            ventanaCategorias.ShowDialog();
        }
    }
}
