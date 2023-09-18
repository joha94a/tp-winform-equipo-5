using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_gestion_equipo5
{
    public partial class SearchCategoriaView : Form
    {
        private List<Categoria> listaCategorias;
        public SearchCategoriaView()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchCategoriaView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategorias = negocio.GetAll();
            dgvCategoria.DataSource = listaCategorias;
            dgvCategoria.Columns["Id"].Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUDCategoriaView view = new CRUDCategoriaView();
            view.ShowDialog();
            LoadGrid();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            CategoriaNavigate();
        }

        private void CategoriaNavigate()
        {
            if(dgvCategoria.CurrentRow != null)
            {
                Categoria cat = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

                CRUDCategoriaView view = new CRUDCategoriaView(cat);
                view.ShowDialog();
                LoadGrid();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Categoria cat;
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();
            List<Articulo> listaArticulos;
            try
            {
                if (dgvCategoria.CurrentRow != null)
                {
                    cat = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    listaArticulos = negocioArticulo.listarPorCategoria(cat);
                    if (listaArticulos.Count == 0)
                    {
                        DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            CategoriaNegocio negocio = new CategoriaNegocio();
                            negocio.Delete(cat);
                            LoadGrid();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Imposible eliminar, existen articulos con la categoria seleccionada.","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

            List<Categoria> categoriasFiltradas;
            string filtro = txtDescripcion.Text;

            if (filtro != "")
            {
                categoriasFiltradas = listaCategorias.FindAll(c => c.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                categoriasFiltradas = listaCategorias;
            }
            dgvCategoria.DataSource = categoriasFiltradas;
            dgvCategoria.Columns["Id"].Visible = false;
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriaNavigate();
        }
    }
}
