namespace Proyecto_Boutique
{
    partial class Inicio_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesion));
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.txt_Contra = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.visiblePassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.Black;
            this.btn_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IniciarSesion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btn_IniciarSesion.FlatAppearance.BorderSize = 0;
            this.btn_IniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_IniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IniciarSesion.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(272, 389);
            this.btn_IniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(203, 49);
            this.btn_IniciarSesion.TabIndex = 3;
            this.btn_IniciarSesion.Text = "Iniciar Sesión";
            this.btn_IniciarSesion.UseVisualStyleBackColor = false;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(131, 218);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(205, 28);
            this.lbl_Correo.TabIndex = 8;
            this.lbl_Correo.Text = "Nombre de usuario :";
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contra.Location = new System.Drawing.Point(129, 298);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(129, 28);
            this.lbl_Contra.TabIndex = 7;
            this.lbl_Contra.Text = "Contraseña: ";
            // 
            // txt_Contra
            // 
            this.txt_Contra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contra.Location = new System.Drawing.Point(135, 326);
            this.txt_Contra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Contra.MaxLength = 15;
            this.txt_Contra.Name = "txt_Contra";
            this.txt_Contra.PasswordChar = '*';
            this.txt_Contra.Size = new System.Drawing.Size(423, 34);
            this.txt_Contra.TabIndex = 2;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(135, 246);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(485, 34);
            this.txt_usuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(227, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Has olvidado tu contraseña?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Boutique.Properties.Resources.LOGO_11;
            this.pictureBox1.Location = new System.Drawing.Point(189, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Proyecto_Boutique.Properties.Resources.hide;
            this.pictureBox2.Location = new System.Drawing.Point(580, 326);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.visiblePassword_Click);
            // 
            // visiblePassword
            // 
            this.visiblePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visiblePassword.Image = global::Proyecto_Boutique.Properties.Resources.hide;
            this.visiblePassword.Location = new System.Drawing.Point(580, 326);
            this.visiblePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visiblePassword.Name = "visiblePassword";
            this.visiblePassword.Size = new System.Drawing.Size(41, 36);
            this.visiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visiblePassword.TabIndex = 11;
            this.visiblePassword.TabStop = false;
            this.visiblePassword.Click += new System.EventHandler(this.visiblePassword_Click);
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.visiblePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.txt_Contra);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(783, 549);
            this.MinimumSize = new System.Drawing.Size(783, 549);
            this.Name = "Inicio_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Gestór de Inventarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Contra;
        private System.Windows.Forms.TextBox txt_Contra;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox visiblePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}