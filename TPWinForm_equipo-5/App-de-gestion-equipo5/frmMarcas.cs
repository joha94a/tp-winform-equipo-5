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
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarcas;

        public frmMarcas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarMarcas()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarcas = negocio.listar();
            dgvMarcas.DataSource = listaMarcas;
            dgvMarcas.ClearSelection();
            ocultarColumnas();
        }

        private void filtrarMarcas()
        {
            List<Marca> marcasFiltradas;
            string filtro = txtDescripcion.Text;

            if (filtro != "")
            {
                marcasFiltradas = listaMarcas.FindAll(marca => marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                marcasFiltradas = listaMarcas;
            }
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = marcasFiltradas;
            dgvMarcas.ClearSelection();
            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            filtrarMarcas();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            verMarca();
        }

        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            verMarca();
        }

        private void verMarca()
        {
            if(dgvMarcas.CurrentRow != null)
            {
                Marca m = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                frmMarcaDetalle frmDetalle = new frmMarcaDetalle(m,true);
                frmDetalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.CurrentRow != null)
            {
                Marca m = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                frmMarcaDetalle frmDetalle = new frmMarcaDetalle(m, false);
                frmDetalle.ShowDialog();
                cargarMarcas();
                filtrarMarcas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmMarcaDetalle frmDetalle = new frmMarcaDetalle();
            frmDetalle.ShowDialog();
            cargarMarcas();
            filtrarMarcas();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca marca;
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();
            List<Articulo> listaArticulos;
            try
            {
                if (dgvMarcas.CurrentRow != null)
                {
                    marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    listaArticulos = negocioArticulo.listarPorMarca(marca);
                    if(listaArticulos.Count == 0)
                    {
                        DialogResult respuesta = MessageBox.Show("Está seguro que desea eliminar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.eliminar(marca.Id);
                            MessageBox.Show("Marca eliminada exitosamente.");
                            cargarMarcas();
                            filtrarMarcas();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Imposible eliminar, existen articulos con la marca seleccionada.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
