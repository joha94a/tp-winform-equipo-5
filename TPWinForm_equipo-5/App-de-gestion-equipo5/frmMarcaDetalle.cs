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
    public partial class frmMarcaDetalle : Form
    {
        private Marca marca = null;
        private bool soloLectura = false;

        public frmMarcaDetalle()
        {
            InitializeComponent();
        }

        public frmMarcaDetalle(Marca m, bool soloLectura)
        {
            InitializeComponent();
            this.marca = m;
            this.soloLectura = soloLectura;
        }

        private void frmMarcaDetalle_Load(object sender, EventArgs e)
        {
            if (soloLectura)
            {
                lblTitulo.Text = "MARCA - VER";
                txtDescripcion.ReadOnly = true;
                btnCancelar.Visible = false;
            }
            else if (this.marca != null)
            {
                lblTitulo.Text = "MARCA - MODIFICAR";
            }
            else
            {
                lblTitulo.Text = "MARCA - AGREGAR";
            }

            if (this.marca != null)
            {
                txtDescripcion.Text = marca.Descripcion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (soloLectura)
            {
                this.Close();
                return;
            }

            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                    marca = new Marca();
                marca.Descripcion = txtDescripcion.Text;

                if (marca.Id != 0)
                {
                    if (validarCarga(marca,false))
                        return;
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado exitosamente.");
                }
                else
                {
                    if (validarCarga(marca,true))
                        return;
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado exitosamente.");
                }
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool validarCarga(Marca marca, bool insert)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion.");
                return true;
            }
            MarcaNegocio negocio = new MarcaNegocio();
            
            if (insert && negocio.validarExistencia(marca.Descripcion).Count > 0)
            {
                MessageBox.Show("Descripcion existente.");
                return true;
            }

            if (!(insert) && negocio.validarExistencia(marca.Descripcion, marca.Id).Count > 0)
            {
                MessageBox.Show("Descripcion existente.");
                return true;
            }

            return false;
        }
    }
}
