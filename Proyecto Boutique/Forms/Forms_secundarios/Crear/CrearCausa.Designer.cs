namespace Proyecto_Boutique.Forms.Forms_secundarios.Crear
{
    partial class CrearCausa
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
            this.btn_EliminarCausa = new System.Windows.Forms.Button();
            this.lbl_IDCausa = new System.Windows.Forms.Label();
            this.txtbox_IDCausa = new System.Windows.Forms.TextBox();
            this.DataGrid_Causas = new System.Windows.Forms.DataGridView();
            this.btn_CrearCausa = new System.Windows.Forms.Button();
            this.lbl_NombreCausa = new System.Windows.Forms.Label();
            this.txtbox_NombreCausa = new System.Windows.Forms.TextBox();
            this.lbl_CrearCausa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Causas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EliminarCausa
            // 
            this.btn_EliminarCausa.Location = new System.Drawing.Point(714, 591);
            this.btn_EliminarCausa.Name = "btn_EliminarCausa";
            this.btn_EliminarCausa.Size = new System.Drawing.Size(153, 45);
            this.btn_EliminarCausa.TabIndex = 86;
            this.btn_EliminarCausa.Text = "Eliminar Causa";
            this.btn_EliminarCausa.UseVisualStyleBackColor = true;
            this.btn_EliminarCausa.Click += new System.EventHandler(this.btn_EliminarCausa_Click);
            // 
            // lbl_IDCausa
            // 
            this.lbl_IDCausa.AutoSize = true;
            this.lbl_IDCausa.Location = new System.Drawing.Point(46, 153);
            this.lbl_IDCausa.Name = "lbl_IDCausa";
            this.lbl_IDCausa.Size = new System.Drawing.Size(95, 16);
            this.lbl_IDCausa.TabIndex = 85;
            this.lbl_IDCausa.Text = "ID de la Causa";
            // 
            // txtbox_IDCausa
            // 
            this.txtbox_IDCausa.Location = new System.Drawing.Point(49, 172);
            this.txtbox_IDCausa.Name = "txtbox_IDCausa";
            this.txtbox_IDCausa.ReadOnly = true;
            this.txtbox_IDCausa.Size = new System.Drawing.Size(407, 22);
            this.txtbox_IDCausa.TabIndex = 84;
            this.txtbox_IDCausa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_IDCausa_KeyPress);
            // 
            // DataGrid_Causas
            // 
            this.DataGrid_Causas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Causas.Location = new System.Drawing.Point(568, 138);
            this.DataGrid_Causas.Name = "DataGrid_Causas";
            this.DataGrid_Causas.RowHeadersWidth = 51;
            this.DataGrid_Causas.RowTemplate.Height = 24;
            this.DataGrid_Causas.Size = new System.Drawing.Size(431, 437);
            this.DataGrid_Causas.TabIndex = 83;
            // 
            // btn_CrearCausa
            // 
            this.btn_CrearCausa.Location = new System.Drawing.Point(165, 393);
            this.btn_CrearCausa.Name = "btn_CrearCausa";
            this.btn_CrearCausa.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearCausa.TabIndex = 82;
            this.btn_CrearCausa.Text = "Registrar Causa";
            this.btn_CrearCausa.UseVisualStyleBackColor = true;
            this.btn_CrearCausa.Click += new System.EventHandler(this.btn_CrearCausa_Click);
            // 
            // lbl_NombreCausa
            // 
            this.lbl_NombreCausa.AutoSize = true;
            this.lbl_NombreCausa.Location = new System.Drawing.Point(46, 223);
            this.lbl_NombreCausa.Name = "lbl_NombreCausa";
            this.lbl_NombreCausa.Size = new System.Drawing.Size(131, 16);
            this.lbl_NombreCausa.TabIndex = 80;
            this.lbl_NombreCausa.Text = "Nombre de la Causa";
            // 
            // txtbox_NombreCausa
            // 
            this.txtbox_NombreCausa.Location = new System.Drawing.Point(49, 242);
            this.txtbox_NombreCausa.MaxLength = 50;
            this.txtbox_NombreCausa.Name = "txtbox_NombreCausa";
            this.txtbox_NombreCausa.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NombreCausa.TabIndex = 79;
            // 
            // lbl_CrearCausa
            // 
            this.lbl_CrearCausa.AutoSize = true;
            this.lbl_CrearCausa.Location = new System.Drawing.Point(195, 96);
            this.lbl_CrearCausa.Name = "lbl_CrearCausa";
            this.lbl_CrearCausa.Size = new System.Drawing.Size(82, 16);
            this.lbl_CrearCausa.TabIndex = 78;
            this.lbl_CrearCausa.Text = "Crear Causa";
            // 
            // CrearCausa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 723);
            this.Controls.Add(this.btn_EliminarCausa);
            this.Controls.Add(this.lbl_IDCausa);
            this.Controls.Add(this.txtbox_IDCausa);
            this.Controls.Add(this.DataGrid_Causas);
            this.Controls.Add(this.btn_CrearCausa);
            this.Controls.Add(this.lbl_NombreCausa);
            this.Controls.Add(this.txtbox_NombreCausa);
            this.Controls.Add(this.lbl_CrearCausa);
            this.Name = "CrearCausa";
            this.Text = "CrearCausa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearCausa_FormClosed);
            this.Load += new System.EventHandler(this.CrearCausa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Causas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EliminarCausa;
        private System.Windows.Forms.Label lbl_IDCausa;
        private System.Windows.Forms.TextBox txtbox_IDCausa;
        private System.Windows.Forms.DataGridView DataGrid_Causas;
        private System.Windows.Forms.Button btn_CrearCausa;
        private System.Windows.Forms.Label lbl_NombreCausa;
        private System.Windows.Forms.TextBox txtbox_NombreCausa;
        private System.Windows.Forms.Label lbl_CrearCausa;
    }
}