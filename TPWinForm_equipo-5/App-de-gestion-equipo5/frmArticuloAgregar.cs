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

        private Articulo articulo = null;

        public frmArticuloAgregar()
        {
            InitializeComponent();
        }

        public frmArticuloAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar artículo";
            
        }

        private void frmArticuloAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try 
            {
                cb_categoria.DataSource = categoriaNegocio.GetAll();
                cb_categoria.ValueMember = "Id";
                cb_categoria.DisplayMember = "Descripcion";
                cb_marca.DataSource = marcaNegocio.listar();
                cb_marca.ValueMember = "Id";
                cb_marca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    textBox_codigo.Text = articulo.Codigo;
                    textBox_nombre.Text = articulo.Nombre;
                    textBox_descrip.Text = articulo.Descripcion;
                    cb_categoria.SelectedValue = articulo.Categoria.Id;
                    cb_marca.SelectedValue = articulo.Marca.Id;
                    textBox_precio.Text = articulo.Precio.ToString();

                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_agregar_art_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            bool agregar = false;

            try 
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                    agregar = true;
                }

                articulo.Codigo = textBox_codigo.Text;
                articulo.Nombre = textBox_nombre.Text;
                articulo.Descripcion = textBox_descrip.Text;
                articulo.Categoria = (Categoria) cb_categoria.SelectedItem;
                articulo.Marca = (Marca) cb_marca.SelectedItem;
                articulo.Precio = decimal.Parse(textBox_precio.Text);

                if (agregar)
                {
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Artículo agregado exitosamente");
                }
                else
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Artículo modificado exitosamente");
                }

                agregar = false;
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
