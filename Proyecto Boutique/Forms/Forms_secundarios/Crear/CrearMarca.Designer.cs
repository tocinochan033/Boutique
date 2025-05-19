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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearMarca));
            this.btn_EliminarMarca = new System.Windows.Forms.Button();
            this.lbl_IDMarca = new System.Windows.Forms.Label();
            this.txtbox_IDMarca = new System.Windows.Forms.TextBox();
            this.DataGrid_Marcas = new System.Windows.Forms.DataGridView();
            this.btn_CrearMarca = new System.Windows.Forms.Button();
            this.lbl_NombreMarca = new System.Windows.Forms.Label();
            this.txtbox_NombreMarca = new System.Windows.Forms.TextBox();
            this.lbl_CrearCategoria = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Marcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EliminarMarca
            // 
            this.btn_EliminarMarca.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_EliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarMarca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarMarca.Location = new System.Drawing.Point(426, 236);
            this.btn_EliminarMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EliminarMarca.Name = "btn_EliminarMarca";
            this.btn_EliminarMarca.Size = new System.Drawing.Size(156, 43);
            this.btn_EliminarMarca.TabIndex = 68;
            this.btn_EliminarMarca.Text = "Eliminar";
            this.btn_EliminarMarca.UseVisualStyleBackColor = true;
            this.btn_EliminarMarca.Click += new System.EventHandler(this.btn_EliminarMarca_Click);
            // 
            // lbl_IDMarca
            // 
            this.lbl_IDMarca.AutoSize = true;
            this.lbl_IDMarca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDMarca.Location = new System.Drawing.Point(374, 53);
            this.lbl_IDMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IDMarca.Name = "lbl_IDMarca";
            this.lbl_IDMarca.Size = new System.Drawing.Size(105, 21);
            this.lbl_IDMarca.TabIndex = 67;
            this.lbl_IDMarca.Text = "ID asignado:";
            // 
            // txtbox_IDMarca
            // 
            this.txtbox_IDMarca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_IDMarca.Location = new System.Drawing.Point(376, 76);
            this.txtbox_IDMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_IDMarca.Name = "txtbox_IDMarca";
            this.txtbox_IDMarca.ReadOnly = true;
            this.txtbox_IDMarca.Size = new System.Drawing.Size(163, 29);
            this.txtbox_IDMarca.TabIndex = 66;
            this.txtbox_IDMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_IDMarca_KeyPress);
            // 
            // DataGrid_Marcas
            // 
            this.DataGrid_Marcas.BackgroundColor = System.Drawing.Color.Lavender;
            this.DataGrid_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Marcas.GridColor = System.Drawing.SystemColors.Control;
            this.DataGrid_Marcas.Location = new System.Drawing.Point(11, 56);
            this.DataGrid_Marcas.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_Marcas.Name = "DataGrid_Marcas";
            this.DataGrid_Marcas.RowHeadersWidth = 51;
            this.DataGrid_Marcas.RowTemplate.Height = 24;
            this.DataGrid_Marcas.Size = new System.Drawing.Size(347, 223);
            this.DataGrid_Marcas.TabIndex = 65;
            // 
            // btn_CrearMarca
            // 
            this.btn_CrearMarca.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_CrearMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearMarca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearMarca.Location = new System.Drawing.Point(426, 184);
            this.btn_CrearMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CrearMarca.Name = "btn_CrearMarca";
            this.btn_CrearMarca.Size = new System.Drawing.Size(156, 43);
            this.btn_CrearMarca.TabIndex = 64;
            this.btn_CrearMarca.Text = "Registrar";
            this.btn_CrearMarca.UseVisualStyleBackColor = true;
            this.btn_CrearMarca.Click += new System.EventHandler(this.btn_CrearMarca_Click);
            // 
            // lbl_NombreMarca
            // 
            this.lbl_NombreMarca.AutoSize = true;
            this.lbl_NombreMarca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreMarca.Location = new System.Drawing.Point(374, 118);
            this.lbl_NombreMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NombreMarca.Name = "lbl_NombreMarca";
            this.lbl_NombreMarca.Size = new System.Drawing.Size(169, 21);
            this.lbl_NombreMarca.TabIndex = 60;
            this.lbl_NombreMarca.Text = "Nombre de la Marca:";
            // 
            // txtbox_NombreMarca
            // 
            this.txtbox_NombreMarca.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_NombreMarca.Location = new System.Drawing.Point(376, 141);
            this.txtbox_NombreMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_NombreMarca.MaxLength = 15;
            this.txtbox_NombreMarca.Name = "txtbox_NombreMarca";
            this.txtbox_NombreMarca.Size = new System.Drawing.Size(206, 29);
            this.txtbox_NombreMarca.TabIndex = 59;
            // 
            // lbl_CrearCategoria
            // 
            this.lbl_CrearCategoria.AutoSize = true;
            this.lbl_CrearCategoria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_CrearCategoria.Location = new System.Drawing.Point(11, 9);
            this.lbl_CrearCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CrearCategoria.Name = "lbl_CrearCategoria";
            this.lbl_CrearCategoria.Size = new System.Drawing.Size(244, 39);
            this.lbl_CrearCategoria.TabIndex = 79;
            this.lbl_CrearCategoria.Text = "Registró de Marca";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Boutique.Properties.Resources.agregar;
            this.pictureBox5.Location = new System.Drawing.Point(376, 184);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 80;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Boutique.Properties.Resources.circulo_de_basura;
            this.pictureBox1.Location = new System.Drawing.Point(376, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // CrearMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbl_CrearCategoria);
            this.Controls.Add(this.btn_EliminarMarca);
            this.Controls.Add(this.lbl_IDMarca);
            this.Controls.Add(this.txtbox_IDMarca);
            this.Controls.Add(this.DataGrid_Marcas);
            this.Controls.Add(this.btn_CrearMarca);
            this.Controls.Add(this.lbl_NombreMarca);
            this.Controls.Add(this.txtbox_NombreMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(608, 330);
            this.MinimumSize = new System.Drawing.Size(608, 330);
            this.Name = "CrearMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Gestór de Inventarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearMarca_FormClosed);
            this.Load += new System.EventHandler(this.CrearMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Marcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lbl_CrearCategoria;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}