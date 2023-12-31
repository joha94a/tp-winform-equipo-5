﻿using Dominio;
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
                    if (articulo.Categoria != null)
                        cb_categoria.SelectedValue = articulo.Categoria.Id;
                    else
                        cb_categoria.SelectedIndex = -1;
                    if (articulo.Marca != null)
                        cb_marca.SelectedValue = articulo.Marca.Id;
                    else
                        cb_marca.SelectedIndex = -1;
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

                if (validarCampos())
                    return;

                articulo.Codigo = textBox_codigo.Text;
                articulo.Nombre = textBox_nombre.Text;
                articulo.Descripcion = textBox_descrip.Text;
                articulo.Categoria = (Categoria) cb_categoria.SelectedItem;
                articulo.Marca = (Marca) cb_marca.SelectedItem;

                articulo.Precio = decimal.Parse(textBox_precio.Text);


                if (agregar)
                {
                    bool validacion = articuloNegocio.validarCodigo(articulo.Codigo);
                    if (!validacion) { MessageBox.Show("No se puede repetir el código"); return; }
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Artículo agregado exitosamente");
                }
                else
                {
                    bool validacion = articuloNegocio.validarCodigo(articulo.Codigo);
                    if (!validacion) { MessageBox.Show("No se puede repetir el código"); return; }
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

        private bool validarCampos()
        {
            if (textBox_codigo.Text == "")
            {
                MessageBox.Show("Debe completar el codigo");
                return true;
            }
            if (textBox_nombre.Text == "")
            {
                MessageBox.Show("Debe completar el nombre del articulo");
                return true;
            }
            if (textBox_precio.Text == "")
            {
                MessageBox.Show("Se debe ingresar un valor");
                return true;
            }
            if (!decimal.TryParse(textBox_precio.Text, out decimal d))
            {
                MessageBox.Show("Se debe ingresar un valor numérico en el precio");
                return true;
            }

            return false;
        }
    }
}
