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

namespace App_de_gestion_equipo5
{
    public partial class Ventana_Articulos : Form
    {
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
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            dataGridV_articulos.DataSource = articuloNegocio.listarArticulos();
            dataGridV_articulos.Columns["descripcion"].Visible = false;
            dataGridV_articulos.Columns["marca"].Visible = false;
            dataGridV_articulos.Columns["categoria"].Visible = false;

            dataGridV_articulos.Columns["precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            frmArticuloAgregar ventanaAgregar = new frmArticuloAgregar();
            ventanaAgregar.ShowDialog();

        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            Articulo articulo;
            articulo = (Articulo)dataGridV_articulos.CurrentRow.DataBoundItem;
            frmArticuloAgregar modificar = new frmArticuloAgregar(articulo);
            modificar.ShowDialog();


        }
    }
}
