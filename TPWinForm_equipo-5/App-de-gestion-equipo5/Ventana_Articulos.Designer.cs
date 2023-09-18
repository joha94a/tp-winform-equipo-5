namespace App_de_gestion_equipo5
{
    partial class Ventana_Articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_cerrar = new System.Windows.Forms.Button();
            this.dataGridV_articulos = new System.Windows.Forms.DataGridView();
            this.button_detalles = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.panel_titulo = new System.Windows.Forms.Panel();
            this.label_titulo = new System.Windows.Forms.Label();
            this.button_agregar = new System.Windows.Forms.Button();
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.label_filtrar = new System.Windows.Forms.Label();
            this.cb_filtro_campo = new System.Windows.Forms.ComboBox();
            this.cb_filtro_criterio = new System.Windows.Forms.ComboBox();
            this.textBox_filtro = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label_cod_precio = new System.Windows.Forms.Label();
            this.button_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_articulos)).BeginInit();
            this.panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cerrar.ForeColor = System.Drawing.Color.White;
            this.button_cerrar.Location = new System.Drawing.Point(973, 725);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(100, 42);
            this.button_cerrar.TabIndex = 0;
            this.button_cerrar.Text = "VOLVER";
            this.button_cerrar.UseVisualStyleBackColor = false;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dataGridV_articulos
            // 
            this.dataGridV_articulos.AllowUserToResizeRows = false;
            this.dataGridV_articulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridV_articulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridV_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV_articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridV_articulos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridV_articulos.Location = new System.Drawing.Point(54, 168);
            this.dataGridV_articulos.MultiSelect = false;
            this.dataGridV_articulos.Name = "dataGridV_articulos";
            this.dataGridV_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridV_articulos.Size = new System.Drawing.Size(663, 551);
            this.dataGridV_articulos.TabIndex = 1;
            this.dataGridV_articulos.SelectionChanged += new System.EventHandler(this.dataGridV_articulos_SelectionChanged);
            // 
            // button_detalles
            // 
            this.button_detalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_detalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_detalles.ForeColor = System.Drawing.Color.White;
            this.button_detalles.Location = new System.Drawing.Point(54, 725);
            this.button_detalles.Name = "button_detalles";
            this.button_detalles.Size = new System.Drawing.Size(100, 42);
            this.button_detalles.TabIndex = 2;
            this.button_detalles.Text = "VER";
            this.button_detalles.UseVisualStyleBackColor = false;
            this.button_detalles.Click += new System.EventHandler(this.button_detalles_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.ForeColor = System.Drawing.Color.White;
            this.button_modificar.Location = new System.Drawing.Point(171, 725);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(100, 42);
            this.button_modificar.TabIndex = 3;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = false;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_eliminar.BackColor = System.Drawing.Color.Tomato;
            this.button_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(617, 725);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(100, 42);
            this.button_eliminar.TabIndex = 4;
            this.button_eliminar.Text = "ELIMINAR";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel_titulo.Controls.Add(this.label_titulo);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(1095, 100);
            this.panel_titulo.TabIndex = 5;
            // 
            // label_titulo
            // 
            this.label_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_titulo.ForeColor = System.Drawing.Color.White;
            this.label_titulo.Location = new System.Drawing.Point(461, 39);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(137, 26);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "ARTÍCULOS";
            // 
            // button_agregar
            // 
            this.button_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(466, 725);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(100, 42);
            this.button_agregar.TabIndex = 6;
            this.button_agregar.Text = "AGREGAR";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.AllowUserToResizeRows = false;
            this.dgvImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImagenes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvImagenes.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvImagenes.Location = new System.Drawing.Point(723, 556);
            this.dgvImagenes.MultiSelect = false;
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.RowHeadersVisible = false;
            this.dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImagenes.Size = new System.Drawing.Size(350, 163);
            this.dgvImagenes.TabIndex = 7;
            this.dgvImagenes.SelectionChanged += new System.EventHandler(this.dgvImagenes_SelectionChanged);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagen.Location = new System.Drawing.Point(723, 168);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(350, 350);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 8;
            this.pbxImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAgregarImagen.FlatAppearance.BorderSize = 0;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.Location = new System.Drawing.Point(723, 524);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(170, 26);
            this.btnAgregarImagen.TabIndex = 9;
            this.btnAgregarImagen.Text = "AGREGAR IMAGEN";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarImagen.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminarImagen.FlatAppearance.BorderSize = 0;
            this.btnEliminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarImagen.ForeColor = System.Drawing.Color.White;
            this.btnEliminarImagen.Location = new System.Drawing.Point(899, 524);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(174, 26);
            this.btnEliminarImagen.TabIndex = 10;
            this.btnEliminarImagen.Text = "ELIMINAR IMAGEN";
            this.btnEliminarImagen.UseVisualStyleBackColor = false;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // label_filtrar
            // 
            this.label_filtrar.AutoSize = true;
            this.label_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filtrar.Location = new System.Drawing.Point(51, 130);
            this.label_filtrar.Name = "label_filtrar";
            this.label_filtrar.Size = new System.Drawing.Size(69, 16);
            this.label_filtrar.TabIndex = 11;
            this.label_filtrar.Text = "Filtrar por: ";
            // 
            // cb_filtro_campo
            // 
            this.cb_filtro_campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro_campo.FormattingEnabled = true;
            this.cb_filtro_campo.Location = new System.Drawing.Point(132, 129);
            this.cb_filtro_campo.Name = "cb_filtro_campo";
            this.cb_filtro_campo.Size = new System.Drawing.Size(121, 21);
            this.cb_filtro_campo.TabIndex = 12;
            this.cb_filtro_campo.SelectedIndexChanged += new System.EventHandler(this.cb_filtro_campo_SelectedIndexChanged);
            // 
            // cb_filtro_criterio
            // 
            this.cb_filtro_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro_criterio.FormattingEnabled = true;
            this.cb_filtro_criterio.Location = new System.Drawing.Point(265, 130);
            this.cb_filtro_criterio.Name = "cb_filtro_criterio";
            this.cb_filtro_criterio.Size = new System.Drawing.Size(121, 21);
            this.cb_filtro_criterio.TabIndex = 13;
            this.cb_filtro_criterio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_filtro
            // 
            this.textBox_filtro.Enabled = false;
            this.textBox_filtro.Location = new System.Drawing.Point(452, 131);
            this.textBox_filtro.Name = "textBox_filtro";
            this.textBox_filtro.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtro.TabIndex = 14;
            // 
            // button_buscar
            // 
            this.button_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar.ForeColor = System.Drawing.Color.White;
            this.button_buscar.Location = new System.Drawing.Point(564, 127);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(86, 31);
            this.button_buscar.TabIndex = 15;
            this.button_buscar.Text = "BUSCAR";
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // label_cod_precio
            // 
            this.label_cod_precio.AutoSize = true;
            this.label_cod_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cod_precio.Location = new System.Drawing.Point(398, 132);
            this.label_cod_precio.Name = "label_cod_precio";
            this.label_cod_precio.Size = new System.Drawing.Size(42, 16);
            this.label_cod_precio.TabIndex = 16;
            this.label_cod_precio.Text = "Valor:";
            // 
            // button_limpiar
            // 
            this.button_limpiar.BackColor = System.Drawing.Color.Tomato;
            this.button_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpiar.ForeColor = System.Drawing.Color.White;
            this.button_limpiar.Location = new System.Drawing.Point(662, 127);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(86, 31);
            this.button_limpiar.TabIndex = 17;
            this.button_limpiar.Text = "LIMPIAR";
            this.button_limpiar.UseVisualStyleBackColor = false;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // Ventana_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 788);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.label_cod_precio);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.textBox_filtro);
            this.Controls.Add(this.cb_filtro_criterio);
            this.Controls.Add(this.cb_filtro_campo);
            this.Controls.Add(this.label_filtrar);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvImagenes);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.panel_titulo);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_detalles);
            this.Controls.Add(this.dataGridV_articulos);
            this.Controls.Add(this.button_cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana_Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ventana_Articulos";
            this.Load += new System.EventHandler(this.Ventana_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_articulos)).EndInit();
            this.panel_titulo.ResumeLayout(false);
            this.panel_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridV_articulos;
        private System.Windows.Forms.Button button_detalles;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Panel panel_titulo;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
        private System.Windows.Forms.Label label_filtrar;
        private System.Windows.Forms.ComboBox cb_filtro_campo;
        private System.Windows.Forms.ComboBox cb_filtro_criterio;
        private System.Windows.Forms.TextBox textBox_filtro;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label_cod_precio;
        private System.Windows.Forms.Button button_limpiar;
    }
}