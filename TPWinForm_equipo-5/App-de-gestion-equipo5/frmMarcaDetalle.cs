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
    public partial class frmMarcaDetalle : Form
    {
        private Marca marca = new Marca();

        public frmMarcaDetalle()
        {
            InitializeComponent();
        }

        public frmMarcaDetalle(Marca m)
        {
            InitializeComponent();
            this.marca = m;
        }

        private void frmMarcaDetalle_Load(object sender, EventArgs e)
        {
            txtDescripcion.Text = marca.Descripcion;
        }
    }
}
