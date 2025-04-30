namespace Proyecto_Boutique
{
    partial class Productos
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
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.btn_CrearProducto = new System.Windows.Forms.Button();
            this.DataGrid_Productos = new System.Windows.Forms.DataGridView();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Movimientos = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Categorias = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Location = new System.Drawing.Point(35, 152);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(68, 16);
            this.lbl_Productos.TabIndex = 32;
            this.lbl_Productos.Text = "Productos";
            // 
            // btn_CrearProducto
            // 
            this.btn_CrearProducto.Location = new System.Drawing.Point(914, 138);
            this.btn_CrearProducto.Name = "btn_CrearProducto";
            this.btn_CrearProducto.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearProducto.TabIndex = 31;
            this.btn_CrearProducto.Text = "Crear Producto";
            this.btn_CrearProducto.UseVisualStyleBackColor = true;
            // 
            // DataGrid_Productos
            // 
            this.DataGrid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Productos.Location = new System.Drawing.Point(38, 220);
            this.DataGrid_Productos.Name = "DataGrid_Productos";
            this.DataGrid_Productos.RowHeadersWidth = 51;
            this.DataGrid_Productos.RowTemplate.Height = 24;
            this.DataGrid_Productos.Size = new System.Drawing.Size(1043, 437);
            this.DataGrid_Productos.TabIndex = 30;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(976, 54);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(153, 45);
            this.btn_CerrarSesion.TabIndex = 29;
            this.btn_CerrarSesion.Text = "Cerrar sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Location = new System.Drawing.Point(799, 54);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(153, 45);
            this.btn_Reportes.TabIndex = 28;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = true;
            // 
            // btn_Movimientos
            // 
            this.btn_Movimientos.Location = new System.Drawing.Point(613, 54);
            this.btn_Movimientos.Name = "btn_Movimientos";
            this.btn_Movimientos.Size = new System.Drawing.Size(153, 45);
            this.btn_Movimientos.TabIndex = 27;
            this.btn_Movimientos.Text = "Movimientos";
            this.btn_Movimientos.UseVisualStyleBackColor = true;
            // 
            // btn_Productos
            // 
            this.btn_Productos.Location = new System.Drawing.Point(436, 54);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(153, 45);
            this.btn_Productos.TabIndex = 26;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            // 
            // btn_Categorias
            // 
            this.btn_Categorias.Location = new System.Drawing.Point(257, 54);
            this.btn_Categorias.Name = "btn_Categorias";
            this.btn_Categorias.Size = new System.Drawing.Size(153, 45);
            this.btn_Categorias.TabIndex = 25;
            this.btn_Categorias.Text = "Categorias";
            this.btn_Categorias.UseVisualStyleBackColor = true;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Location = new System.Drawing.Point(80, 54);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(153, 45);
            this.btn_Usuarios.TabIndex = 24;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 711);
            this.Controls.Add(this.lbl_Productos);
            this.Controls.Add(this.btn_CrearProducto);
            this.Controls.Add(this.DataGrid_Productos);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.btn_Movimientos);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Categorias);
            this.Controls.Add(this.btn_Usuarios);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.Button btn_CrearProducto;
        private System.Windows.Forms.DataGridView DataGrid_Productos;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_Movimientos;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Categorias;
        private System.Windows.Forms.Button btn_Usuarios;
    }
}