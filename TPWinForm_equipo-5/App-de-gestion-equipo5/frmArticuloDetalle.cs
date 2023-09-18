using Dominio;
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
    public partial class frmArticuloDetalle : Form
    {
        private Articulo articulo = null;
        private int IndiceActual = -1;
        private int indiceMaximo = -1;
        public frmArticuloDetalle()
        {
            InitializeComponent();
        }

        public frmArticuloDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmArticuloDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                if (articulo != null)
                {
                    nombre_articulo.Text = articulo.Nombre;
                    textBox_descripcion.Text = articulo.Descripcion;
                    precio_articulo.Text = "$" + articulo.Precio.ToString();
                    categoria_articulo.Text = "Categoria: " + articulo.Categoria.Descripcion.ToString();
                    marca_articulo.Text = "Marca: " + articulo.Marca.Descripcion.ToString();
                }

                if (articulo.Imagenes.Count >= 0)
                {
                    cargarImagen(0);

                    if(articulo.Imagenes.Count > 1)
                    {
                        button_siguiente.Visible = true;
                        indiceMaximo = (articulo.Imagenes.Count) - 1;
                    }
                    else
                    {
                        button_siguiente.Visible = false;
                    }
                    this.IndiceActual = 0;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_siguiente_Click(object sender, EventArgs e)
        {
            if(this.IndiceActual == indiceMaximo)
            {
                this.IndiceActual = 0;
                cargarImagen(this.IndiceActual);
            }
            else if (this.IndiceActual < indiceMaximo)
            {
                this.IndiceActual++;
                cargarImagen(IndiceActual);
            }
            
        }

        private void cargarImagen(int indice)
        {
            pictureBox_articulo.Load(articulo.Imagenes[indice].ImagenUrl);
        }
    }
}
