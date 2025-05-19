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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            this.btn_EditarUsuario = new System.Windows.Forms.Button();
            this.cmb_Rol = new System.Windows.Forms.ComboBox();
            this.lbl_Rol = new System.Windows.Forms.Label();
            this.lbl_NombreDeUsuario = new System.Windows.Forms.Label();
            this.txtbox_NombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_UsuarioID = new System.Windows.Forms.Label();
            this.txtbox_IdUsuario = new System.Windows.Forms.TextBox();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.txtbox_Correo = new System.Windows.Forms.TextBox();
            this.DataGrid_Usuarios = new System.Windows.Forms.DataGridView();
            this.lbl_CrearCategoria = new System.Windows.Forms.Label();
            this.txtbox_NuevaContra = new System.Windows.Forms.TextBox();
            this.lbl_NuevaContra = new System.Windows.Forms.Label();
            this.txtbox_ReingresoNuevaContra = new System.Windows.Forms.TextBox();
            this.lbl_ReingresoNuevaContra = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_EditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarUsuario.Location = new System.Drawing.Point(518, 323);
            this.btn_EditarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(115, 43);
            this.btn_EditarUsuario.TabIndex = 46;
            this.btn_EditarUsuario.Text = "Editar";
            this.btn_EditarUsuario.UseVisualStyleBackColor = true;
            this.btn_EditarUsuario.Click += new System.EventHandler(this.btn_EditarUsuario_Click);
            // 
            // cmb_Rol
            // 
            this.cmb_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rol.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Rol.FormattingEnabled = true;
            this.cmb_Rol.Location = new System.Drawing.Point(327, 208);
            this.cmb_Rol.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Rol.Name = "cmb_Rol";
            this.cmb_Rol.Size = new System.Drawing.Size(152, 29);
            this.cmb_Rol.TabIndex = 44;
            this.cmb_Rol.SelectedIndexChanged += new System.EventHandler(this.cmb_Rol_SelectedIndexChanged);
            // 
            // lbl_Rol
            // 
            this.lbl_Rol.AutoSize = true;
            this.lbl_Rol.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rol.Location = new System.Drawing.Point(323, 185);
            this.lbl_Rol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Rol.Name = "lbl_Rol";
            this.lbl_Rol.Size = new System.Drawing.Size(39, 21);
            this.lbl_Rol.TabIndex = 43;
            this.lbl_Rol.Text = "Rol:";
            // 
            // lbl_NombreDeUsuario
            // 
            this.lbl_NombreDeUsuario.AutoSize = true;
            this.lbl_NombreDeUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreDeUsuario.Location = new System.Drawing.Point(7, 185);
            this.lbl_NombreDeUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NombreDeUsuario.Name = "lbl_NombreDeUsuario";
            this.lbl_NombreDeUsuario.Size = new System.Drawing.Size(161, 21);
            this.lbl_NombreDeUsuario.TabIndex = 38;
            this.lbl_NombreDeUsuario.Text = "Nombre de usuario:";
            // 
            // txtbox_NombreUsuario
            // 
            this.txtbox_NombreUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_NombreUsuario.Location = new System.Drawing.Point(11, 208);
            this.txtbox_NombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_NombreUsuario.Name = "txtbox_NombreUsuario";
            this.txtbox_NombreUsuario.Size = new System.Drawing.Size(308, 29);
            this.txtbox_NombreUsuario.TabIndex = 37;
            // 
            // lbl_UsuarioID
            // 
            this.lbl_UsuarioID.AutoSize = true;
            this.lbl_UsuarioID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsuarioID.Location = new System.Drawing.Point(492, 185);
            this.lbl_UsuarioID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UsuarioID.Name = "lbl_UsuarioID";
            this.lbl_UsuarioID.Size = new System.Drawing.Size(105, 21);
            this.lbl_UsuarioID.TabIndex = 48;
            this.lbl_UsuarioID.Text = "ID asignado:";
            // 
            // txtbox_IdUsuario
            // 
            this.txtbox_IdUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_IdUsuario.Location = new System.Drawing.Point(496, 208);
            this.txtbox_IdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_IdUsuario.Name = "txtbox_IdUsuario";
            this.txtbox_IdUsuario.ReadOnly = true;
            this.txtbox_IdUsuario.Size = new System.Drawing.Size(134, 29);
            this.txtbox_IdUsuario.TabIndex = 47;
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(5, 313);
            this.lbl_Correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(65, 21);
            this.lbl_Correo.TabIndex = 50;
            this.lbl_Correo.Text = "Correo:";
            // 
            // txtbox_Correo
            // 
            this.txtbox_Correo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Correo.Location = new System.Drawing.Point(7, 336);
            this.txtbox_Correo.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_Correo.Name = "txtbox_Correo";
            this.txtbox_Correo.Size = new System.Drawing.Size(306, 29);
            this.txtbox_Correo.TabIndex = 49;
            // 
            // DataGrid_Usuarios
            // 
            this.DataGrid_Usuarios.BackgroundColor = System.Drawing.Color.Lavender;
            this.DataGrid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Usuarios.GridColor = System.Drawing.SystemColors.Control;
            this.DataGrid_Usuarios.Location = new System.Drawing.Point(11, 56);
            this.DataGrid_Usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid_Usuarios.Name = "DataGrid_Usuarios";
            this.DataGrid_Usuarios.RowHeadersWidth = 51;
            this.DataGrid_Usuarios.RowTemplate.Height = 24;
            this.DataGrid_Usuarios.Size = new System.Drawing.Size(622, 114);
            this.DataGrid_Usuarios.TabIndex = 51;
            this.DataGrid_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Usuarios_CellClick);
            this.DataGrid_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Usuarios_CellContentClick);
            // 
            // lbl_CrearCategoria
            // 
            this.lbl_CrearCategoria.AutoSize = true;
            this.lbl_CrearCategoria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_CrearCategoria.Location = new System.Drawing.Point(11, 9);
            this.lbl_CrearCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CrearCategoria.Name = "lbl_CrearCategoria";
            this.lbl_CrearCategoria.Size = new System.Drawing.Size(235, 39);
            this.lbl_CrearCategoria.TabIndex = 141;
            this.lbl_CrearCategoria.Text = "Modificar Usuario";
            // 
            // txtbox_NuevaContra
            // 
            this.txtbox_NuevaContra.Enabled = false;
            this.txtbox_NuevaContra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_NuevaContra.Location = new System.Drawing.Point(9, 272);
            this.txtbox_NuevaContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_NuevaContra.Name = "txtbox_NuevaContra";
            this.txtbox_NuevaContra.ReadOnly = true;
            this.txtbox_NuevaContra.Size = new System.Drawing.Size(306, 29);
            this.txtbox_NuevaContra.TabIndex = 39;
            // 
            // lbl_NuevaContra
            // 
            this.lbl_NuevaContra.AutoSize = true;
            this.lbl_NuevaContra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NuevaContra.Location = new System.Drawing.Point(7, 249);
            this.lbl_NuevaContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NuevaContra.Name = "lbl_NuevaContra";
            this.lbl_NuevaContra.Size = new System.Drawing.Size(154, 21);
            this.lbl_NuevaContra.TabIndex = 40;
            this.lbl_NuevaContra.Text = "Nueva Contraseña:";
            // 
            // txtbox_ReingresoNuevaContra
            // 
            this.txtbox_ReingresoNuevaContra.Enabled = false;
            this.txtbox_ReingresoNuevaContra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ReingresoNuevaContra.Location = new System.Drawing.Point(327, 272);
            this.txtbox_ReingresoNuevaContra.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_ReingresoNuevaContra.Name = "txtbox_ReingresoNuevaContra";
            this.txtbox_ReingresoNuevaContra.ReadOnly = true;
            this.txtbox_ReingresoNuevaContra.Size = new System.Drawing.Size(306, 29);
            this.txtbox_ReingresoNuevaContra.TabIndex = 41;
            // 
            // lbl_ReingresoNuevaContra
            // 
            this.lbl_ReingresoNuevaContra.AutoSize = true;
            this.lbl_ReingresoNuevaContra.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReingresoNuevaContra.Location = new System.Drawing.Point(323, 249);
            this.lbl_ReingresoNuevaContra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ReingresoNuevaContra.Name = "lbl_ReingresoNuevaContra";
            this.lbl_ReingresoNuevaContra.Size = new System.Drawing.Size(233, 21);
            this.lbl_ReingresoNuevaContra.TabIndex = 42;
            this.lbl_ReingresoNuevaContra.Text = "Reingrese Nueva Contraseña:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Proyecto_Boutique.Properties.Resources.modificar;
            this.pictureBox5.Location = new System.Drawing.Point(468, 323);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 144;
            this.pictureBox5.TabStop = false;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 383);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbl_CrearCategoria);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(663, 422);
            this.MinimumSize = new System.Drawing.Size(663, 422);
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditarUsuario;
        private System.Windows.Forms.Label lbl_Rol;
        private System.Windows.Forms.Label lbl_NombreDeUsuario;
        private System.Windows.Forms.Label lbl_UsuarioID;
        private System.Windows.Forms.Label lbl_Correo;
        public System.Windows.Forms.TextBox txtbox_IdUsuario;
        public System.Windows.Forms.TextBox txtbox_Correo;
        public System.Windows.Forms.ComboBox cmb_Rol;
        public System.Windows.Forms.TextBox txtbox_NombreUsuario;
        private System.Windows.Forms.DataGridView DataGrid_Usuarios;
        private System.Windows.Forms.Label lbl_CrearCategoria;
        public System.Windows.Forms.TextBox txtbox_NuevaContra;
        private System.Windows.Forms.Label lbl_NuevaContra;
        public System.Windows.Forms.TextBox txtbox_ReingresoNuevaContra;
        private System.Windows.Forms.Label lbl_ReingresoNuevaContra;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}