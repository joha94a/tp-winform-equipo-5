namespace App_de_gestion_equipo5
{
    partial class ventana_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_ventanas = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_articulos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ventanas
            // 
            this.panel_ventanas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ventanas.Location = new System.Drawing.Point(207, 1);
            this.panel_ventanas.Name = "panel_ventanas";
            this.panel_ventanas.Size = new System.Drawing.Size(926, 679);
            this.panel_ventanas.TabIndex = 3;
            this.panel_ventanas.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel_ventanas_ControlRemoved);
            // 
            // panel_menu
            // 
            this.panel_menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_menu.Controls.Add(this.button_articulos);
            this.panel_menu.Controls.Add(this.btnMarcas);
            this.panel_menu.Controls.Add(this.btnCategoria);
            this.panel_menu.Location = new System.Drawing.Point(1, 1);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(206, 684);
            this.panel_menu.TabIndex = 4;
            // 
            // button_articulos
            // 
            this.button_articulos.BackColor = System.Drawing.Color.LightYellow;
            this.button_articulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_articulos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_articulos.FlatAppearance.BorderSize = 0;
            this.button_articulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_articulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_articulos.Location = new System.Drawing.Point(0, 46);
            this.button_articulos.Name = "button_articulos";
            this.button_articulos.Size = new System.Drawing.Size(207, 43);
            this.button_articulos.TabIndex = 3;
            this.button_articulos.Text = "ARTÍCULOS";
            this.button_articulos.UseVisualStyleBackColor = false;
            this.button_articulos.Click += new System.EventHandler(this.button_articulos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.LightYellow;
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(0, 178);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(207, 43);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "MARCAS";
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.LightYellow;
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(0, 115);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(207, 43);
            this.btnCategoria.TabIndex = 1;
            this.btnCategoria.Text = "CATEGORÍAS";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // ventana_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1134, 681);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_ventanas);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1150, 720);
            this.Name = "ventana_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APP DE GESTION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_ventanas;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button button_articulos;
    }
}

