namespace Proyecto_Boutique.Forms.GenerarPDF
{
    partial class ReporteMoviminetosForm
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
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.Generar_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(12, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(318, 26);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(394, 12);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(317, 26);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // cmbTipoMovimiento
            // 
            this.cmbTipoMovimiento.FormattingEnabled = true;
            this.cmbTipoMovimiento.Location = new System.Drawing.Point(138, 68);
            this.cmbTipoMovimiento.Name = "cmbTipoMovimiento";
            this.cmbTipoMovimiento.Size = new System.Drawing.Size(192, 28);
            this.cmbTipoMovimiento.TabIndex = 2;
            // 
            // Generar_Click
            // 
            this.Generar_Click.Location = new System.Drawing.Point(394, 64);
            this.Generar_Click.Name = "Generar_Click";
            this.Generar_Click.Size = new System.Drawing.Size(98, 34);
            this.Generar_Click.TabIndex = 3;
            this.Generar_Click.Text = "Generar";
            this.Generar_Click.UseVisualStyleBackColor = true;
            this.Generar_Click.Click += new System.EventHandler(this.Generar_Click_Click);
            // 
            // ReporteMoviminetosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 191);
            this.Controls.Add(this.Generar_Click);
            this.Controls.Add(this.cmbTipoMovimiento);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "ReporteMoviminetosForm";
            this.Text = "ReporteMoviminetosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.ComboBox cmbTipoMovimiento;
        private System.Windows.Forms.Button Generar_Click;
    }
}