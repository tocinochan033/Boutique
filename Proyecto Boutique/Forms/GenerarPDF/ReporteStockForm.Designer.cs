namespace Proyecto_Boutique.Forms.GenerarPDF
{
    partial class ReporteStockForm
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
            this.btnGenerar_Click = new System.Windows.Forms.Button();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerar_Click
            // 
            this.btnGenerar_Click.Location = new System.Drawing.Point(448, 83);
            this.btnGenerar_Click.Name = "btnGenerar_Click";
            this.btnGenerar_Click.Size = new System.Drawing.Size(92, 33);
            this.btnGenerar_Click.TabIndex = 0;
            this.btnGenerar_Click.Text = "Generar";
            this.btnGenerar_Click.UseVisualStyleBackColor = true;
            this.btnGenerar_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(31, 34);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(316, 26);
            this.dtpFechaDesde.TabIndex = 1;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(393, 34);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(323, 26);
            this.dtpFechaHasta.TabIndex = 2;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(104, 86);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(223, 28);
            this.cbCategorias.TabIndex = 3;
            // 
            // ReporteStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 280);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.btnGenerar_Click);
            this.Name = "ReporteStockForm";
            this.Text = "ReporteStockForm";
            this.Load += new System.EventHandler(this.ReporteStockForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar_Click;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.ComboBox cbCategorias;
    }
}