﻿namespace App_de_gestion_equipo5
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridV_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // button_cerrar
            // 
            this.button_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cerrar.Location = new System.Drawing.Point(606, 266);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 0;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // dataGridV_articulos
            // 
            this.dataGridV_articulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridV_articulos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridV_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridV_articulos.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridV_articulos.Location = new System.Drawing.Point(54, 61);
            this.dataGridV_articulos.Name = "dataGridV_articulos";
            this.dataGridV_articulos.Size = new System.Drawing.Size(545, 147);
            this.dataGridV_articulos.TabIndex = 1;
            // 
            // button_detalles
            // 
            this.button_detalles.Location = new System.Drawing.Point(54, 12);
            this.button_detalles.Name = "button_detalles";
            this.button_detalles.Size = new System.Drawing.Size(75, 23);
            this.button_detalles.TabIndex = 2;
            this.button_detalles.Text = "Ver detalles";
            this.button_detalles.UseVisualStyleBackColor = true;
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(145, 12);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 3;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(407, 12);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(75, 23);
            this.button_eliminar.TabIndex = 4;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            // 
            // Ventana_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 312);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.DataGridView dataGridV_articulos;
        private System.Windows.Forms.Button button_detalles;
        private System.Windows.Forms.Button button_modificar;
        private System.Windows.Forms.Button button_eliminar;
    }
}