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
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.txt_Contra = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Location = new System.Drawing.Point(324, 296);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(135, 49);
            this.btn_IniciarSesion.TabIndex = 9;
            this.btn_IniciarSesion.Text = "Iniciar Sesion";
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(156, 106);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(118, 16);
            this.lbl_Correo.TabIndex = 8;
            this.lbl_Correo.Text = "Correo Electronico";
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.Location = new System.Drawing.Point(156, 197);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(76, 16);
            this.lbl_Contra.TabIndex = 7;
            this.lbl_Contra.Text = "Contraseña";
            // 
            // txt_Contra
            // 
            this.txt_Contra.Location = new System.Drawing.Point(159, 216);
            this.txt_Contra.Name = "txt_Contra";
            this.txt_Contra.Size = new System.Drawing.Size(485, 22);
            this.txt_Contra.TabIndex = 6;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(159, 125);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(485, 22);
            this.txt_Correo.TabIndex = 5;
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.txt_Contra);
            this.Controls.Add(this.txt_Correo);
            this.Name = "Inicio_Sesion";
            this.Text = "Inicio_Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IniciarSesion;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Contra;
        private System.Windows.Forms.TextBox txt_Contra;
        private System.Windows.Forms.TextBox txt_Correo;
    }
}