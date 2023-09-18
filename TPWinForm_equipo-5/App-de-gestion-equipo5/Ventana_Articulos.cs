using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_de_gestion_equipo5
{
    public partial class Ventana_Articulos : Form
    {
        // Agrego control de indices de DGV para evitar que se disparen los eventos 'SelectionChanged' muchas veces y que no haga lenta la app
        int indiceArticuloAnterior = -1;
        int indiceImagenAnterior = -1;

        public Ventana_Articulos()
        {
            InitializeComponent();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void Ventana_Articulos_Load(object sender, EventArgs e)
        {
            cargar();
            cb_filtro_campo.Items.Add("Código");
            cb_filtro_campo.Items.Add("Marca");
            cb_filtro_campo.Items.Add("Categoria");
            cb_filtro_campo.Items.Add("Precio");

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            frmArticuloAgregar ventanaAgregar = new frmArticuloAgregar();
            ventanaAgregar.ShowDialog();
            cargar();

        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            Articulo articulo;
            articulo = (Articulo)dataGridV_articulos.CurrentRow.DataBoundItem;
            frmArticuloAgregar modificar = new frmArticuloAgregar(articulo);
            modificar.ShowDialog();
            cargar();

        }

        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                dataGridV_articulos.DataSource = articuloNegocio.listarArticulos();
                dataGridV_articulos.Columns["descripcion"].Visible = false;
                dataGridV_articulos.Columns["marca"].Visible = false;
                dataGridV_articulos.Columns["categoria"].Visible = false;
                dataGridV_articulos.Columns["id"].Visible = false;


                dataGridV_articulos.Columns["precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dataGridV_articulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridV_articulos.CurrentRow != null && indiceArticuloAnterior != dataGridV_articulos.CurrentRow.Index)
            {
                indiceArticuloAnterior = dataGridV_articulos.CurrentRow.Index;
                Articulo articuloSeleccionado = (Articulo)dataGridV_articulos.CurrentRow.DataBoundItem;
                if (dgvImagenes.Rows.Count > 0)
                    dgvImagenes.CurrentCell = dgvImagenes.Rows[0].Cells[1];
                dgvImagenes.DataSource = null;

                indiceImagenAnterior = -1;
                dgvImagenes.DataSource = articuloSeleccionado.Imagenes;
                if (articuloSeleccionado.Imagenes.Count == 0)
                    pbxImagen.Image = null;
                indiceImagenAnterior = -1;

                dgvImagenes.Columns["Id"].Visible = false;
                dgvImagenes.Columns["ImagenUrl"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            Imagen imagen;
            try
            {
                if (dgvImagenes.CurrentRow != null && indiceImagenAnterior != dgvImagenes.CurrentRow.Index)
                {
                    indiceImagenAnterior = dgvImagenes.CurrentRow.Index;
                    imagen = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                    pbxImagen.Load(imagen.ImagenUrl);
                }
                else if (dgvImagenes.CurrentRow == null)
                    pbxImagen.Image = null;
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://png.pngtree.com/png-vector/20210604/ourmid/pngtree-gray-network-placeholder-png-image_3416659.jpg");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (dataGridV_articulos.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dataGridV_articulos.CurrentRow.DataBoundItem;
                frmImagenAgregar frmImagen = new frmImagenAgregar(articulo);
                frmImagen.ShowDialog();
                int indiceArticulos = dataGridV_articulos.CurrentRow.Index;
                int indiceImagen = -1;
                if (dgvImagenes.CurrentRow != null)
                    indiceImagen = dgvImagenes.CurrentRow.Index;
                cargar();
                dataGridV_articulos.CurrentCell = dataGridV_articulos.Rows[indiceArticulos].Cells[0];
                dataGridV_articulos_SelectionChanged(this, new EventArgs());
                if (indiceImagen >= 0)
                    dgvImagenes.CurrentCell = dgvImagenes.Rows[indiceImagen].Cells[1];
                dgvImagenes_SelectionChanged(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Debe seleccionar un articulo.");
            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridV_articulos.CurrentRow != null)
                {
                    if (dgvImagenes.CurrentRow != null)
                    {
                        ImagenNegocio negocio = new ImagenNegocio();
                        Imagen imagen = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                        DialogResult respuesta = MessageBox.Show("Está seguro que desea eliminar la imagen?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (respuesta == DialogResult.Yes)
                        {
                            negocio.eliminar(imagen.Id);
                            MessageBox.Show("Imagen eliminada exitosamente.");
                            int indiceArticulos = dataGridV_articulos.CurrentRow.Index;
                            cargar();
                            dataGridV_articulos.CurrentCell = dataGridV_articulos.Rows[indiceArticulos].Cells[0];
                            dataGridV_articulos_SelectionChanged(this, new EventArgs());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar una imagen.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un articulo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo articuloSeleccionado;
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro? Este registro se eliminará para siempre", "Elimiar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        articuloSeleccionado = (Articulo)dataGridV_articulos.CurrentRow.DataBoundItem;
                        imagenNegocio.eliminarTodas(articuloSeleccionado.Id);
                        articuloNegocio.eliminar(articuloSeleccionado.Id);
                        MessageBox.Show("Eliminado exitosamente");
                        cargar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

         }

        private void cb_filtro_campo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cb_filtro_campo.SelectedItem.ToString();
            List<Articulo> listaArticulos;
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            List<Categoria>listaCategorias = categoriaNegocio.GetAll();
            List<Marca> listaMarcas = marcaNegocio.listar();
            listaArticulos = articuloNegocio.listarArticulos();

            if (opcion == "Código")
            {
                cb_filtro_criterio.Items.Clear();
                textBox_filtro.Enabled = true;
                
            }
            else if(opcion == "Marca")
            {
                cb_filtro_criterio.Items.Clear();
                textBox_filtro.Enabled = false;
                textBox_filtro.Text = "";

                foreach (var item in listaMarcas)
                {
                    cb_filtro_criterio.Items.Add(item.Descripcion);
                }
            }
            else if (opcion == "Categoria")
            {
                cb_filtro_criterio.Items.Clear();
                //cb_filtro_criterio.SelectedIndex = 0;
                textBox_filtro.Enabled = false;
                textBox_filtro.Text = "";
                foreach (var item in listaCategorias)
                {
                    cb_filtro_criterio.Items.Add(item.Descripcion);
                }
            }
            else if (opcion == "Precio")
            {
                textBox_filtro.Enabled = true;
                cb_filtro_criterio.Items.Clear();
                cb_filtro_criterio.Items.Add("Igual a");
                cb_filtro_criterio.Items.Add("Menor a");
                cb_filtro_criterio.Items.Add("Mayor a");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                string campo = cb_filtro_campo.SelectedItem.ToString();
                if(campo == "Precio" && textBox_filtro.Text == "")
                {
                    MessageBox.Show("Se debe ingresar un valor");
                    return;
                }
                string criterio = null, valor = null;

                if(cb_filtro_criterio.SelectedItem == null)
                {
                    
                    criterio = "";
                }
                else
                {
                    criterio = cb_filtro_criterio.SelectedItem.ToString();
                }

                if(textBox_filtro.Text == null)
                {
                    valor = "";
                }
                else
                {
                    valor = textBox_filtro.Text;
                }
                
                dataGridV_articulos.DataSource = articuloNegocio.filtrar(campo, criterio, valor);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void button_detalles_Click(object sender, EventArgs e)
        {
            Articulo articulo;
            articulo = (Articulo)dataGridV_articulos.CurrentRow.DataBoundItem;
            frmArticuloDetalle detalle = new frmArticuloDetalle(articulo);
            detalle.ShowDialog();
        }
    }
}
