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
        private List<Imagenes> ListaImagenes;
        int globalIndex = 0;
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
            imagenesServer DbI = new imagenesServer();
            ListaImagenes = DbI.listar();
            ArticuloServer DbA = new ArticuloServer();
            Listarticulos = DbA.listar();
            dgbArticulos.DataSource = Listarticulos;
            ocultarColumnas();
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoria");
            
        }

        private List<Imagenes> contarImagenes(int Id)
        {
            List<Imagenes> aux = new List<Imagenes>();
            foreach (Imagenes A in ListaImagenes)
            {
                if (A.IDArticulo == Id)
                {
                    aux.Add(A);
                }
            }
            return aux;
        }

        private void verCatalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgbArticulos.DataSource = null;
            dgbArticulos.DataSource = Listarticulos;
            ocultarColumnas();
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
            List<Imagenes> aux;
            globalIndex = 0;
            if (dgbArticulos.CurrentRow != null)
            {
                A = (Articulos)dgbArticulos.CurrentRow.DataBoundItem;
                aux = contarImagenes(A.ID);
                    try
                    {
                        pictureBox1.Load(aux[0].linkImagen); 
                    }
                    catch (Exception )
                    {
                        pictureBox1.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
                        //MessageBox.Show( ex.ToString());
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

        private void ocultarColumnas()
        {
            dgbArticulos.Columns["linkImagen"].Visible = false;
            dgbArticulos.Columns["ID"].Visible = false;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltrada;
            string filtro = txtBusqueda.Text;
            if(filtro.Length >= 2)
            {
                listaFiltrada = Listarticulos.FindAll(Obj => Obj.Nombre.ToUpper().Contains(filtro.ToUpper()) || Obj.Descripcion.ToUpper().Contains(filtro.ToUpper()) || Obj.Codigo.ToUpper().Contains(filtro.ToUpper()));
                
            }
            else
            {
                listaFiltrada = Listarticulos;
            }
            dgbArticulos.DataSource = null;
            dgbArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            switch (opcion)
            {
                case ("Precio"):
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Igual a");
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Menor a");
                    break;
                case ("Marca"):
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Samsung");
                    cboCriterio.Items.Add("Apple");
                    cboCriterio.Items.Add("Motorola");
                    cboCriterio.Items.Add("Huawei");
                    cboCriterio.Items.Add("Sony");
                    break;
                case ("Categoria"):
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Celulares");
                    cboCriterio.Items.Add("Televisores");
                    cboCriterio.Items.Add("Media");
                    cboCriterio.Items.Add("Audio");
                    break;

            }
        }

        private void btnBuscarA_Click(object sender, EventArgs e)
        {
            ArticuloServer lista = new ArticuloServer();
            try
            {
                string Filtro = txtFiltro.Text;
                string Campo = cboCampo.SelectedItem.ToString();
                string Criterio = cboCriterio.SelectedItem.ToString();
                dgbArticulos.DataSource = lista.filtrar(Campo,Criterio, Filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Articulos A;
            List<Imagenes> aux;
            if (dgbArticulos.CurrentRow != null)
            {
                A = (Articulos)dgbArticulos.CurrentRow.DataBoundItem;
                aux = contarImagenes(A.ID);
                globalIndex++;
                if (aux.Count > 1)
                {
                    try
                    {
                        pictureBox1.Load(aux[globalIndex].linkImagen);
                        
                    }
                    catch (Exception)
                    {
                        pictureBox1.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
                        //MessageBox.Show( ex.ToString());
                    }
                }
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Articulos A;
            List<Imagenes> aux;
            if (dgbArticulos.CurrentRow != null)
            {
                A = (Articulos)dgbArticulos.CurrentRow.DataBoundItem;
                aux = contarImagenes(A.ID);
                globalIndex--;
                if (aux.Count > 1)
                {
                    try
                    {
                        
                        pictureBox1.Load(aux[globalIndex].linkImagen);
                    }
                    catch (Exception)
                    {
                        pictureBox1.Load("https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-pagina-imagen-faltante-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-11093.jpg");
                        //MessageBox.Show( ex.ToString());
                    }
                }
            }
        }
    }
}
