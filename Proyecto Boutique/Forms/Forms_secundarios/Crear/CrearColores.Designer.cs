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
            this.lbl_CrearColores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Colores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EliminarColor
            // 
            this.btn_EliminarColor.Location = new System.Drawing.Point(732, 573);
            this.btn_EliminarColor.Name = "btn_EliminarColor";
            this.btn_EliminarColor.Size = new System.Drawing.Size(153, 45);
            this.btn_EliminarColor.TabIndex = 77;
            this.btn_EliminarColor.Text = "Eliminar Color";
            this.btn_EliminarColor.UseVisualStyleBackColor = true;
            this.btn_EliminarColor.Click += new System.EventHandler(this.btn_EliminarColor_Click);
            // 
            // lbl_IDColor
            // 
            this.lbl_IDColor.AutoSize = true;
            this.lbl_IDColor.Location = new System.Drawing.Point(64, 135);
            this.lbl_IDColor.Name = "lbl_IDColor";
            this.lbl_IDColor.Size = new System.Drawing.Size(75, 16);
            this.lbl_IDColor.TabIndex = 76;
            this.lbl_IDColor.Text = "ID del color";
            // 
            // txtbox_IDColor
            // 
            this.txtbox_IDColor.Location = new System.Drawing.Point(67, 154);
            this.txtbox_IDColor.Name = "txtbox_IDColor";
            this.txtbox_IDColor.Size = new System.Drawing.Size(407, 22);
            this.txtbox_IDColor.TabIndex = 75;
            this.txtbox_IDColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_IDColor_KeyPress);
            // 
            // DataGrid_Colores
            // 
            this.DataGrid_Colores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Colores.Location = new System.Drawing.Point(586, 120);
            this.DataGrid_Colores.Name = "DataGrid_Colores";
            this.DataGrid_Colores.RowHeadersWidth = 51;
            this.DataGrid_Colores.RowTemplate.Height = 24;
            this.DataGrid_Colores.Size = new System.Drawing.Size(431, 437);
            this.DataGrid_Colores.TabIndex = 74;
            // 
            // btn_CrearColor
            // 
            this.btn_CrearColor.Location = new System.Drawing.Point(183, 387);
            this.btn_CrearColor.Name = "btn_CrearColor";
            this.btn_CrearColor.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearColor.TabIndex = 73;
            this.btn_CrearColor.Text = "Registrar Color";
            this.btn_CrearColor.UseVisualStyleBackColor = true;
            this.btn_CrearColor.Click += new System.EventHandler(this.btn_CrearColor_Click);
            // 
            // lbl_NombreColor
            // 
            this.lbl_NombreColor.AutoSize = true;
            this.lbl_NombreColor.Location = new System.Drawing.Point(64, 205);
            this.lbl_NombreColor.Name = "lbl_NombreColor";
            this.lbl_NombreColor.Size = new System.Drawing.Size(111, 16);
            this.lbl_NombreColor.TabIndex = 71;
            this.lbl_NombreColor.Text = "Nombre del color";
            // 
            // txtbox_NombreColor
            // 
            this.txtbox_NombreColor.Location = new System.Drawing.Point(67, 224);
            this.txtbox_NombreColor.MaxLength = 15;
            this.txtbox_NombreColor.Name = "txtbox_NombreColor";
            this.txtbox_NombreColor.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NombreColor.TabIndex = 70;
            // 
            // lbl_CrearColores
            // 
            this.lbl_CrearColores.AutoSize = true;
            this.lbl_CrearColores.Location = new System.Drawing.Point(213, 78);
            this.lbl_CrearColores.Name = "lbl_CrearColores";
            this.lbl_CrearColores.Size = new System.Drawing.Size(90, 16);
            this.lbl_CrearColores.TabIndex = 69;
            this.lbl_CrearColores.Text = "Crear Colores";
            // 
            // CrearColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 713);
            this.Controls.Add(this.btn_EliminarColor);
            this.Controls.Add(this.lbl_IDColor);
            this.Controls.Add(this.txtbox_IDColor);
            this.Controls.Add(this.DataGrid_Colores);
            this.Controls.Add(this.btn_CrearColor);
            this.Controls.Add(this.lbl_NombreColor);
            this.Controls.Add(this.txtbox_NombreColor);
            this.Controls.Add(this.lbl_CrearColores);
            this.Name = "CrearColores";
            this.Text = "CrearColores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearColores_FormClosed);
            this.Load += new System.EventHandler(this.CrearColores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Colores)).EndInit();
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
        private System.Windows.Forms.Label lbl_CrearColores;
    }
}