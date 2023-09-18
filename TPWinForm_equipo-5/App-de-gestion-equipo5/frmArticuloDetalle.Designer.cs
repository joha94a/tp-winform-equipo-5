namespace App_de_gestion_equipo5
{
    partial class frmArticuloDetalle
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
            this.nombre_articulo = new System.Windows.Forms.Label();
            this.marca_articulo = new System.Windows.Forms.Label();
            this.categoria_articulo = new System.Windows.Forms.Label();
            this.descripcion_articulo = new System.Windows.Forms.Label();
            this.precio_articulo = new System.Windows.Forms.Label();
            this.pictureBox_articulo = new System.Windows.Forms.PictureBox();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button_siguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_articulo)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_articulo
            // 
            this.nombre_articulo.AutoSize = true;
            this.nombre_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_articulo.Location = new System.Drawing.Point(117, 31);
            this.nombre_articulo.Name = "nombre_articulo";
            this.nombre_articulo.Size = new System.Drawing.Size(111, 31);
            this.nombre_articulo.TabIndex = 0;
            this.nombre_articulo.Text = "nombre";
            // 
            // marca_articulo
            // 
            this.marca_articulo.AutoSize = true;
            this.marca_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_articulo.Location = new System.Drawing.Point(33, 122);
            this.marca_articulo.Name = "marca_articulo";
            this.marca_articulo.Size = new System.Drawing.Size(45, 16);
            this.marca_articulo.TabIndex = 1;
            this.marca_articulo.Text = "marca";
            // 
            // categoria_articulo
            // 
            this.categoria_articulo.AutoSize = true;
            this.categoria_articulo.Location = new System.Drawing.Point(27, 9);
            this.categoria_articulo.Name = "categoria_articulo";
            this.categoria_articulo.Size = new System.Drawing.Size(51, 13);
            this.categoria_articulo.TabIndex = 2;
            this.categoria_articulo.Text = "categoria";
            // 
            // descripcion_articulo
            // 
            this.descripcion_articulo.AutoSize = true;
            this.descripcion_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_articulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.descripcion_articulo.Location = new System.Drawing.Point(27, 190);
            this.descripcion_articulo.Name = "descripcion_articulo";
            this.descripcion_articulo.Size = new System.Drawing.Size(77, 16);
            this.descripcion_articulo.TabIndex = 3;
            this.descripcion_articulo.Text = "descripcion";
            // 
            // precio_articulo
            // 
            this.precio_articulo.AutoSize = true;
            this.precio_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio_articulo.ForeColor = System.Drawing.Color.ForestGreen;
            this.precio_articulo.Location = new System.Drawing.Point(26, 388);
            this.precio_articulo.Name = "precio_articulo";
            this.precio_articulo.Size = new System.Drawing.Size(69, 24);
            this.precio_articulo.TabIndex = 4;
            this.precio_articulo.Text = "precio";
            // 
            // pictureBox_articulo
            // 
            this.pictureBox_articulo.Location = new System.Drawing.Point(334, 89);
            this.pictureBox_articulo.Name = "pictureBox_articulo";
            this.pictureBox_articulo.Size = new System.Drawing.Size(274, 257);
            this.pictureBox_articulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_articulo.TabIndex = 5;
            this.pictureBox_articulo.TabStop = false;
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(30, 209);
            this.textBox_descripcion.Multiline = true;
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.ReadOnly = true;
            this.textBox_descripcion.Size = new System.Drawing.Size(233, 119);
            this.textBox_descripcion.TabIndex = 6;
            // 
            // button_cerrar
            // 
            this.button_cerrar.BackColor = System.Drawing.Color.IndianRed;
            this.button_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cerrar.ForeColor = System.Drawing.Color.White;
            this.button_cerrar.Location = new System.Drawing.Point(541, 388);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(100, 40);
            this.button_cerrar.TabIndex = 7;
            this.button_cerrar.Text = "CERRAR";
            this.button_cerrar.UseVisualStyleBackColor = false;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // button_siguiente
            // 
            this.button_siguiente.BackColor = System.Drawing.Color.YellowGreen;
            this.button_siguiente.Location = new System.Drawing.Point(614, 209);
            this.button_siguiente.Name = "button_siguiente";
            this.button_siguiente.Size = new System.Drawing.Size(36, 38);
            this.button_siguiente.TabIndex = 8;
            this.button_siguiente.Text = ">";
            this.button_siguiente.UseVisualStyleBackColor = false;
            this.button_siguiente.Visible = false;
            this.button_siguiente.Click += new System.EventHandler(this.button_siguiente_Click);
            // 
            // frmArticuloDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.button_siguiente);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.pictureBox_articulo);
            this.Controls.Add(this.precio_articulo);
            this.Controls.Add(this.descripcion_articulo);
            this.Controls.Add(this.categoria_articulo);
            this.Controls.Add(this.marca_articulo);
            this.Controls.Add(this.nombre_articulo);
            this.Name = "frmArticuloDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticuloDetalle";
            this.Load += new System.EventHandler(this.frmArticuloDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_articulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre_articulo;
        private System.Windows.Forms.Label marca_articulo;
        private System.Windows.Forms.Label categoria_articulo;
        private System.Windows.Forms.Label descripcion_articulo;
        private System.Windows.Forms.Label precio_articulo;
        private System.Windows.Forms.PictureBox pictureBox_articulo;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.Button button_siguiente;
    }
}