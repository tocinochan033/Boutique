namespace Proyecto_Boutique
{
    partial class CrearColores
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
            this.btn_EliminarColor = new System.Windows.Forms.Button();
            this.lbl_IDColor = new System.Windows.Forms.Label();
            this.txtbox_IDColor = new System.Windows.Forms.TextBox();
            this.DataGrid_Colores = new System.Windows.Forms.DataGridView();
            this.btn_CrearColor = new System.Windows.Forms.Button();
            this.lbl_NombreColor = new System.Windows.Forms.Label();
            this.txtbox_NombreColor = new System.Windows.Forms.TextBox();
            this.lbl_CrearCategoria = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Colores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EliminarColor
            // 
            this.btn_EliminarColor.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_EliminarColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarColor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarColor.Location = new System.Drawing.Point(437, 236);
            this.btn_EliminarColor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EliminarColor.Name = "btn_EliminarColor";
            this.btn_EliminarColor.Size = new System.Drawing.Size(175, 43);
            this.btn_EliminarColor.TabIndex = 77;
            this.btn_EliminarColor.Text = "Eliminar";
            this.btn_EliminarColor.UseVisualStyleBackColor = true;
            this.btn_EliminarColor.Click += new System.EventHandler(this.btn_EliminarColor_Click);
            // 
            // lbl_IDColor
            // 
            this.lbl_IDColor.AutoSize = true;
            this.lbl_IDColor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDColor.Location = new System.Drawing.Point(383, 57);
            this.lbl_IDColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IDColor.Name = "lbl_IDColor";
            this.lbl_IDColor.Size = new System.Drawing.Size(105, 21);
            this.lbl_IDColor.TabIndex = 76;
            this.lbl_IDColor.Text = "ID asignado:";
            // 
            // txtbox_IDColor
            // 
            this.txtbox_IDColor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_IDColor.Location = new System.Drawing.Point(385, 80);
            this.txtbox_IDColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_IDColor.Name = "txtbox_IDColor";
            this.txtbox_IDColor.ReadOnly = true;
            this.txtbox_IDColor.Size = new System.Drawing.Size(148, 29);
            this.txtbox_IDColor.TabIndex = 75;
            this.txtbox_IDColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_IDColor_KeyPress);
            // 
            // DataGrid_Colores
            // 
            this.DataGrid_Colores.BackgroundColor = System.Drawing.Color.Lavender;
            this.DataGrid_Colores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Colores.GridColor = System.Drawing.SystemColors.Control;
            this.DataGrid_Colores.Location = new System.Drawing.Point(19, 56);
            this.DataGrid_Colores.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_Colores.Name = "DataGrid_Colores";
            this.DataGrid_Colores.RowHeadersWidth = 51;
            this.DataGrid_Colores.RowTemplate.Height = 24;
            this.DataGrid_Colores.Size = new System.Drawing.Size(350, 223);
            this.DataGrid_Colores.TabIndex = 74;
            // 
            // btn_CrearColor
            // 
            this.btn_CrearColor.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_CrearColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CrearColor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearColor.Location = new System.Drawing.Point(437, 186);
            this.btn_CrearColor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CrearColor.Name = "btn_CrearColor";
            this.btn_CrearColor.Size = new System.Drawing.Size(175, 43);
            this.btn_CrearColor.TabIndex = 73;
            this.btn_CrearColor.Text = "Registrar";
            this.btn_CrearColor.UseVisualStyleBackColor = true;
            this.btn_CrearColor.Click += new System.EventHandler(this.btn_CrearColor_Click);
            // 
            // lbl_NombreColor
            // 
            this.lbl_NombreColor.AutoSize = true;
            this.lbl_NombreColor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreColor.Location = new System.Drawing.Point(383, 115);
            this.lbl_NombreColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NombreColor.Name = "lbl_NombreColor";
            this.lbl_NombreColor.Size = new System.Drawing.Size(149, 21);
            this.lbl_NombreColor.TabIndex = 71;
            this.lbl_NombreColor.Text = "Nombre del color:";
            // 
            // txtbox_NombreColor
            // 
            this.txtbox_NombreColor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_NombreColor.Location = new System.Drawing.Point(387, 138);
            this.txtbox_NombreColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_NombreColor.MaxLength = 15;
            this.txtbox_NombreColor.Name = "txtbox_NombreColor";
            this.txtbox_NombreColor.Size = new System.Drawing.Size(225, 29);
            this.txtbox_NombreColor.TabIndex = 70;
            this.txtbox_NombreColor.TextChanged += new System.EventHandler(this.txtbox_NombreColor_TextChanged);
            // 
            // lbl_CrearCategoria
            // 
            this.lbl_CrearCategoria.AutoSize = true;
            this.lbl_CrearCategoria.Font = new System.Drawing.Font("Sugo Pro Classic Trial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CrearCategoria.Location = new System.Drawing.Point(11, 9);
            this.lbl_CrearCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CrearCategoria.Name = "lbl_CrearCategoria";
            this.lbl_CrearCategoria.Size = new System.Drawing.Size(246, 45);
            this.lbl_CrearCategoria.TabIndex = 78;
            this.lbl_CrearCategoria.Text = "Creación de Colores";
            this.lbl_CrearCategoria.Click += new System.EventHandler(this.lbl_CrearCategoria_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Boutique.Properties.Resources.agregar;
            this.pictureBox5.Location = new System.Drawing.Point(387, 186);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 79;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Boutique.Properties.Resources.circulo_de_basura;
            this.pictureBox1.Location = new System.Drawing.Point(387, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // CrearColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 296);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbl_CrearCategoria);
            this.Controls.Add(this.btn_EliminarColor);
            this.Controls.Add(this.lbl_IDColor);
            this.Controls.Add(this.txtbox_IDColor);
            this.Controls.Add(this.DataGrid_Colores);
            this.Controls.Add(this.btn_CrearColor);
            this.Controls.Add(this.lbl_NombreColor);
            this.Controls.Add(this.txtbox_NombreColor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(641, 335);
            this.MinimumSize = new System.Drawing.Size(641, 335);
            this.Name = "CrearColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Gestór de Inventarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearColores_FormClosed);
            this.Load += new System.EventHandler(this.CrearColores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Colores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EliminarColor;
        private System.Windows.Forms.Label lbl_IDColor;
        private System.Windows.Forms.TextBox txtbox_IDColor;
        private System.Windows.Forms.DataGridView DataGrid_Colores;
        private System.Windows.Forms.Button btn_CrearColor;
        private System.Windows.Forms.Label lbl_NombreColor;
        private System.Windows.Forms.TextBox txtbox_NombreColor;
        private System.Windows.Forms.Label lbl_CrearCategoria;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}