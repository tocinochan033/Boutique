namespace Proyecto_Boutique
{
    partial class Main
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
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.btn_Categorias = new System.Windows.Forms.Button();
            this.btn_Movimientos = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.Location = new System.Drawing.Point(251, 31);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Size = new System.Drawing.Size(153, 45);
            this.btn_Usuarios.TabIndex = 0;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_Categorias
            // 
            this.btn_Categorias.Location = new System.Drawing.Point(428, 31);
            this.btn_Categorias.Name = "btn_Categorias";
            this.btn_Categorias.Size = new System.Drawing.Size(153, 45);
            this.btn_Categorias.TabIndex = 1;
            this.btn_Categorias.Text = "Categorias";
            this.btn_Categorias.UseVisualStyleBackColor = true;
            // 
            // btn_Movimientos
            // 
            this.btn_Movimientos.Location = new System.Drawing.Point(784, 31);
            this.btn_Movimientos.Name = "btn_Movimientos";
            this.btn_Movimientos.Size = new System.Drawing.Size(153, 45);
            this.btn_Movimientos.TabIndex = 3;
            this.btn_Movimientos.Text = "Movimientos";
            this.btn_Movimientos.UseVisualStyleBackColor = true;
            // 
            // btn_Productos
            // 
            this.btn_Productos.Location = new System.Drawing.Point(607, 31);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(153, 45);
            this.btn_Productos.TabIndex = 2;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Location = new System.Drawing.Point(1147, 31);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(153, 45);
            this.btn_CerrarSesion.TabIndex = 5;
            this.btn_CerrarSesion.Text = "Cerrar sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Location = new System.Drawing.Point(970, 31);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(153, 45);
            this.btn_Reportes.TabIndex = 4;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 742);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Controls.Add(this.btn_Reportes);
            this.Controls.Add(this.btn_Movimientos);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Categorias);
            this.Controls.Add(this.btn_Usuarios);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Usuarios;
        private System.Windows.Forms.Button btn_Categorias;
        private System.Windows.Forms.Button btn_Movimientos;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_Reportes;
    }
}