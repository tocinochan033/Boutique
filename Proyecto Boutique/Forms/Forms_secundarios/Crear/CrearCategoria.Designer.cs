namespace Proyecto_Boutique
{
    partial class CrearCategoria
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
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txtbox_DescripcionCategoria = new System.Windows.Forms.TextBox();
            this.lbl_NombreCategoria = new System.Windows.Forms.Label();
            this.txtbox_NombreCategoria = new System.Windows.Forms.TextBox();
            this.lbl_CrearCategoria = new System.Windows.Forms.Label();
            this.btn_CrearCategoria = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.DataGrid_Categorias = new System.Windows.Forms.DataGridView();
            this.lbl_IDCategoria = new System.Windows.Forms.Label();
            this.txtbox_IDCategoria = new System.Windows.Forms.TextBox();
            this.btn_EliminarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(93, 291);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(79, 16);
            this.lbl_Descripcion.TabIndex = 51;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // txtbox_DescripcionCategoria
            // 
            this.txtbox_DescripcionCategoria.Location = new System.Drawing.Point(96, 310);
            this.txtbox_DescripcionCategoria.MaxLength = 100;
            this.txtbox_DescripcionCategoria.Multiline = true;
            this.txtbox_DescripcionCategoria.Name = "txtbox_DescripcionCategoria";
            this.txtbox_DescripcionCategoria.Size = new System.Drawing.Size(407, 73);
            this.txtbox_DescripcionCategoria.TabIndex = 50;
            // 
            // lbl_NombreCategoria
            // 
            this.lbl_NombreCategoria.AutoSize = true;
            this.lbl_NombreCategoria.Location = new System.Drawing.Point(93, 227);
            this.lbl_NombreCategoria.Name = "lbl_NombreCategoria";
            this.lbl_NombreCategoria.Size = new System.Drawing.Size(149, 16);
            this.lbl_NombreCategoria.TabIndex = 49;
            this.lbl_NombreCategoria.Text = "Nombre de la categoria";
            // 
            // txtbox_NombreCategoria
            // 
            this.txtbox_NombreCategoria.Location = new System.Drawing.Point(96, 246);
            this.txtbox_NombreCategoria.MaxLength = 15;
            this.txtbox_NombreCategoria.Name = "txtbox_NombreCategoria";
            this.txtbox_NombreCategoria.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NombreCategoria.TabIndex = 48;
            // 
            // lbl_CrearCategoria
            // 
            this.lbl_CrearCategoria.AutoSize = true;
            this.lbl_CrearCategoria.Location = new System.Drawing.Point(242, 100);
            this.lbl_CrearCategoria.Name = "lbl_CrearCategoria";
            this.lbl_CrearCategoria.Size = new System.Drawing.Size(102, 16);
            this.lbl_CrearCategoria.TabIndex = 47;
            this.lbl_CrearCategoria.Text = "Crear Categoria";
            this.lbl_CrearCategoria.Click += new System.EventHandler(this.lbl_CrearCategoria_Click);
            // 
            // btn_CrearCategoria
            // 
            this.btn_CrearCategoria.Location = new System.Drawing.Point(320, 403);
            this.btn_CrearCategoria.Name = "btn_CrearCategoria";
            this.btn_CrearCategoria.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearCategoria.TabIndex = 53;
            this.btn_CrearCategoria.Text = "Crear Categoria";
            this.btn_CrearCategoria.UseVisualStyleBackColor = true;
            this.btn_CrearCategoria.Click += new System.EventHandler(this.btn_CrearCategoria_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(134, 403);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(153, 45);
            this.btn_Regresar.TabIndex = 52;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // DataGrid_Categorias
            // 
            this.DataGrid_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Categorias.Location = new System.Drawing.Point(615, 142);
            this.DataGrid_Categorias.Name = "DataGrid_Categorias";
            this.DataGrid_Categorias.RowHeadersWidth = 51;
            this.DataGrid_Categorias.RowTemplate.Height = 24;
            this.DataGrid_Categorias.Size = new System.Drawing.Size(431, 437);
            this.DataGrid_Categorias.TabIndex = 54;
            this.DataGrid_Categorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Productos_CellContentClick);
            // 
            // lbl_IDCategoria
            // 
            this.lbl_IDCategoria.AutoSize = true;
            this.lbl_IDCategoria.Location = new System.Drawing.Point(93, 157);
            this.lbl_IDCategoria.Name = "lbl_IDCategoria";
            this.lbl_IDCategoria.Size = new System.Drawing.Size(113, 16);
            this.lbl_IDCategoria.TabIndex = 56;
            this.lbl_IDCategoria.Text = "ID de la categoria";
            // 
            // txtbox_IDCategoria
            // 
            this.txtbox_IDCategoria.Location = new System.Drawing.Point(96, 176);
            this.txtbox_IDCategoria.Name = "txtbox_IDCategoria";
            this.txtbox_IDCategoria.Size = new System.Drawing.Size(407, 22);
            this.txtbox_IDCategoria.TabIndex = 55;
            this.txtbox_IDCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_IDCategoria_KeyPress);
            // 
            // btn_EliminarCategoria
            // 
            this.btn_EliminarCategoria.Location = new System.Drawing.Point(761, 595);
            this.btn_EliminarCategoria.Name = "btn_EliminarCategoria";
            this.btn_EliminarCategoria.Size = new System.Drawing.Size(153, 45);
            this.btn_EliminarCategoria.TabIndex = 57;
            this.btn_EliminarCategoria.Text = "Eliminar Categoria";
            this.btn_EliminarCategoria.UseVisualStyleBackColor = true;
            this.btn_EliminarCategoria.Click += new System.EventHandler(this.btn_EliminarCategoria_Click);
            // 
            // CrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 677);
            this.Controls.Add(this.btn_EliminarCategoria);
            this.Controls.Add(this.lbl_IDCategoria);
            this.Controls.Add(this.txtbox_IDCategoria);
            this.Controls.Add(this.DataGrid_Categorias);
            this.Controls.Add(this.btn_CrearCategoria);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.txtbox_DescripcionCategoria);
            this.Controls.Add(this.lbl_NombreCategoria);
            this.Controls.Add(this.txtbox_NombreCategoria);
            this.Controls.Add(this.lbl_CrearCategoria);
            this.Name = "CrearCategoria";
            this.Text = "CrearCategoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrearCategoria_FormClosing);
            this.Load += new System.EventHandler(this.CrearCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txtbox_DescripcionCategoria;
        private System.Windows.Forms.Label lbl_NombreCategoria;
        private System.Windows.Forms.TextBox txtbox_NombreCategoria;
        private System.Windows.Forms.Label lbl_CrearCategoria;
        private System.Windows.Forms.Button btn_CrearCategoria;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.DataGridView DataGrid_Categorias;
        private System.Windows.Forms.Label lbl_IDCategoria;
        private System.Windows.Forms.TextBox txtbox_IDCategoria;
        private System.Windows.Forms.Button btn_EliminarCategoria;
    }
}