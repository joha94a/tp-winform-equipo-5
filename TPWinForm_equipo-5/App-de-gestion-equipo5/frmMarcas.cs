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
            List<Marca> marcasFiltradas;
            string filtro = txtDescripcion.Text;

            if(filtro != "")
            {
                marcasFiltradas = listaMarcas.FindAll(marca => marca.descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                marcasFiltradas = listaMarcas;
            }
            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = marcasFiltradas;
            ocultarColumnas();
        }
    }
}
