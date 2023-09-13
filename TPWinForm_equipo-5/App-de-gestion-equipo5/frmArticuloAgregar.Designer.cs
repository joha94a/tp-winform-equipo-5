namespace App_de_gestion_equipo5
{
    partial class frmArticuloAgregar
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
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            this.label_codigo = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.textBox_descrip = new System.Windows.Forms.TextBox();
            this.label_marca = new System.Windows.Forms.Label();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label_categoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.button_agregar_art = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(147, 79);
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(132, 20);
            this.textBox_codigo.TabIndex = 0;
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_codigo.Location = new System.Drawing.Point(45, 77);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(63, 20);
            this.label_codigo.TabIndex = 1;
            this.label_codigo.Text = "Código:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(304, 77);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(69, 20);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(391, 81);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(144, 20);
            this.textBox_nombre.TabIndex = 3;
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_descripcion.Location = new System.Drawing.Point(45, 134);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(96, 20);
            this.label_descripcion.TabIndex = 4;
            this.label_descripcion.Text = "Descripción:";
            // 
            // textBox_descrip
            // 
            this.textBox_descrip.Location = new System.Drawing.Point(147, 136);
            this.textBox_descrip.Name = "textBox_descrip";
            this.textBox_descrip.Size = new System.Drawing.Size(132, 20);
            this.textBox_descrip.TabIndex = 5;
            // 
            // label_marca
            // 
            this.label_marca.AutoSize = true;
            this.label_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_marca.Location = new System.Drawing.Point(45, 193);
            this.label_marca.Name = "label_marca";
            this.label_marca.Size = new System.Drawing.Size(57, 20);
            this.label_marca.TabIndex = 6;
            this.label_marca.Text = "Marca:";
            // 
            // cb_marca
            // 
            this.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(147, 195);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(132, 21);
            this.cb_marca.TabIndex = 7;
            // 
            // cb_categoria
            // 
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(391, 198);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(144, 21);
            this.cb_categoria.TabIndex = 8;
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_categoria.Location = new System.Drawing.Point(304, 196);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(82, 20);
            this.label_categoria.TabIndex = 9;
            this.label_categoria.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Precio:";
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(147, 252);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(132, 20);
            this.textBox_precio.TabIndex = 11;
            // 
            // button_agregar_art
            // 
            this.button_agregar_art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.button_agregar_art.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar_art.ForeColor = System.Drawing.Color.White;
            this.button_agregar_art.Location = new System.Drawing.Point(49, 346);
            this.button_agregar_art.Name = "button_agregar_art";
            this.button_agregar_art.Size = new System.Drawing.Size(100, 42);
            this.button_agregar_art.TabIndex = 12;
            this.button_agregar_art.Text = "AGREGAR";
            this.button_agregar_art.UseVisualStyleBackColor = false;
            this.button_agregar_art.Click += new System.EventHandler(this.button_agregar_art_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.Color.Tomato;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.ForeColor = System.Drawing.Color.White;
            this.button_cancelar.Location = new System.Drawing.Point(179, 346);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(100, 42);
            this.button_cancelar.TabIndex = 13;
            this.button_cancelar.Text = "CANCELAR";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // frmArticuloAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_agregar_art);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_categoria);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.label_marca);
            this.Controls.Add(this.textBox_descrip);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_codigo);
            this.Controls.Add(this.textBox_codigo);
            this.Name = "frmArticuloAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmArticuloAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_codigo;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.TextBox textBox_descrip;
        private System.Windows.Forms.Label label_marca;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.Button button_agregar_art;
        private System.Windows.Forms.Button button_cancelar;
    }
}