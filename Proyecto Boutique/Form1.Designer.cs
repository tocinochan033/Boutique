namespace Proyecto_Boutique
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Contra = new System.Windows.Forms.TextBox();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.btn_IniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(195, 210);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(485, 22);
            this.txt_Correo.TabIndex = 0;
            // 
            // txt_Contra
            // 
            this.txt_Contra.Location = new System.Drawing.Point(195, 301);
            this.txt_Contra.Name = "txt_Contra";
            this.txt_Contra.Size = new System.Drawing.Size(485, 22);
            this.txt_Contra.TabIndex = 1;
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.Location = new System.Drawing.Point(192, 282);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(76, 16);
            this.lbl_Contra.TabIndex = 2;
            this.lbl_Contra.Text = "Contraseña";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(192, 191);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(118, 16);
            this.lbl_Correo.TabIndex = 3;
            this.lbl_Correo.Text = "Correo Electronico";
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Location = new System.Drawing.Point(360, 381);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Size = new System.Drawing.Size(135, 49);
            this.btn_IniciarSesion.TabIndex = 4;
            this.btn_IniciarSesion.Text = "Iniciar Sesion";
            this.btn_IniciarSesion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 551);
            this.Controls.Add(this.btn_IniciarSesion);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.txt_Contra);
            this.Controls.Add(this.txt_Correo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Contra;
        private System.Windows.Forms.Label lbl_Contra;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Button btn_IniciarSesion;
    }
}

