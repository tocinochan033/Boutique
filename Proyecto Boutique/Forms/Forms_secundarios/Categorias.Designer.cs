namespace Proyecto_Boutique
{
    partial class Categorias
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
            this.lbl_Categorias = new System.Windows.Forms.Label();
            this.btn_CrearCategoria = new System.Windows.Forms.Button();
            this.DataGrid_Categorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Categorias
            // 
            this.lbl_Categorias.AutoSize = true;
            this.lbl_Categorias.Location = new System.Drawing.Point(29, 50);
            this.lbl_Categorias.Name = "lbl_Categorias";
            this.lbl_Categorias.Size = new System.Drawing.Size(73, 16);
            this.lbl_Categorias.TabIndex = 23;
            this.lbl_Categorias.Text = "Categorias";
            // 
            // btn_CrearCategoria
            // 
            this.btn_CrearCategoria.Location = new System.Drawing.Point(908, 36);
            this.btn_CrearCategoria.Name = "btn_CrearCategoria";
            this.btn_CrearCategoria.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearCategoria.TabIndex = 22;
            this.btn_CrearCategoria.Text = "Crear Categoria";
            this.btn_CrearCategoria.UseVisualStyleBackColor = true;
            this.btn_CrearCategoria.Click += new System.EventHandler(this.btn_CrearCategoria_Click);
            // 
            // DataGrid_Categorias
            // 
            this.DataGrid_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Categorias.Location = new System.Drawing.Point(32, 118);
            this.DataGrid_Categorias.Name = "DataGrid_Categorias";
            this.DataGrid_Categorias.RowHeadersWidth = 51;
            this.DataGrid_Categorias.RowTemplate.Height = 24;
            this.DataGrid_Categorias.Size = new System.Drawing.Size(1043, 437);
            this.DataGrid_Categorias.TabIndex = 21;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 582);
            this.Controls.Add(this.lbl_Categorias);
            this.Controls.Add(this.btn_CrearCategoria);
            this.Controls.Add(this.DataGrid_Categorias);
            this.Name = "Categorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Categorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Categorias;
        private System.Windows.Forms.Button btn_CrearCategoria;
        private System.Windows.Forms.DataGridView DataGrid_Categorias;
    }
}