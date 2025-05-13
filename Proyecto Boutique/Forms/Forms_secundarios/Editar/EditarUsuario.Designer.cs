namespace Proyecto_Boutique
{
    partial class EditarUsuario
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
            this.btn_EditarUsuario = new System.Windows.Forms.Button();
            this.cmb_Rol = new System.Windows.Forms.ComboBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.lbl_ReingresoNuevaContra = new System.Windows.Forms.Label();
            this.txtbox_ReingresoNuevaContra = new System.Windows.Forms.TextBox();
            this.lbl_NuevaContra = new System.Windows.Forms.Label();
            this.txtbox_NuevaContra = new System.Windows.Forms.TextBox();
            this.lbl_NombreDeUsuario = new System.Windows.Forms.Label();
            this.txtbox_NombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_EditarUsuario = new System.Windows.Forms.Label();
            this.lbl_UsuarioID = new System.Windows.Forms.Label();
            this.txtbox_IdUsuario = new System.Windows.Forms.TextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.txtbox_Correo = new System.Windows.Forms.TextBox();
            this.DataGrid_Usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.Location = new System.Drawing.Point(177, 602);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(153, 45);
            this.btn_EditarUsuario.TabIndex = 46;
            this.btn_EditarUsuario.Text = "Editar Usuario";
            this.btn_EditarUsuario.UseVisualStyleBackColor = true;
            this.btn_EditarUsuario.Click += new System.EventHandler(this.btn_EditarUsuario_Click);
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Location = new System.Drawing.Point(45, 406);
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Size = new System.Drawing.Size(407, 24);
            this.cmb_Rol.TabIndex = 44;
            this.cmb_Rol.SelectedIndexChanged += new System.EventHandler(this.cmb_Rol_SelectedIndexChanged);
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Location = new System.Drawing.Point(42, 378);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(28, 16);
            this.lbl_Rol.TabIndex = 43;
            this.lbl_Rol.Text = "Rol";
            // 
            // lbl_ReingresoNuevaContra
            // 
            this.lbl_ReingresoNuevaContra.AutoSize = true;
            this.lbl_ReingresoNuevaContra.Location = new System.Drawing.Point(42, 312);
            this.lbl_ReingresoNuevaContra.Name = "lbl_ReingresoNuevaContra";
            this.lbl_ReingresoNuevaContra.Size = new System.Drawing.Size(185, 16);
            this.lbl_ReingresoNuevaContra.TabIndex = 42;
            this.lbl_ReingresoNuevaContra.Text = "Reingrese Nueva Contraseña";
            // 
            // txtbox_ReingresoNuevaContra
            // 
            this.txtbox_ReingresoNuevaContra.Location = new System.Drawing.Point(45, 331);
            this.txtbox_ReingresoNuevaContra.Name = "txtbox_ReingresoNuevaContra";
            this.txtbox_ReingresoNuevaContra.Size = new System.Drawing.Size(407, 22);
            this.txtbox_ReingresoNuevaContra.TabIndex = 41;
            // 
            // lbl_NuevaContra
            // 
            this.lbl_NuevaContra.AutoSize = true;
            this.lbl_NuevaContra.Location = new System.Drawing.Point(42, 247);
            this.lbl_NuevaContra.Name = "lbl_NuevaContra";
            this.lbl_NuevaContra.Size = new System.Drawing.Size(119, 16);
            this.lbl_NuevaContra.TabIndex = 40;
            this.lbl_NuevaContra.Text = "Nueva Contraseña";
            // 
            // txtbox_NuevaContra
            // 
            this.txtbox_NuevaContra.Location = new System.Drawing.Point(45, 266);
            this.txtbox_NuevaContra.Name = "txtbox_NuevaContra";
            this.txtbox_NuevaContra.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NuevaContra.TabIndex = 39;
            // 
            // lbl_NombreDeUsuario
            // 
            this.lbl_NombreDeUsuario.AutoSize = true;
            this.lbl_NombreDeUsuario.Location = new System.Drawing.Point(42, 183);
            this.lbl_NombreDeUsuario.Name = "lbl_NombreDeUsuario";
            this.lbl_NombreDeUsuario.Size = new System.Drawing.Size(125, 16);
            this.lbl_NombreDeUsuario.TabIndex = 38;
            this.lbl_NombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // txtbox_NombreUsuario
            // 
            this.txtbox_NombreUsuario.Location = new System.Drawing.Point(45, 202);
            this.txtbox_NombreUsuario.Name = "txtbox_NombreUsuario";
            this.txtbox_NombreUsuario.Size = new System.Drawing.Size(407, 22);
            this.txtbox_NombreUsuario.TabIndex = 37;
            // 
            // lbl_EditarUsuario
            // 
            this.lbl_EditarUsuario.AutoSize = true;
            this.lbl_EditarUsuario.Location = new System.Drawing.Point(203, 59);
            this.lbl_EditarUsuario.Name = "lbl_EditarUsuario";
            this.lbl_EditarUsuario.Size = new System.Drawing.Size(92, 16);
            this.lbl_EditarUsuario.TabIndex = 36;
            this.lbl_EditarUsuario.Text = "Editar Usuario";
            // 
            // lbl_UsuarioID
            // 
            this.lbl_UsuarioID.AutoSize = true;
            this.lbl_UsuarioID.Location = new System.Drawing.Point(42, 118);
            this.lbl_UsuarioID.Name = "lbl_UsuarioID";
            this.lbl_UsuarioID.Size = new System.Drawing.Size(92, 16);
            this.lbl_UsuarioID.TabIndex = 48;
            this.lbl_UsuarioID.Text = "ID del Usuario";
            // 
            // txtbox_IdUsuario
            // 
            this.txtbox_IdUsuario.Location = new System.Drawing.Point(45, 137);
            this.txtbox_IdUsuario.Name = "txtbox_IdUsuario";
            this.txtbox_IdUsuario.Size = new System.Drawing.Size(407, 22);
            this.txtbox_IdUsuario.TabIndex = 47;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(42, 453);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(48, 16);
            this.lbl_Correo.TabIndex = 50;
            this.lbl_Correo.Text = "Correo";
            // 
            // txtbox_Correo
            // 
            this.txtbox_Correo.Location = new System.Drawing.Point(45, 472);
            this.txtbox_Correo.Name = "txtbox_Correo";
            this.txtbox_Correo.Size = new System.Drawing.Size(407, 22);
            this.txtbox_Correo.TabIndex = 49;
            // 
            // DataGrid_Usuarios
            // 
            this.DataGrid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Usuarios.Location = new System.Drawing.Point(496, 59);
            this.DataGrid_Usuarios.Name = "DataGrid_Usuarios";
            this.DataGrid_Usuarios.RowHeadersWidth = 51;
            this.DataGrid_Usuarios.RowTemplate.Height = 24;
            this.DataGrid_Usuarios.Size = new System.Drawing.Size(586, 638);
            this.DataGrid_Usuarios.TabIndex = 51;
            this.DataGrid_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Usuarios_CellClick);
            this.DataGrid_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Usuarios_CellContentClick);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 771);
            this.Controls.Add(this.DataGrid_Usuarios);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.txtbox_Correo);
            this.Controls.Add(this.lbl_UsuarioID);
            this.Controls.Add(this.txtbox_IdUsuario);
            this.Controls.Add(this.btn_EditarUsuario);
            this.Controls.Add(this.cmb_Rol);
            this.Controls.Add(this.lbl_Rol);
            this.Controls.Add(this.lbl_ReingresoNuevaContra);
            this.Controls.Add(this.txtbox_ReingresoNuevaContra);
            this.Controls.Add(this.lbl_NuevaContra);
            this.Controls.Add(this.txtbox_NuevaContra);
            this.Controls.Add(this.lbl_NombreDeUsuario);
            this.Controls.Add(this.txtbox_NombreUsuario);
            this.Controls.Add(this.lbl_EditarUsuario);
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditarUsuario;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Label lbl_ReingresoNuevaContra;
        private System.Windows.Forms.Label lbl_NuevaContra;
        private System.Windows.Forms.Label lbl_NombreDeUsuario;
        private System.Windows.Forms.Label lbl_EditarUsuario;
        private System.Windows.Forms.Label lbl_UsuarioID;
        private System.Windows.Forms.Label lbl_Correo;
        public System.Windows.Forms.TextBox txtbox_IdUsuario;
        public System.Windows.Forms.TextBox txtbox_Correo;
        public System.Windows.Forms.ComboBox cmb_Rol;
        public System.Windows.Forms.TextBox txtbox_ReingresoNuevaContra;
        public System.Windows.Forms.TextBox txtbox_NuevaContra;
        public System.Windows.Forms.TextBox txtbox_NombreUsuario;
        private System.Windows.Forms.DataGridView DataGrid_Usuarios;
    }
}