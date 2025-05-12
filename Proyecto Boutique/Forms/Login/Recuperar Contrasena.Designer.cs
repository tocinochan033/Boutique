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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.regresar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(220, 122);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(172, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(44, 265);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 2;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(272, 190);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(99, 35);
            this.btn_enviar.TabIndex = 3;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // regresar_btn
            // 
            this.regresar_btn.Location = new System.Drawing.Point(389, 190);
            this.regresar_btn.Name = "regresar_btn";
            this.regresar_btn.Size = new System.Drawing.Size(99, 35);
            this.regresar_btn.TabIndex = 4;
            this.regresar_btn.Text = "Regresar";
            this.regresar_btn.UseVisualStyleBackColor = true;
            this.regresar_btn.Click += new System.EventHandler(this.regresar_btn_Click);
            // 
            // Recuperar_Contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regresar_btn);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Name = "Recuperar_Contrasena";
            this.Text = "Recuperar_Contrasena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button regresar_btn;
    }
}