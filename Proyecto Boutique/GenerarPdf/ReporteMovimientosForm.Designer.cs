namespace Proyecto_Boutique
{
    partial class ReporteMovimientosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMovimientosForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Generar_Click = new System.Windows.Forms.Button();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lbl_Usuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo de Movimiento:";
            // 
            // Generar_Click
            // 
            this.Generar_Click.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.Generar_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generar_Click.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar_Click.Location = new System.Drawing.Point(462, 106);
            this.Generar_Click.Margin = new System.Windows.Forms.Padding(2);
            this.Generar_Click.Name = "Generar_Click";
            this.Generar_Click.Size = new System.Drawing.Size(111, 60);
            this.Generar_Click.TabIndex = 11;
            this.Generar_Click.Text = "Generar";
            this.Generar_Click.UseVisualStyleBackColor = true;
            this.Generar_Click.Click += new System.EventHandler(this.Generar_Click_Click);
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(188, 117);
            this.cmbTipoMovimiento.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(263, 29);
            this.cmbTipoMovimiento.TabIndex = 10;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Location = new System.Drawing.Point(361, 63);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(212, 29);
            this.dtpFechaHasta.TabIndex = 9;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Location = new System.Drawing.Point(83, 63);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(213, 29);
            this.dtpFechaDesde.TabIndex = 8;
            // 
            // lbl_Usuarios
            // 
            this.lbl_Usuarios.AutoSize = true;
            this.lbl_Usuarios.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Usuarios.Location = new System.Drawing.Point(11, 9);
            this.lbl_Usuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Usuarios.Name = "lbl_Usuarios";
            this.lbl_Usuarios.Size = new System.Drawing.Size(317, 39);
            this.lbl_Usuarios.TabIndex = 21;
            this.lbl_Usuarios.Text = "Reportes de Movimiento";
            // 
            // ReporteMovimientosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 186);
            this.Controls.Add(this.lbl_Usuarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generar_Click);
            this.Controls.Add(this.cmbTipoMovimiento);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(607, 225);
            this.MinimumSize = new System.Drawing.Size(607, 225);
            this.Name = "ReporteMovimientosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Gestór de Inventarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Generar_Click;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lbl_Usuarios;
    }
}