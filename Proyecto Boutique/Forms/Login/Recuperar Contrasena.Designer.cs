namespace Proyecto_Boutique
{
    partial class Recuperar_Contrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar_Contrasena));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre de usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(140, 286);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(368, 34);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(51, 286);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 2;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.Black;
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_enviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_enviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_enviar.Location = new System.Drawing.Point(245, 348);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(159, 54);
            this.btn_enviar.TabIndex = 3;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Proyecto_Boutique.Properties.Resources.deshacer;
            this.pictureBox5.Location = new System.Drawing.Point(16, 15);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 39);
            this.label2.TabIndex = 46;
            this.label2.Text = "Recuperación de Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Boutique.Properties.Resources.LOGO_11;
            this.pictureBox1.Location = new System.Drawing.Point(140, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Recuperar_Contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(662, 453);
            this.MinimumSize = new System.Drawing.Size(662, 453);
            this.Name = "Recuperar_Contrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Gestór de Inventarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recuperar_Contrasena_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}