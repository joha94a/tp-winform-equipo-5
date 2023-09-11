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
    public partial class CRUDCategoriaView : Form
    {
        private Categoria obj = new Categoria();
        public CRUDCategoriaView()
        {
            InitializeComponent();
        }
        public CRUDCategoriaView(Categoria obj)
        {
            InitializeComponent();
            this.obj = obj;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;

            if(string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("El campo 'Descripción' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoriaNegocio negocio = new CategoriaNegocio();

            obj.Descripcion = txtDescripcion.Text;
            bool guardo = negocio.Save(obj);

            if(guardo)
            {
                MessageBox.Show("Guardado Exitoso.", "Éxito");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar los datos.", "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = obj.Descripcion;
        }

        private void CRUDCategoriaView_Load(object sender, EventArgs e)
        {
            if(obj != null)
            {
                txtDescripcion.Text = obj.Descripcion;
            }
        }
    }
}
