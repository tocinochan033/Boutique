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
            this.visiblePassword = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Location = new System.Drawing.Point(231, 251);
            this.btn_IniciarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(101, 40);
            this.btn_IniciarSesion.TabIndex = 9;
            this.btn_IniciarSesion.Text = "Iniciar Sesion";
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(106, 134);
            this.lbl_Correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(43, 13);
            this.lbl_Correo.TabIndex = 8;
            this.lbl_Correo.Text = "Usuario";
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.Location = new System.Drawing.Point(106, 193);
            this.lbl_Contra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contra.TabIndex = 7;
            this.lbl_Contra.Text = "Contraseña";
            // 
            // txt_Contra
            // 
            this.txt_Contra.Location = new System.Drawing.Point(108, 208);
            this.txt_Contra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Contra.MaxLength = 15;
            this.txt_Contra.Name = "txt_Contra";
            this.txt_Contra.PasswordChar = '*';
            this.txt_Contra.Size = new System.Drawing.Size(365, 20);
            this.txt_Contra.TabIndex = 6;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(108, 149);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_usuario.MaxLength = 20;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(365, 20);
            this.txt_usuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 324);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "¿Has olvidado tu contraseña?";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // visiblePassword
            // 
            this.visiblePassword.Image = global::Proyecto_Boutique.Properties.Resources.hide;
            this.visiblePassword.Location = new System.Drawing.Point(484, 209);
            this.visiblePassword.Margin = new System.Windows.Forms.Padding(2);
            this.visiblePassword.Name = "visiblePassword";
            this.visiblePassword.Size = new System.Drawing.Size(22, 24);
            this.visiblePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.visiblePassword.TabIndex = 11;
            this.visiblePassword.TabStop = false;
            this.visiblePassword.Click += new System.EventHandler(this.visiblePassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(232, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.visiblePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.txt_Contra);
            this.Controls.Add(this.txt_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Inicio_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| STYLE BOUTIQUE | Software Gestór de Inventarios";
            ((System.ComponentModel.ISupportInitialize)(this.visiblePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}