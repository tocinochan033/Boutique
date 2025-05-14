namespace Proyecto_Boutique.Forms.Forms_secundarios.Crear
{
    partial class CrearMarca
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
            this.btn_EliminarMarca = new System.Windows.Forms.Button();
            this.lbl_IDMarca = new System.Windows.Forms.Label();
            this.txtbox_IDMarca = new System.Windows.Forms.TextBox();
            this.DataGrid_Marcas = new System.Windows.Forms.DataGridView();
            this.btn_CrearMarca = new System.Windows.Forms.Button();
            this.lbl_NombreMarca = new System.Windows.Forms.Label();
            this.txtbox_NombreMarca = new System.Windows.Forms.TextBox();
            this.lbl_CrearMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Marcas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EliminarMarca
            // 
            this.btn_EliminarMarca.Location = new System.Drawing.Point(717, 567);
            this.btn_EliminarMarca.Name = "btn_EliminarMarca";
            this.btn_EliminarMarca.Size = new System.Drawing.Size(153, 45);
            this.btn_EliminarMarca.TabIndex = 68;
            this.btn_EliminarMarca.Text = "Eliminar Marca";
            this.btn_EliminarMarca.UseVisualStyleBackColor = true;
            this.btn_EliminarMarca.Click += new System.EventHandler(this.btn_EliminarMarca_Click);
            // 
            // lbl_IDMarca
            // 
            this.lbl_IDMarca.AutoSize = true;
            this.lbl_IDMarca.Location = new System.Drawing.Point(49, 129);
            this.lbl_IDMarca.Name = "lbl_IDMarca";
            this.lbl_IDMarca.Size = new System.Drawing.Size(94, 16);
            this.lbl_IDMarca.TabIndex = 67;
            this.lbl_IDMarca.Text = "ID de la Marca";
            // 
            // txtbox_IDMarca
            // 
            this.txtbox_IDMarca.Location = new System.Drawing.Point(52, 148);
            this.txtbox_IDMarca.Name = "txtbox_IDMarca";
            this.txtbox_IDMarca.ReadOnly = true;
            this.txtbox_IDMarca.Size = new System.Drawing.Size(407, 22);
            this.txtbox_IDMarca.TabIndex = 66;
            this.txtbox_IDMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_IDMarca_KeyPress);
            // 
            // DataGrid_Marcas
            // 
            this.DataGrid_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Marcas.Location = new System.Drawing.Point(571, 114);
            this.DataGrid_Marcas.Name = "DataGrid_Marcas";
            this.DataGrid_Marcas.RowHeadersWidth = 51;
            this.DataGrid_Marcas.RowTemplate.Height = 24;
            this.DataGrid_Marcas.Size = new System.Drawing.Size(431, 437);
            this.DataGrid_Marcas.TabIndex = 65;
            // 
            // btn_CrearMarca
            // 
            this.btn_CrearMarca.Location = new System.Drawing.Point(173, 376);
            this.btn_CrearMarca.Name = "btn_CrearMarca";
            this.btn_CrearMarca.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearMarca.TabIndex = 64;
            this.btn_CrearMarca.Text = "Registrar Marca";
            this.btn_CrearMarca.UseVisualStyleBackColor = true;
            this.btn_CrearMarca.Click += new System.EventHandler(this.btn_CrearMarca_Click);
            // 
            // lbl_NombreMarca
            // 
            this.lbl_NombreMarca.AutoSize = true;
            this.lbl_NombreMarca.Location = new System.Drawing.Point(49, 199);
            this.lbl_NombreMarca.Name = "lbl_NombreMarca";
            this.lbl_NombreMarca.Size = new System.Drawing.Size(130, 16);
            this.lbl_NombreMarca.TabIndex = 60;
            this.lbl_NombreMarca.Text = "Nombre de la Marca";
            // 
            // txtbox_NombreMarca
            // 
            this.txtbox_NombreMarca.Location = new System.Drawing.Point(52, 218);
            this.txtbox_NombreMarca.MaxLength = 15;
            this.txtbox_NombreMarca.Name = "txtbox_NombreMarca";
            this.txtbox_NombreMarca.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NombreMarca.TabIndex = 59;
            // 
            // lbl_CrearMarca
            // 
            this.lbl_CrearMarca.AutoSize = true;
            this.lbl_CrearMarca.Location = new System.Drawing.Point(198, 72);
            this.lbl_CrearMarca.Name = "lbl_CrearMarca";
            this.lbl_CrearMarca.Size = new System.Drawing.Size(103, 16);
            this.lbl_CrearMarca.TabIndex = 58;
            this.lbl_CrearMarca.Text = "Registrar Marca";
            // 
            // CrearMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 685);
            this.Controls.Add(this.btn_EliminarMarca);
            this.Controls.Add(this.lbl_IDMarca);
            this.Controls.Add(this.txtbox_IDMarca);
            this.Controls.Add(this.DataGrid_Marcas);
            this.Controls.Add(this.btn_CrearMarca);
            this.Controls.Add(this.lbl_NombreMarca);
            this.Controls.Add(this.txtbox_NombreMarca);
            this.Controls.Add(this.lbl_CrearMarca);
            this.Name = "CrearMarca";
            this.Text = "CrearMarca";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearMarca_FormClosed);
            this.Load += new System.EventHandler(this.CrearMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Marcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EliminarMarca;
        private System.Windows.Forms.Label lbl_IDMarca;
        private System.Windows.Forms.TextBox txtbox_IDMarca;
        private System.Windows.Forms.DataGridView DataGrid_Marcas;
        private System.Windows.Forms.Button btn_CrearMarca;
        private System.Windows.Forms.Label lbl_NombreMarca;
        private System.Windows.Forms.TextBox txtbox_NombreMarca;
        private System.Windows.Forms.Label lbl_CrearMarca;
    }
}