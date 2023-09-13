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
    public partial class frmArticuloAgregar : Form
    {
        public frmArticuloAgregar()
        {
            InitializeComponent();
        }

        private void frmArticuloAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try 
            {
                cb_categoria.DataSource = categoriaNegocio.GetAll();
                cb_marca.DataSource = marcaNegocio.listar();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_agregar_art_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try 
            {
                articulo.Codigo = textBox_codigo.Text;
                articulo.Nombre = textBox_nombre.Text;
                articulo.Descripcion = textBox_descrip.Text;
                articulo.Categoria = (Categoria) cb_categoria.SelectedItem;
                articulo.Marca = (Marca) cb_marca.SelectedItem;
                articulo.Precio = decimal.Parse(textBox_precio.Text);

                articuloNegocio.agregar(articulo);
                MessageBox.Show("Artículo agregado exitosamente");
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
