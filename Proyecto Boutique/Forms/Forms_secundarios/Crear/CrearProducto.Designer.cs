namespace Proyecto_Boutique
{
    partial class CrearProducto
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
            this.btn_CrearProducto = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txtbox_Precio = new System.Windows.Forms.TextBox();
            this.lbl_NombreProducto = new System.Windows.Forms.Label();
            this.txtbox_NombreProducto = new System.Windows.Forms.TextBox();
            this.lbl_CrearProducto = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_Talla = new System.Windows.Forms.Label();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.cmb_Marca = new System.Windows.Forms.ComboBox();
            this.lbl_DescripcionProducto = new System.Windows.Forms.Label();
            this.txtbox_DescripcionProducto = new System.Windows.Forms.TextBox();
            this.lbl_CantidadProducto = new System.Windows.Forms.Label();
            this.txtbox_Cantidad = new System.Windows.Forms.TextBox();
            this.txtbox_talla = new System.Windows.Forms.TextBox();
            this.txtbox_PuntoReorden = new System.Windows.Forms.TextBox();
            this.lbl_PuntoReorden = new System.Windows.Forms.Label();
            this.txtbox_MinimoStock = new System.Windows.Forms.TextBox();
            this.lbl_MinimoStock = new System.Windows.Forms.Label();
            this.txtbox_MaximoStock = new System.Windows.Forms.TextBox();
            this.lbl_MaximoStock = new System.Windows.Forms.Label();
            this.lbl_IDProducto = new System.Windows.Forms.Label();
            this.txtbox_IDProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_CrearProducto
            // 
            this.btn_CrearProducto.Location = new System.Drawing.Point(523, 622);
            this.btn_CrearProducto.Name = "btn_CrearProducto";
            this.btn_CrearProducto.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearProducto.TabIndex = 79;
            this.btn_CrearProducto.Text = "Crear Producto";
            this.btn_CrearProducto.UseVisualStyleBackColor = true;
            this.btn_CrearProducto.Click += new System.EventHandler(this.btn_CrearProducto_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(337, 622);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(153, 45);
            this.btn_Regresar.TabIndex = 78;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(38, 414);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(46, 16);
            this.lbl_Precio.TabIndex = 77;
            this.lbl_Precio.Text = "Precio";
            // 
            // txtbox_Precio
            // 
            this.txtbox_Precio.Location = new System.Drawing.Point(41, 433);
            this.txtbox_Precio.Name = "txtbox_Precio";
            this.txtbox_Precio.Size = new System.Drawing.Size(407, 22);
            this.txtbox_Precio.TabIndex = 76;
            this.txtbox_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Precio_KeyPress);
            // 
            // lbl_NombreProducto
            // 
            this.lbl_NombreProducto.AutoSize = true;
            this.lbl_NombreProducto.Location = new System.Drawing.Point(38, 113);
            this.lbl_NombreProducto.Name = "lbl_NombreProducto";
            this.lbl_NombreProducto.Size = new System.Drawing.Size(56, 16);
            this.lbl_NombreProducto.TabIndex = 75;
            this.lbl_NombreProducto.Text = "Nombre";
            // 
            // txtbox_NombreProducto
            // 
            this.txtbox_NombreProducto.Location = new System.Drawing.Point(41, 132);
            this.txtbox_NombreProducto.MaxLength = 50;
            this.txtbox_NombreProducto.Name = "txtbox_NombreProducto";
            this.txtbox_NombreProducto.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NombreProducto.TabIndex = 74;
            // 
            // lbl_CrearProducto
            // 
            this.lbl_CrearProducto.AutoSize = true;
            this.lbl_CrearProducto.Location = new System.Drawing.Point(170, 23);
            this.lbl_CrearProducto.Name = "lbl_CrearProducto";
            this.lbl_CrearProducto.Size = new System.Drawing.Size(97, 16);
            this.lbl_CrearProducto.TabIndex = 73;
            this.lbl_CrearProducto.Text = "Crear Producto";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Location = new System.Drawing.Point(41, 368);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(409, 24);
            this.cmb_Categoria.TabIndex = 80;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(40, 349);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(66, 16);
            this.lbl_Categoria.TabIndex = 81;
            this.lbl_Categoria.Text = "Categoria";
            // 
            // lbl_Talla
            // 
            this.lbl_Talla.AutoSize = true;
            this.lbl_Talla.Location = new System.Drawing.Point(539, 113);
            this.lbl_Talla.Name = "lbl_Talla";
            this.lbl_Talla.Size = new System.Drawing.Size(38, 16);
            this.lbl_Talla.TabIndex = 83;
            this.lbl_Talla.Text = "Talla";
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.Location = new System.Drawing.Point(40, 540);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(39, 16);
            this.lbl_Color.TabIndex = 85;
            this.lbl_Color.Text = "Color";
            // 
            // cmb_Color
            // 
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Location = new System.Drawing.Point(43, 559);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(409, 24);
            this.cmb_Color.TabIndex = 84;
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(38, 173);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(45, 16);
            this.lbl_Marca.TabIndex = 87;
            this.lbl_Marca.Text = "Marca";
            // 
            // cmb_Marca
            // 
            this.cmb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Marca.FormattingEnabled = true;
            this.cmb_Marca.Location = new System.Drawing.Point(39, 192);
            this.cmb_Marca.Name = "cmb_Marca";
            this.cmb_Marca.Size = new System.Drawing.Size(409, 24);
            this.cmb_Marca.TabIndex = 86;
            // 
            // lbl_DescripcionProducto
            // 
            this.lbl_DescripcionProducto.AutoSize = true;
            this.lbl_DescripcionProducto.Location = new System.Drawing.Point(36, 236);
            this.lbl_DescripcionProducto.Name = "lbl_DescripcionProducto";
            this.lbl_DescripcionProducto.Size = new System.Drawing.Size(79, 16);
            this.lbl_DescripcionProducto.TabIndex = 89;
            this.lbl_DescripcionProducto.Text = "Descripcion";
            // 
            // txtbox_DescripcionProducto
            // 
            this.txtbox_DescripcionProducto.Location = new System.Drawing.Point(39, 255);
            this.txtbox_DescripcionProducto.MaxLength = 100;
            this.txtbox_DescripcionProducto.Multiline = true;
            this.txtbox_DescripcionProducto.Name = "txtbox_DescripcionProducto";
            this.txtbox_DescripcionProducto.Size = new System.Drawing.Size(407, 72);
            this.txtbox_DescripcionProducto.TabIndex = 88;
            // 
            // lbl_CantidadProducto
            // 
            this.lbl_CantidadProducto.AutoSize = true;
            this.lbl_CantidadProducto.Location = new System.Drawing.Point(38, 476);
            this.lbl_CantidadProducto.Name = "lbl_CantidadProducto";
            this.lbl_CantidadProducto.Size = new System.Drawing.Size(61, 16);
            this.lbl_CantidadProducto.TabIndex = 91;
            this.lbl_CantidadProducto.Text = "Cantidad";
            // 
            // txtbox_Cantidad
            // 
            this.txtbox_Cantidad.Location = new System.Drawing.Point(41, 495);
            this.txtbox_Cantidad.Name = "txtbox_Cantidad";
            this.txtbox_Cantidad.Size = new System.Drawing.Size(407, 22);
            this.txtbox_Cantidad.TabIndex = 90;
            this.txtbox_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Cantidad_KeyPress);
            // 
            // txtbox_talla
            // 
            this.txtbox_talla.Location = new System.Drawing.Point(542, 132);
            this.txtbox_talla.MaxLength = 5;
            this.txtbox_talla.Name = "txtbox_talla";
            this.txtbox_talla.Size = new System.Drawing.Size(407, 22);
            this.txtbox_talla.TabIndex = 92;
            // 
            // txtbox_PuntoReorden
            // 
            this.txtbox_PuntoReorden.Location = new System.Drawing.Point(542, 196);
            this.txtbox_PuntoReorden.Name = "txtbox_PuntoReorden";
            this.txtbox_PuntoReorden.Size = new System.Drawing.Size(407, 22);
            this.txtbox_PuntoReorden.TabIndex = 95;
            this.txtbox_PuntoReorden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_PuntoReorden_KeyPress);
            // 
            // lbl_PuntoReorden
            // 
            this.lbl_PuntoReorden.AutoSize = true;
            this.lbl_PuntoReorden.Location = new System.Drawing.Point(539, 177);
            this.lbl_PuntoReorden.Name = "lbl_PuntoReorden";
            this.lbl_PuntoReorden.Size = new System.Drawing.Size(110, 16);
            this.lbl_PuntoReorden.TabIndex = 94;
            this.lbl_PuntoReorden.Text = "Punto de reorden";
            // 
            // txtbox_MinimoStock
            // 
            this.txtbox_MinimoStock.Location = new System.Drawing.Point(542, 321);
            this.txtbox_MinimoStock.Name = "txtbox_MinimoStock";
            this.txtbox_MinimoStock.Size = new System.Drawing.Size(407, 22);
            this.txtbox_MinimoStock.TabIndex = 99;
            this.txtbox_MinimoStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_MinimoStock_KeyPress);
            // 
            // lbl_MinimoStock
            // 
            this.lbl_MinimoStock.AutoSize = true;
            this.lbl_MinimoStock.Location = new System.Drawing.Point(539, 302);
            this.lbl_MinimoStock.Name = "lbl_MinimoStock";
            this.lbl_MinimoStock.Size = new System.Drawing.Size(104, 16);
            this.lbl_MinimoStock.TabIndex = 98;
            this.lbl_MinimoStock.Text = "Minimo de stock";
            // 
            // txtbox_MaximoStock
            // 
            this.txtbox_MaximoStock.Location = new System.Drawing.Point(542, 257);
            this.txtbox_MaximoStock.Name = "txtbox_MaximoStock";
            this.txtbox_MaximoStock.Size = new System.Drawing.Size(407, 22);
            this.txtbox_MaximoStock.TabIndex = 97;
            this.txtbox_MaximoStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_MaximoStock_KeyPress);
            // 
            // lbl_MaximoStock
            // 
            this.lbl_MaximoStock.AutoSize = true;
            this.lbl_MaximoStock.Location = new System.Drawing.Point(539, 238);
            this.lbl_MaximoStock.Name = "lbl_MaximoStock";
            this.lbl_MaximoStock.Size = new System.Drawing.Size(108, 16);
            this.lbl_MaximoStock.TabIndex = 96;
            this.lbl_MaximoStock.Text = "Maximo de stock";
            // 
            // lbl_IDProducto
            // 
            this.lbl_IDProducto.AutoSize = true;
            this.lbl_IDProducto.Location = new System.Drawing.Point(38, 56);
            this.lbl_IDProducto.Name = "lbl_IDProducto";
            this.lbl_IDProducto.Size = new System.Drawing.Size(98, 16);
            this.lbl_IDProducto.TabIndex = 101;
            this.lbl_IDProducto.Text = "ID del producto";
            // 
            // txtbox_IDProducto
            // 
            this.txtbox_IDProducto.Location = new System.Drawing.Point(41, 75);
            this.txtbox_IDProducto.Name = "txtbox_IDProducto";
            this.txtbox_IDProducto.Size = new System.Drawing.Size(407, 22);
            this.txtbox_IDProducto.TabIndex = 100;
            this.txtbox_IDProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_IDProducto_KeyPress);
            // 
            // CrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 718);
            this.Controls.Add(this.lbl_IDProducto);
            this.Controls.Add(this.txtbox_IDProducto);
            this.Controls.Add(this.txtbox_MinimoStock);
            this.Controls.Add(this.lbl_MinimoStock);
            this.Controls.Add(this.txtbox_MaximoStock);
            this.Controls.Add(this.lbl_MaximoStock);
            this.Controls.Add(this.txtbox_PuntoReorden);
            this.Controls.Add(this.lbl_PuntoReorden);
            this.Controls.Add(this.txtbox_talla);
            this.Controls.Add(this.lbl_CantidadProducto);
            this.Controls.Add(this.txtbox_Cantidad);
            this.Controls.Add(this.lbl_DescripcionProducto);
            this.Controls.Add(this.txtbox_DescripcionProducto);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.cmb_Marca);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.cmb_Color);
            this.Controls.Add(this.lbl_Talla);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.cmb_Categoria);
            this.Controls.Add(this.btn_CrearProducto);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.txtbox_Precio);
            this.Controls.Add(this.lbl_NombreProducto);
            this.Controls.Add(this.txtbox_NombreProducto);
            this.Controls.Add(this.lbl_CrearProducto);
            this.Name = "CrearProducto";
            this.Text = "CrearProducto";
            this.Load += new System.EventHandler(this.CrearProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearProducto;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txtbox_Precio;
        private System.Windows.Forms.Label lbl_NombreProducto;
        private System.Windows.Forms.TextBox txtbox_NombreProducto;
        private System.Windows.Forms.Label lbl_CrearProducto;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_Talla;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.ComboBox cmb_Marca;
        private System.Windows.Forms.Label lbl_DescripcionProducto;
        private System.Windows.Forms.TextBox txtbox_DescripcionProducto;
        private System.Windows.Forms.Label lbl_CantidadProducto;
        private System.Windows.Forms.TextBox txtbox_Cantidad;
        private System.Windows.Forms.TextBox txtbox_talla;
        private System.Windows.Forms.TextBox txtbox_PuntoReorden;
        private System.Windows.Forms.Label lbl_PuntoReorden;
        private System.Windows.Forms.TextBox txtbox_MinimoStock;
        private System.Windows.Forms.Label lbl_MinimoStock;
        private System.Windows.Forms.TextBox txtbox_MaximoStock;
        private System.Windows.Forms.Label lbl_MaximoStock;
        private System.Windows.Forms.Label lbl_IDProducto;
        private System.Windows.Forms.TextBox txtbox_IDProducto;
    }
}