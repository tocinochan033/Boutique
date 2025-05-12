namespace Proyecto_Boutique
{
    partial class CrearMovimiento
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
            this.lbl_Producto = new System.Windows.Forms.Label();
            this.cmb_Producto = new System.Windows.Forms.ComboBox();
            this.lbl_TipoMovimiento = new System.Windows.Forms.Label();
            this.cmb_TipoMovimiento = new System.Windows.Forms.ComboBox();
            this.btn_CrearMovimiento = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txtbox_CantidadProducto = new System.Windows.Forms.TextBox();
            this.lbl_CrearMovimiento = new System.Windows.Forms.Label();
            this.lbl_IDMovimiento = new System.Windows.Forms.Label();
            this.txt_IDMovimiento = new System.Windows.Forms.TextBox();
            this.lbl_UsuarioResponsable = new System.Windows.Forms.Label();
            this.cmb_UsuarioResponsable = new System.Windows.Forms.ComboBox();
            this.lbl_Causa = new System.Windows.Forms.Label();
            this.cmb_Causa = new System.Windows.Forms.ComboBox();
            this.DataGrid_Usuarios = new System.Windows.Forms.DataGridView();
            this.datagrid_Productos = new System.Windows.Forms.DataGridView();
            this.lbl_OpcionesBusquedaUSUARIOS = new System.Windows.Forms.Label();
            this.lbl_BusquedaUSUARIOS = new System.Windows.Forms.Label();
            this.rdbtn_NombreUSUARIOS = new System.Windows.Forms.RadioButton();
            this.rdbtn_IDUSUARIOS = new System.Windows.Forms.RadioButton();
            this.txtbox_BuscarUSUARIO = new System.Windows.Forms.TextBox();
            this.lbl_OpcionesBusquedaPRODUCTOS = new System.Windows.Forms.Label();
            this.lbl_BusquedaPRODUCTOS = new System.Windows.Forms.Label();
            this.rdbtn_NombrePRODUCTOS = new System.Windows.Forms.RadioButton();
            this.rdbtn_IDPRODUCTOS = new System.Windows.Forms.RadioButton();
            this.txtbox_BuscarPRODUCTO = new System.Windows.Forms.TextBox();
            this.lbl_TEXTOproductos = new System.Windows.Forms.Label();
            this.lbl_TEXTOusuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Producto
            // 
            this.lbl_Producto.AutoSize = true;
            this.lbl_Producto.Location = new System.Drawing.Point(53, 264);
            this.lbl_Producto.Name = "lbl_Producto";
            this.lbl_Producto.Size = new System.Drawing.Size(61, 16);
            this.lbl_Producto.TabIndex = 121;
            this.lbl_Producto.Text = "Producto";
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(54, 283);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.Size = new System.Drawing.Size(409, 24);
            this.cmb_Producto.TabIndex = 120;
            // 
            // lbl_TipoMovimiento
            // 
            this.lbl_TipoMovimiento.AutoSize = true;
            this.lbl_TipoMovimiento.Location = new System.Drawing.Point(53, 326);
            this.lbl_TipoMovimiento.Name = "lbl_TipoMovimiento";
            this.lbl_TipoMovimiento.Size = new System.Drawing.Size(126, 16);
            this.lbl_TipoMovimiento.TabIndex = 119;
            this.lbl_TipoMovimiento.Text = "Tipo de movimiento";
            // 
            // cmb_TipoMovimiento
            // 
            this.cmb_TipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoMovimiento.FormattingEnabled = true;
            this.cmb_TipoMovimiento.Location = new System.Drawing.Point(54, 345);
            this.cmb_TipoMovimiento.Name = "cmb_TipoMovimiento";
            this.cmb_TipoMovimiento.Size = new System.Drawing.Size(409, 24);
            this.cmb_TipoMovimiento.TabIndex = 118;
            // 
            // btn_CrearMovimiento
            // 
            this.btn_CrearMovimiento.Location = new System.Drawing.Point(260, 602);
            this.btn_CrearMovimiento.Name = "btn_CrearMovimiento";
            this.btn_CrearMovimiento.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearMovimiento.TabIndex = 117;
            this.btn_CrearMovimiento.Text = "Crear Movimiento";
            this.btn_CrearMovimiento.UseVisualStyleBackColor = true;
            this.btn_CrearMovimiento.Click += new System.EventHandler(this.btn_CrearMovimiento_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(74, 602);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(153, 45);
            this.btn_Regresar.TabIndex = 116;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Location = new System.Drawing.Point(53, 391);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(61, 16);
            this.lbl_Cantidad.TabIndex = 113;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // txtbox_CantidadProducto
            // 
            this.txtbox_CantidadProducto.Location = new System.Drawing.Point(56, 410);
            this.txtbox_CantidadProducto.Name = "txtbox_CantidadProducto";
            this.txtbox_CantidadProducto.Size = new System.Drawing.Size(407, 22);
            this.txtbox_CantidadProducto.TabIndex = 112;
            this.txtbox_CantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_CantidadProducto_KeyPress);
            // 
            // lbl_CrearMovimiento
            // 
            this.lbl_CrearMovimiento.AutoSize = true;
            this.lbl_CrearMovimiento.Location = new System.Drawing.Point(212, 90);
            this.lbl_CrearMovimiento.Name = "lbl_CrearMovimiento";
            this.lbl_CrearMovimiento.Size = new System.Drawing.Size(112, 16);
            this.lbl_CrearMovimiento.TabIndex = 111;
            this.lbl_CrearMovimiento.Text = "Crear Movimiento";
            // 
            // lbl_IDMovimiento
            // 
            this.lbl_IDMovimiento.AutoSize = true;
            this.lbl_IDMovimiento.Location = new System.Drawing.Point(51, 136);
            this.lbl_IDMovimiento.Name = "lbl_IDMovimiento";
            this.lbl_IDMovimiento.Size = new System.Drawing.Size(114, 16);
            this.lbl_IDMovimiento.TabIndex = 123;
            this.lbl_IDMovimiento.Text = "ID del Movimiento";
            // 
            // txt_IDMovimiento
            // 
            this.txt_IDMovimiento.Location = new System.Drawing.Point(54, 155);
            this.txt_IDMovimiento.Name = "txt_IDMovimiento";
            this.txt_IDMovimiento.Size = new System.Drawing.Size(407, 22);
            this.txt_IDMovimiento.TabIndex = 124;
            this.txt_IDMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDMovimiento_KeyPress);
            // 
            // lbl_UsuarioResponsable
            // 
            this.lbl_UsuarioResponsable.AutoSize = true;
            this.lbl_UsuarioResponsable.Location = new System.Drawing.Point(53, 196);
            this.lbl_UsuarioResponsable.Name = "lbl_UsuarioResponsable";
            this.lbl_UsuarioResponsable.Size = new System.Drawing.Size(139, 16);
            this.lbl_UsuarioResponsable.TabIndex = 126;
            this.lbl_UsuarioResponsable.Text = "Usuario Responsable";
            // 
            // cmb_UsuarioResponsable
            // 
            this.cmb_UsuarioResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UsuarioResponsable.FormattingEnabled = true;
            this.cmb_UsuarioResponsable.Location = new System.Drawing.Point(54, 215);
            this.cmb_UsuarioResponsable.Name = "cmb_UsuarioResponsable";
            this.cmb_UsuarioResponsable.Size = new System.Drawing.Size(409, 24);
            this.cmb_UsuarioResponsable.TabIndex = 125;
            // 
            // lbl_Causa
            // 
            this.lbl_Causa.AutoSize = true;
            this.lbl_Causa.Location = new System.Drawing.Point(55, 455);
            this.lbl_Causa.Name = "lbl_Causa";
            this.lbl_Causa.Size = new System.Drawing.Size(46, 16);
            this.lbl_Causa.TabIndex = 128;
            this.lbl_Causa.Text = "Causa";
            // 
            // cmb_Causa
            // 
            this.cmb_Causa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Causa.FormattingEnabled = true;
            this.cmb_Causa.Location = new System.Drawing.Point(56, 474);
            this.cmb_Causa.Name = "cmb_Causa";
            this.cmb_Causa.Size = new System.Drawing.Size(409, 24);
            this.cmb_Causa.TabIndex = 127;
            // 
            // DataGrid_Usuarios
            // 
            this.DataGrid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Usuarios.Location = new System.Drawing.Point(560, 120);
            this.DataGrid_Usuarios.Name = "DataGrid_Usuarios";
            this.DataGrid_Usuarios.RowHeadersWidth = 51;
            this.DataGrid_Usuarios.RowTemplate.Height = 24;
            this.DataGrid_Usuarios.Size = new System.Drawing.Size(537, 187);
            this.DataGrid_Usuarios.TabIndex = 129;
            this.DataGrid_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_Usuarios_CellClick);
            // 
            // datagrid_Productos
            // 
            this.datagrid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Productos.Location = new System.Drawing.Point(560, 455);
            this.datagrid_Productos.Name = "datagrid_Productos";
            this.datagrid_Productos.RowHeadersWidth = 51;
            this.datagrid_Productos.RowTemplate.Height = 24;
            this.datagrid_Productos.Size = new System.Drawing.Size(537, 187);
            this.datagrid_Productos.TabIndex = 130;
            this.datagrid_Productos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_Productos_CellClick);
            // 
            // lbl_OpcionesBusquedaUSUARIOS
            // 
            this.lbl_OpcionesBusquedaUSUARIOS.AutoSize = true;
            this.lbl_OpcionesBusquedaUSUARIOS.Location = new System.Drawing.Point(588, 60);
            this.lbl_OpcionesBusquedaUSUARIOS.Name = "lbl_OpcionesBusquedaUSUARIOS";
            this.lbl_OpcionesBusquedaUSUARIOS.Size = new System.Drawing.Size(65, 16);
            this.lbl_OpcionesBusquedaUSUARIOS.TabIndex = 135;
            this.lbl_OpcionesBusquedaUSUARIOS.Text = "Opciones";
            // 
            // lbl_BusquedaUSUARIOS
            // 
            this.lbl_BusquedaUSUARIOS.AutoSize = true;
            this.lbl_BusquedaUSUARIOS.Location = new System.Drawing.Point(584, 87);
            this.lbl_BusquedaUSUARIOS.Name = "lbl_BusquedaUSUARIOS";
            this.lbl_BusquedaUSUARIOS.Size = new System.Drawing.Size(69, 16);
            this.lbl_BusquedaUSUARIOS.TabIndex = 134;
            this.lbl_BusquedaUSUARIOS.Text = "Busqueda";
            // 
            // rdbtn_NombreUSUARIOS
            // 
            this.rdbtn_NombreUSUARIOS.AutoSize = true;
            this.rdbtn_NombreUSUARIOS.Location = new System.Drawing.Point(768, 58);
            this.rdbtn_NombreUSUARIOS.Name = "rdbtn_NombreUSUARIOS";
            this.rdbtn_NombreUSUARIOS.Size = new System.Drawing.Size(77, 20);
            this.rdbtn_NombreUSUARIOS.TabIndex = 133;
            this.rdbtn_NombreUSUARIOS.TabStop = true;
            this.rdbtn_NombreUSUARIOS.Text = "Nombre";
            this.rdbtn_NombreUSUARIOS.UseVisualStyleBackColor = true;
            // 
            // rdbtn_IDUSUARIOS
            // 
            this.rdbtn_IDUSUARIOS.AutoSize = true;
            this.rdbtn_IDUSUARIOS.Location = new System.Drawing.Point(659, 58);
            this.rdbtn_IDUSUARIOS.Name = "rdbtn_IDUSUARIOS";
            this.rdbtn_IDUSUARIOS.Size = new System.Drawing.Size(41, 20);
            this.rdbtn_IDUSUARIOS.TabIndex = 132;
            this.rdbtn_IDUSUARIOS.TabStop = true;
            this.rdbtn_IDUSUARIOS.Text = "ID";
            this.rdbtn_IDUSUARIOS.UseVisualStyleBackColor = true;
            // 
            // txtbox_BuscarUSUARIO
            // 
            this.txtbox_BuscarUSUARIO.Location = new System.Drawing.Point(659, 84);
            this.txtbox_BuscarUSUARIO.Name = "txtbox_BuscarUSUARIO";
            this.txtbox_BuscarUSUARIO.Size = new System.Drawing.Size(407, 22);
            this.txtbox_BuscarUSUARIO.TabIndex = 131;
            this.txtbox_BuscarUSUARIO.TextChanged += new System.EventHandler(this.txtbox_BuscarUSUARIO_TextChanged);
            // 
            // lbl_OpcionesBusquedaPRODUCTOS
            // 
            this.lbl_OpcionesBusquedaPRODUCTOS.AutoSize = true;
            this.lbl_OpcionesBusquedaPRODUCTOS.Location = new System.Drawing.Point(600, 403);
            this.lbl_OpcionesBusquedaPRODUCTOS.Name = "lbl_OpcionesBusquedaPRODUCTOS";
            this.lbl_OpcionesBusquedaPRODUCTOS.Size = new System.Drawing.Size(65, 16);
            this.lbl_OpcionesBusquedaPRODUCTOS.TabIndex = 140;
            this.lbl_OpcionesBusquedaPRODUCTOS.Text = "Opciones";
            // 
            // lbl_BusquedaPRODUCTOS
            // 
            this.lbl_BusquedaPRODUCTOS.AutoSize = true;
            this.lbl_BusquedaPRODUCTOS.Location = new System.Drawing.Point(596, 430);
            this.lbl_BusquedaPRODUCTOS.Name = "lbl_BusquedaPRODUCTOS";
            this.lbl_BusquedaPRODUCTOS.Size = new System.Drawing.Size(69, 16);
            this.lbl_BusquedaPRODUCTOS.TabIndex = 139;
            this.lbl_BusquedaPRODUCTOS.Text = "Busqueda";
            // 
            // rdbtn_NombrePRODUCTOS
            // 
            this.rdbtn_NombrePRODUCTOS.AutoSize = true;
            this.rdbtn_NombrePRODUCTOS.Location = new System.Drawing.Point(780, 401);
            this.rdbtn_NombrePRODUCTOS.Name = "rdbtn_NombrePRODUCTOS";
            this.rdbtn_NombrePRODUCTOS.Size = new System.Drawing.Size(77, 20);
            this.rdbtn_NombrePRODUCTOS.TabIndex = 138;
            this.rdbtn_NombrePRODUCTOS.TabStop = true;
            this.rdbtn_NombrePRODUCTOS.Text = "Nombre";
            this.rdbtn_NombrePRODUCTOS.UseVisualStyleBackColor = true;
            // 
            // rdbtn_IDPRODUCTOS
            // 
            this.rdbtn_IDPRODUCTOS.AutoSize = true;
            this.rdbtn_IDPRODUCTOS.Location = new System.Drawing.Point(671, 401);
            this.rdbtn_IDPRODUCTOS.Name = "rdbtn_IDPRODUCTOS";
            this.rdbtn_IDPRODUCTOS.Size = new System.Drawing.Size(41, 20);
            this.rdbtn_IDPRODUCTOS.TabIndex = 137;
            this.rdbtn_IDPRODUCTOS.TabStop = true;
            this.rdbtn_IDPRODUCTOS.Text = "ID";
            this.rdbtn_IDPRODUCTOS.UseVisualStyleBackColor = true;
            // 
            // txtbox_BuscarPRODUCTO
            // 
            this.txtbox_BuscarPRODUCTO.Location = new System.Drawing.Point(671, 427);
            this.txtbox_BuscarPRODUCTO.Name = "txtbox_BuscarPRODUCTO";
            this.txtbox_BuscarPRODUCTO.Size = new System.Drawing.Size(407, 22);
            this.txtbox_BuscarPRODUCTO.TabIndex = 136;
            this.txtbox_BuscarPRODUCTO.TextChanged += new System.EventHandler(this.txtbox_BuscarPRODUCTO_TextChanged);
            // 
            // lbl_TEXTOproductos
            // 
            this.lbl_TEXTOproductos.AutoSize = true;
            this.lbl_TEXTOproductos.Location = new System.Drawing.Point(777, 382);
            this.lbl_TEXTOproductos.Name = "lbl_TEXTOproductos";
            this.lbl_TEXTOproductos.Size = new System.Drawing.Size(93, 16);
            this.lbl_TEXTOproductos.TabIndex = 141;
            this.lbl_TEXTOproductos.Text = "PRODUCTOS";
            // 
            // lbl_TEXTOusuarios
            // 
            this.lbl_TEXTOusuarios.AutoSize = true;
            this.lbl_TEXTOusuarios.Location = new System.Drawing.Point(791, 29);
            this.lbl_TEXTOusuarios.Name = "lbl_TEXTOusuarios";
            this.lbl_TEXTOusuarios.Size = new System.Drawing.Size(77, 16);
            this.lbl_TEXTOusuarios.TabIndex = 142;
            this.lbl_TEXTOusuarios.Text = "USUARIOS";
            // 
            // CrearMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 694);
            this.Controls.Add(this.lbl_TEXTOusuarios);
            this.Controls.Add(this.lbl_TEXTOproductos);
            this.Controls.Add(this.lbl_OpcionesBusquedaPRODUCTOS);
            this.Controls.Add(this.lbl_BusquedaPRODUCTOS);
            this.Controls.Add(this.rdbtn_NombrePRODUCTOS);
            this.Controls.Add(this.rdbtn_IDPRODUCTOS);
            this.Controls.Add(this.txtbox_BuscarPRODUCTO);
            this.Controls.Add(this.lbl_OpcionesBusquedaUSUARIOS);
            this.Controls.Add(this.lbl_BusquedaUSUARIOS);
            this.Controls.Add(this.rdbtn_NombreUSUARIOS);
            this.Controls.Add(this.rdbtn_IDUSUARIOS);
            this.Controls.Add(this.txtbox_BuscarUSUARIO);
            this.Controls.Add(this.datagrid_Productos);
            this.Controls.Add(this.DataGrid_Usuarios);
            this.Controls.Add(this.lbl_Causa);
            this.Controls.Add(this.cmb_Causa);
            this.Controls.Add(this.lbl_UsuarioResponsable);
            this.Controls.Add(this.cmb_UsuarioResponsable);
            this.Controls.Add(this.txt_IDMovimiento);
            this.Controls.Add(this.lbl_IDMovimiento);
            this.Controls.Add(this.lbl_Producto);
            this.Controls.Add(this.cmb_Producto);
            this.Controls.Add(this.lbl_TipoMovimiento);
            this.Controls.Add(this.cmb_TipoMovimiento);
            this.Controls.Add(this.btn_CrearMovimiento);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.txtbox_CantidadProducto);
            this.Controls.Add(this.lbl_CrearMovimiento);
            this.Name = "CrearMovimiento";
            this.Text = "CrearMovimiento";
            this.Load += new System.EventHandler(this.CrearMovimiento_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CrearMovimiento_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Producto;
        private System.Windows.Forms.ComboBox cmb_Producto;
        private System.Windows.Forms.Label lbl_TipoMovimiento;
        private System.Windows.Forms.ComboBox cmb_TipoMovimiento;
        private System.Windows.Forms.Button btn_CrearMovimiento;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txtbox_CantidadProducto;
        private System.Windows.Forms.Label lbl_CrearMovimiento;
        private System.Windows.Forms.Label lbl_IDMovimiento;
        private System.Windows.Forms.TextBox txt_IDMovimiento;
        private System.Windows.Forms.Label lbl_UsuarioResponsable;
        private System.Windows.Forms.ComboBox cmb_UsuarioResponsable;
        private System.Windows.Forms.Label lbl_Causa;
        private System.Windows.Forms.ComboBox cmb_Causa;
        private System.Windows.Forms.DataGridView DataGrid_Usuarios;
        private System.Windows.Forms.DataGridView datagrid_Productos;
        private System.Windows.Forms.Label lbl_OpcionesBusquedaUSUARIOS;
        private System.Windows.Forms.Label lbl_BusquedaUSUARIOS;
        private System.Windows.Forms.RadioButton rdbtn_NombreUSUARIOS;
        private System.Windows.Forms.RadioButton rdbtn_IDUSUARIOS;
        private System.Windows.Forms.TextBox txtbox_BuscarUSUARIO;
        private System.Windows.Forms.Label lbl_OpcionesBusquedaPRODUCTOS;
        private System.Windows.Forms.Label lbl_BusquedaPRODUCTOS;
        private System.Windows.Forms.RadioButton rdbtn_NombrePRODUCTOS;
        private System.Windows.Forms.RadioButton rdbtn_IDPRODUCTOS;
        private System.Windows.Forms.TextBox txtbox_BuscarPRODUCTO;
        private System.Windows.Forms.Label lbl_TEXTOproductos;
        private System.Windows.Forms.Label lbl_TEXTOusuarios;
    }
}