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

        private void mostrarDetalle (Articulos A)
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
            Listarticulos = DB.listar();
            dgbArticulos.DataSource = Listarticulos;
            
            
        }

        private void verCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloServer DB = new ArticuloServer();
            Listarticulos = DB.listar();
            dgbArticulos.DataSource = Listarticulos;
        }

        private void dgbArticulos_DoubleClick(object sender, EventArgs e)
        {
            Articulos A;
            A = (Articulos)dgbArticulos.CurrentRow.DataBoundItem;
            MessageBox.Show(A.ToString());
        }

        private void dgbArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulos A;
            A = (Articulos)dgbArticulos.CurrentRow.DataBoundItem;
            pictureBox1.Load(A.linkImagen);
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
    }
}
