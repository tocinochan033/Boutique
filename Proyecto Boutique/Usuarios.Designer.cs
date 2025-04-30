namespace Proyecto_Boutique
{
    partial class Usuarios
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
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btn_Movimientos = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Categorias = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.DataGrid_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.lbl_Usuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(994, 29);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(153, 45);
            this.btn_CerrarSesion.TabIndex = 11;
            this.btn_CerrarSesion.Text = "Cerrar sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Location = new System.Drawing.Point(817, 29);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(153, 45);
            this.btn_Reportes.TabIndex = 10;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = true;
            // 
            // btn_Movimientos
            // 
            this.btn_Movimientos.Location = new System.Drawing.Point(631, 29);
            this.btn_Movimientos.Name = "btn_Movimientos";
            this.btn_Movimientos.Size = new System.Drawing.Size(153, 45);
            this.btn_Movimientos.TabIndex = 9;
            this.btn_Movimientos.Text = "Movimientos";
            this.btn_Movimientos.UseVisualStyleBackColor = true;
            // 
            // btn_Productos
            // 
            this.btn_Productos.Location = new System.Drawing.Point(454, 29);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(153, 45);
            this.btn_Productos.TabIndex = 8;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            // 
            // btn_Categorias
            // 
            this.btn_Categorias.Location = new System.Drawing.Point(275, 29);
            this.btn_Categorias.Name = "btn_Categorias";
            this.btn_Categorias.Size = new System.Drawing.Size(153, 45);
            this.btn_Categorias.TabIndex = 7;
            this.btn_Categorias.Text = "Categorias";
            this.btn_Categorias.UseVisualStyleBackColor = true;
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Location = new System.Drawing.Point(98, 29);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(153, 45);
            this.btn_Usuarios.TabIndex = 6;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            // 
            // DataGrid_Usuarios
            // 
            this.DataGrid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Usuarios.Location = new System.Drawing.Point(56, 195);
            this.DataGrid_Usuarios.Name = "DataGrid_Usuarios";
            this.DataGrid_Usuarios.RowHeadersWidth = 51;
            this.DataGrid_Usuarios.RowTemplate.Height = 24;
            this.DataGrid_Usuarios.Size = new System.Drawing.Size(1043, 437);
            this.DataGrid_Usuarios.TabIndex = 12;
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.Location = new System.Drawing.Point(932, 113);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearUsuario.TabIndex = 13;
            this.btn_CrearUsuario.Text = "Crear Usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            // 
            // lbl_Usuarios
            // 
            this.lbl_Usuarios.AutoSize = true;
            this.lbl_Usuarios.Location = new System.Drawing.Point(53, 127);
            this.lbl_Usuarios.Name = "lbl_Usuarios";
            this.lbl_Usuarios.Size = new System.Drawing.Size(61, 16);
            this.lbl_Usuarios.TabIndex = 14;
            this.lbl_Usuarios.Text = "Usuarios";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 696);
            this.Controls.Add(this.lbl_Usuarios);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.DataGrid_Usuarios);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.btn_Movimientos);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Categorias);
            this.Controls.Add(this.btn_Usuarios);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.Button btn_Movimientos;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Categorias;
        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.DataGridView DataGrid_Usuarios;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.Label lbl_Usuarios;
    }
}