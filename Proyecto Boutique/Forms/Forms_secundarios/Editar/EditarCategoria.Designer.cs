namespace Proyecto_Boutique
{
    partial class EditarCategoria
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
            this.btn_EditarCategoria = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txtbox_DescripcionCategoria = new System.Windows.Forms.TextBox();
            this.lbl_NombreCategoria = new System.Windows.Forms.Label();
            this.txtbox_NombreCategoria = new System.Windows.Forms.TextBox();
            this.lbl_EditarCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EditarCategoria
            // 
            this.btn_EditarCategoria.Location = new System.Drawing.Point(297, 275);
            this.btn_EditarCategoria.Name = "btn_EditarCategoria";
            this.btn_EditarCategoria.Size = new System.Drawing.Size(153, 45);
            this.btn_EditarCategoria.TabIndex = 66;
            this.btn_EditarCategoria.Text = "Editar Categoria";
            this.btn_EditarCategoria.UseVisualStyleBackColor = true;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(111, 275);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(153, 45);
            this.btn_Regresar.TabIndex = 65;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(70, 163);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(79, 16);
            this.lbl_Descripcion.TabIndex = 64;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // txtbox_DescripcionCategoria
            // 
            this.txtbox_DescripcionCategoria.Location = new System.Drawing.Point(73, 182);
            this.txtbox_DescripcionCategoria.Multiline = true;
            this.txtbox_DescripcionCategoria.Name = "txtbox_DescripcionCategoria";
            this.txtbox_DescripcionCategoria.Size = new System.Drawing.Size(407, 73);
            this.txtbox_DescripcionCategoria.TabIndex = 63;
            // 
            // lbl_NombreCategoria
            // 
            this.lbl_NombreCategoria.AutoSize = true;
            this.lbl_NombreCategoria.Location = new System.Drawing.Point(70, 99);
            this.lbl_NombreCategoria.Name = "lbl_NombreCategoria";
            this.lbl_NombreCategoria.Size = new System.Drawing.Size(149, 16);
            this.lbl_NombreCategoria.TabIndex = 62;
            this.lbl_NombreCategoria.Text = "Nombre de la categoria";
            // 
            // txtbox_NombreCategoria
            // 
            this.txtbox_NombreCategoria.Location = new System.Drawing.Point(73, 118);
            this.txtbox_NombreCategoria.Name = "txtbox_NombreCategoria";
            this.txtbox_NombreCategoria.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NombreCategoria.TabIndex = 61;
            // 
            // lbl_EditarCategoria
            // 
            this.lbl_EditarCategoria.AutoSize = true;
            this.lbl_EditarCategoria.Location = new System.Drawing.Point(236, 40);
            this.lbl_EditarCategoria.Name = "lbl_EditarCategoria";
            this.lbl_EditarCategoria.Size = new System.Drawing.Size(104, 16);
            this.lbl_EditarCategoria.TabIndex = 60;
            this.lbl_EditarCategoria.Text = "Editar Categoria";
            // 
            // EditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 400);
            this.Controls.Add(this.btn_EditarCategoria);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.txtbox_DescripcionCategoria);
            this.Controls.Add(this.lbl_NombreCategoria);
            this.Controls.Add(this.txtbox_NombreCategoria);
            this.Controls.Add(this.lbl_EditarCategoria);
            this.Name = "EditarCategoria";
            this.Text = "EditarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditarCategoria;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox txtbox_DescripcionCategoria;
        private System.Windows.Forms.Label lbl_NombreCategoria;
        private System.Windows.Forms.TextBox txtbox_NombreCategoria;
        private System.Windows.Forms.Label lbl_EditarCategoria;
    }
}