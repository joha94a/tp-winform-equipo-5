using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_de_gestion_equipo5
{
    public partial class SearchCategoriaView : Form
    {
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
            dgvCategoria.DataSource = negocio.GetAll();
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
            Categoria cat;
            cat = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

            CRUDCategoriaView view = new CRUDCategoriaView(cat);
            view.ShowDialog();
            LoadGrid();
        }
    }
}
