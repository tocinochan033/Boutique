namespace Proyecto_Boutique
{
    partial class CrearUsuario
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
            this.lbl_CrearUsuario = new System.Windows.Forms.Label();
            this.txtbox_NombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_NombreDeUsuario = new System.Windows.Forms.Label();
            this.lbl_Contra = new System.Windows.Forms.Label();
            this.txtbox_Contra = new System.Windows.Forms.TextBox();
            this.lbl_ReingresoContra = new System.Windows.Forms.Label();
            this.txtbox_ReingresoContra = new System.Windows.Forms.TextBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.cmb_Rol = new System.Windows.Forms.ComboBox();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CrearUsuario
            // 
            this.lbl_CrearUsuario.AutoSize = true;
            this.lbl_CrearUsuario.Location = new System.Drawing.Point(516, 130);
            this.lbl_CrearUsuario.Name = "lbl_CrearUsuario";
            this.lbl_CrearUsuario.Size = new System.Drawing.Size(90, 16);
            this.lbl_CrearUsuario.TabIndex = 18;
            this.lbl_CrearUsuario.Text = "Crear Usuario";
            // 
            // txtbox_NombreUsuario
            // 
            this.txtbox_NombreUsuario.Location = new System.Drawing.Point(353, 208);
            this.txtbox_NombreUsuario.Name = "txtbox_NombreUsuario";
            this.txtbox_NombreUsuario.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NombreUsuario.TabIndex = 19;
            // 
            // lbl_NombreDeUsuario
            // 
            this.lbl_NombreDeUsuario.AutoSize = true;
            this.lbl_NombreDeUsuario.Location = new System.Drawing.Point(350, 189);
            this.lbl_NombreDeUsuario.Name = "lbl_NombreDeUsuario";
            this.lbl_NombreDeUsuario.Size = new System.Drawing.Size(125, 16);
            this.lbl_NombreDeUsuario.TabIndex = 20;
            this.lbl_NombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // lbl_Contra
            // 
            this.lbl_Contra.AutoSize = true;
            this.lbl_Contra.Location = new System.Drawing.Point(350, 253);
            this.lbl_Contra.Name = "lbl_Contra";
            this.lbl_Contra.Size = new System.Drawing.Size(76, 16);
            this.lbl_Contra.TabIndex = 22;
            this.lbl_Contra.Text = "Contraseña";
            // 
            // txtbox_Contra
            // 
            this.txtbox_Contra.Location = new System.Drawing.Point(353, 272);
            this.txtbox_Contra.Name = "txtbox_Contra";
            this.txtbox_Contra.Size = new System.Drawing.Size(407, 22);
            this.txtbox_Contra.TabIndex = 21;
            // 
            // lbl_ReingresoContra
            // 
            this.lbl_ReingresoContra.AutoSize = true;
            this.lbl_ReingresoContra.Location = new System.Drawing.Point(350, 318);
            this.lbl_ReingresoContra.Name = "lbl_ReingresoContra";
            this.lbl_ReingresoContra.Size = new System.Drawing.Size(142, 16);
            this.lbl_ReingresoContra.TabIndex = 24;
            this.lbl_ReingresoContra.Text = "Reingrese Contraseña";
            // 
            // txtbox_ReingresoContra
            // 
            this.txtbox_ReingresoContra.Location = new System.Drawing.Point(353, 337);
            this.txtbox_ReingresoContra.Name = "txtbox_ReingresoContra";
            this.txtbox_ReingresoContra.Size = new System.Drawing.Size(407, 22);
            this.txtbox_ReingresoContra.TabIndex = 23;
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(350, 389);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(28, 16);
            this.lbl_Rol.TabIndex = 26;
            this.lbl_Rol.Text = "Rol";
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Location = new System.Drawing.Point(353, 417);
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Size = new System.Drawing.Size(407, 24);
            this.cmb_Rol.TabIndex = 27;
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.Location = new System.Drawing.Point(574, 534);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearUsuario.TabIndex = 29;
            this.btn_CrearUsuario.Text = "Crear Usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(388, 534);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(153, 45);
            this.btn_Regresar.TabIndex = 28;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 685);
            this.Controls.Add(this.btn_CrearUsuario);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.cmb_Rol);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.lbl_ReingresoContra);
            this.Controls.Add(this.txtbox_ReingresoContra);
            this.Controls.Add(this.lbl_Contra);
            this.Controls.Add(this.txtbox_Contra);
            this.Controls.Add(this.lbl_NombreDeUsuario);
            this.Controls.Add(this.txtbox_NombreUsuario);
            this.Controls.Add(this.lbl_CrearUsuario);
            this.Name = "CrearUsuario";
            this.Text = "CrearUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_CrearUsuario;
        private System.Windows.Forms.TextBox txtbox_NombreUsuario;
        private System.Windows.Forms.Label lbl_NombreDeUsuario;
        private System.Windows.Forms.Label lbl_Contra;
        private System.Windows.Forms.TextBox txtbox_Contra;
        private System.Windows.Forms.Label lbl_ReingresoContra;
        private System.Windows.Forms.TextBox txtbox_ReingresoContra;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.ComboBox cmb_Rol;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.Button btn_Regresar;
    }
}