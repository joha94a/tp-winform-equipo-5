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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_articulos)).BeginInit();
            this.panel_titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cerrar.ForeColor = System.Drawing.Color.White;
            this.button_cerrar.Location = new System.Drawing.Point(580, 378);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(100, 42);
            this.button_cerrar.TabIndex = 0;
            this.button_cerrar.Text = "VOLVER";
            this.button_cerrar.UseVisualStyleBackColor = false;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dataGridV_articulos
            // 
            this.dataGridV_articulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridV_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV_articulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridV_articulos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridV_articulos.Location = new System.Drawing.Point(54, 168);
            this.dataGridV_articulos.MultiSelect = false;
            this.dataGridV_articulos.Name = "dataGridV_articulos";
            this.dataGridV_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridV_articulos.Size = new System.Drawing.Size(545, 186);
            this.dataGridV_articulos.TabIndex = 1;
            // 
            // button_detalles
            // 
            this.button_detalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_detalles.ForeColor = System.Drawing.Color.White;
            this.button_detalles.Location = new System.Drawing.Point(54, 378);
            this.button_detalles.Name = "button_detalles";
            this.button_detalles.Size = new System.Drawing.Size(100, 42);
            this.button_detalles.TabIndex = 2;
            this.button_detalles.Text = "VER";
            this.button_detalles.UseVisualStyleBackColor = false;
            // 
            // button_modificar
            // 
            this.button_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modificar.ForeColor = System.Drawing.Color.White;
            this.button_modificar.Location = new System.Drawing.Point(170, 378);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(100, 42);
            this.button_modificar.TabIndex = 3;
            this.button_modificar.Text = "MODIFICAR";
            this.button_modificar.UseVisualStyleBackColor = false;
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.Tomato;
            this.button_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(459, 378);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(100, 42);
            this.button_eliminar.TabIndex = 4;
            this.button_eliminar.Text = "ELIMINAR";
            this.button_eliminar.UseVisualStyleBackColor = false;
            // 
            // panel_titulo
            // 
            this.panel_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel_titulo.Controls.Add(this.label_titulo);
            this.panel_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titulo.Location = new System.Drawing.Point(0, 0);
            this.panel_titulo.Name = "panel_titulo";
            this.panel_titulo.Size = new System.Drawing.Size(702, 100);
            this.panel_titulo.TabIndex = 5;
            // 
            // label_titulo
            // 
            this.label_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_titulo.ForeColor = System.Drawing.Color.White;
            this.label_titulo.Location = new System.Drawing.Point(265, 39);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(137, 26);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "ARTÍCULOS";
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(54, 118);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(100, 42);
            this.button_agregar.TabIndex = 6;
            this.button_agregar.Text = "AGREGAR";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // Ventana_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 441);
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
            this.ResumeLayout(false);

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
    }
}