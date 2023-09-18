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
        Articulos seleccionado;
        private int countPic;
        int cantidadImagenes;

        private void mostrarDetalle(Articulos A)
        {
            MessageBox.Show(A.ToString());
        }

        public Form1()
        {
            InitializeComponent();
            this.countPic = 0;
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
            cantidadImagenes = seleccionado.Imagen.Count;
            lblFotos.Text = "Foto " + (countPic + 1) + " / " + cantidadImagenes;
            dgvArticulos.Columns["ID"].Visible = false;
            if (cantidadImagenes > 1)
            {
                btnFotoDer.Visible = true;
                btnFotoIzq.Visible = true;
            }
            else
            {
                btnFotoDer.Visible = false;
                btnFotoIzq.Visible = false;
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

            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            countPic = 0;
            cantidadImagenes = seleccionado.Imagen.Count;
            if (seleccionado.Imagen.Count != 0)
            {

                if (cantidadImagenes > 1)
                {
                    btnFotoDer.Visible = true;
                    btnFotoIzq.Visible = true;
                }
                else
                {
                    btnFotoDer.Visible = false;
                    btnFotoIzq.Visible = false;
                }
                cargarImagen(seleccionado.Imagen.First().UrlImagen);
                lblFotos.Text = "Foto " + (countPic + 1) + " / " + seleccionado.Imagen.Count;
            }
            else
            {
                cargarImagen("asd");
                lblFotos.Text = "Foto 0 / 0";
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

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbxArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
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

        private void btnFotoIzq_Click(object sender, EventArgs e)
        {
            int cantImagenes = seleccionado.Imagen.Count;
            if (cantImagenes > 0)
            {
                if (countPic > 0) countPic--;
                else if (countPic == 0)
                    countPic = cantImagenes - 1;

                lblFotos.Text = "Foto " + (countPic + 1) + " / " + seleccionado.Imagen.Count;
                cargarImagen(seleccionado.Imagen[countPic].UrlImagen);
            }
            else
            {
                cargarImagen("asd");
                lblFotos.Text = "Foto 0 / 0";
            }
        }

        private void btnFotoDer_Click(object sender, EventArgs e)
        {
            int cantImagenes = seleccionado.Imagen.Count;
            if (cantImagenes > 0)
            {
                if (countPic < cantImagenes - 1)
                    countPic++;
                else
                    countPic = 0;

                lblFotos.Text = "Foto " + (countPic + 1) + " / " + seleccionado.Imagen.Count;
                if (seleccionado.Imagen.Count > 0)
                    cargarImagen(seleccionado.Imagen[countPic].UrlImagen);
            }
            else
            {
                cargarImagen("asd");
                lblFotos.Text = "Foto 0 / 0";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo agregarArticulo = new AgregarArticulo();
            agregarArticulo.ShowDialog();
            Form1_Load(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            ModificarArticulo modificarArticulo = new ModificarArticulo(seleccionado);
            modificarArticulo.ShowDialog();
            Form1_Load(sender, e);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            EliminarArticulo eliminarArticulo = new EliminarArticulo(seleccionado);
            eliminarArticulo.ShowDialog();
            Form1_Load(sender, e);
        }

        private void btnDetalleArticulo_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            DetalleArticulo detalleArticulo = new DetalleArticulo(seleccionado);
            detalleArticulo.ShowDialog();
        }
    }
}
