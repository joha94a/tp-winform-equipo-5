﻿using Negocio;
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
    public partial class ventana_principal : Form
    {
        public ventana_principal()
        {
            InitializeComponent();
        }

        private void link_articulos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void panel_ventanas_ControlRemoved(object sender, ControlEventArgs e)
        {
            panel_menu.Enabled = true;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            SearchCategoriaView view = new SearchCategoriaView();
            //view.ShowDialog();
            view.TopLevel = false; // Esto permite que la ventana hija se comporte como un control
            view.Dock = DockStyle.Fill; // Estira la ventana hija para llenar el Panel
            panel_ventanas.Controls.Add(view); // Agrega la ventana hija al Panel
            //ventana_art.MdiParent = this;
            view.Show();
            panel_menu.Enabled = false;
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas formMarcas = new frmMarcas();
            formMarcas.TopLevel = false;
            formMarcas.Dock = DockStyle.Fill;
            panel_ventanas.Controls.Add(formMarcas);
            formMarcas.Show();
            panel_menu.Enabled = false;
        }

        private void button_articulos_Click(object sender, EventArgs e)
        {
            Ventana_Articulos ventana_art = new Ventana_Articulos();
            ventana_art.TopLevel = false; // Esto permite que la ventana hija se comporte como un control
            ventana_art.Dock = DockStyle.Fill; // Estira la ventana hija para llenar el Panel
            panel_ventanas.Controls.Add(ventana_art); // Agrega la ventana hija al Panel
            ventana_art.Show();
            panel_menu.Enabled = false;
        }
    }
}
