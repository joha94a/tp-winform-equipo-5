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
using static System.Net.Mime.MediaTypeNames;

namespace App_de_gestion_equipo5
{
    public partial class frmImagenAgregar : Form
    {
        Articulo articulo;

        public frmImagenAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ImagenNegocio negocio = new ImagenNegocio();
            try
            {
                Imagen imagen = new Imagen();
                imagen.ImagenUrl = txtImagenUrl.Text;
                pbxImagen.Load(imagen.ImagenUrl);
                negocio.agregar(imagen, articulo);
                MessageBox.Show("Imagen agregada existosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                pbxImagen.Image = null;
                MessageBox.Show("No se pudo cargar la imagen");
            }
        }

        private void btnPrevizualizar_Click(object sender, EventArgs e)
        {
            try
            {
                pbxImagen.Load(txtImagenUrl.Text);
            }
            catch (Exception ex)
            {
                pbxImagen.Image = null;
                MessageBox.Show("No se pudo cargar la imagen");
            }
        }
    }
}
