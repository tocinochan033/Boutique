namespace Proyecto_Boutique
{
    partial class Principal_forms
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_RepAuditoria = new System.Windows.Forms.Button();
            this.btn_RepMovimientos = new System.Windows.Forms.Button();
            this.btn_RepStock = new System.Windows.Forms.Button();
            this.lbl_Usuarios = new System.Windows.Forms.Label();
            this.btn_CrearUsuario = new System.Windows.Forms.Button();
            this.DataGrid_Usuarios = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbl_Productos = new System.Windows.Forms.Label();
            this.btn_CrearProducto = new System.Windows.Forms.Button();
            this.DataGrid_Productos = new System.Windows.Forms.DataGridView();
            this.lbl_Movimientos = new System.Windows.Forms.Label();
            this.btn_CrearMovimiento = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_categorias = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1354, 653);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_Usuarios);
            this.tabPage1.Controls.Add(this.btn_CrearUsuario);
            this.tabPage1.Controls.Add(this.DataGrid_Usuarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1346, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_Movimientos);
            this.tabPage3.Controls.Add(this.btn_CrearMovimiento);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1346, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movimientos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_RepAuditoria);
            this.tabPage4.Controls.Add(this.btn_RepMovimientos);
            this.tabPage4.Controls.Add(this.btn_RepStock);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1346, 624);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reportes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_RepAuditoria
            // 
            this.btn_RepAuditoria.Location = new System.Drawing.Point(925, 285);
            this.btn_RepAuditoria.Name = "btn_RepAuditoria";
            this.btn_RepAuditoria.Size = new System.Drawing.Size(153, 45);
            this.btn_RepAuditoria.TabIndex = 139;
            this.btn_RepAuditoria.Text = "Generar Reporte de Auditoria";
            this.btn_RepAuditoria.UseVisualStyleBackColor = true;
            // 
            // btn_RepMovimientos
            // 
            this.btn_RepMovimientos.Location = new System.Drawing.Point(573, 294);
            this.btn_RepMovimientos.Name = "btn_RepMovimientos";
            this.btn_RepMovimientos.Size = new System.Drawing.Size(153, 45);
            this.btn_RepMovimientos.TabIndex = 138;
            this.btn_RepMovimientos.Text = "Generar Reporte de Movimientos";
            this.btn_RepMovimientos.UseVisualStyleBackColor = true;
            // 
            // btn_RepStock
            // 
            this.btn_RepStock.Location = new System.Drawing.Point(268, 285);
            this.btn_RepStock.Name = "btn_RepStock";
            this.btn_RepStock.Size = new System.Drawing.Size(153, 45);
            this.btn_RepStock.TabIndex = 137;
            this.btn_RepStock.Text = "Generar Reporte de Stock";
            this.btn_RepStock.UseVisualStyleBackColor = true;
            // 
            // lbl_Usuarios
            // 
            this.lbl_Usuarios.AutoSize = true;
            this.lbl_Usuarios.Location = new System.Drawing.Point(65, 53);
            this.lbl_Usuarios.Name = "lbl_Usuarios";
            this.lbl_Usuarios.Size = new System.Drawing.Size(124, 16);
            this.lbl_Usuarios.TabIndex = 17;
            this.lbl_Usuarios.Text = "Usuarios existentes";
            this.lbl_Usuarios.Click += new System.EventHandler(this.lbl_Usuarios_Click);
            // 
            // btn_CrearUsuario
            // 
            this.btn_CrearUsuario.Location = new System.Drawing.Point(1133, 39);
            this.btn_CrearUsuario.Name = "btn_CrearUsuario";
            this.btn_CrearUsuario.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearUsuario.TabIndex = 16;
            this.btn_CrearUsuario.Text = "Crear Usuario";
            this.btn_CrearUsuario.UseVisualStyleBackColor = true;
            // 
            // DataGrid_Usuarios
            // 
            this.DataGrid_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Usuarios.Location = new System.Drawing.Point(68, 95);
            this.DataGrid_Usuarios.Name = "DataGrid_Usuarios";
            this.DataGrid_Usuarios.RowHeadersWidth = 51;
            this.DataGrid_Usuarios.RowTemplate.Height = 24;
            this.DataGrid_Usuarios.Size = new System.Drawing.Size(1218, 468);
            this.DataGrid_Usuarios.TabIndex = 15;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_categorias);
            this.tabPage5.Controls.Add(this.lbl_Productos);
            this.tabPage5.Controls.Add(this.btn_CrearProducto);
            this.tabPage5.Controls.Add(this.DataGrid_Productos);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1346, 624);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Productos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbl_Productos
            // 
            this.lbl_Productos.AutoSize = true;
            this.lbl_Productos.Location = new System.Drawing.Point(49, 92);
            this.lbl_Productos.Name = "lbl_Productos";
            this.lbl_Productos.Size = new System.Drawing.Size(131, 16);
            this.lbl_Productos.TabIndex = 35;
            this.lbl_Productos.Text = "Productos existentes";
            // 
            // btn_CrearProducto
            // 
            this.btn_CrearProducto.Location = new System.Drawing.Point(1113, 53);
            this.btn_CrearProducto.Name = "btn_CrearProducto";
            this.btn_CrearProducto.Size = new System.Drawing.Size(149, 45);
            this.btn_CrearProducto.TabIndex = 34;
            this.btn_CrearProducto.Text = "Crear Producto";
            this.btn_CrearProducto.UseVisualStyleBackColor = true;
            // 
            // DataGrid_Productos
            // 
            this.DataGrid_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Productos.Location = new System.Drawing.Point(52, 135);
            this.DataGrid_Productos.Name = "DataGrid_Productos";
            this.DataGrid_Productos.RowHeadersWidth = 51;
            this.DataGrid_Productos.RowTemplate.Height = 24;
            this.DataGrid_Productos.Size = new System.Drawing.Size(1224, 437);
            this.DataGrid_Productos.TabIndex = 33;
            // 
            // lbl_Movimientos
            // 
            this.lbl_Movimientos.AutoSize = true;
            this.lbl_Movimientos.Location = new System.Drawing.Point(150, 67);
            this.lbl_Movimientos.Name = "lbl_Movimientos";
            this.lbl_Movimientos.Size = new System.Drawing.Size(83, 16);
            this.lbl_Movimientos.TabIndex = 44;
            this.lbl_Movimientos.Text = "Movimientos";
            // 
            // btn_CrearMovimiento
            // 
            this.btn_CrearMovimiento.Location = new System.Drawing.Point(1029, 53);
            this.btn_CrearMovimiento.Name = "btn_CrearMovimiento";
            this.btn_CrearMovimiento.Size = new System.Drawing.Size(153, 45);
            this.btn_CrearMovimiento.TabIndex = 43;
            this.btn_CrearMovimiento.Text = "Crear Movimiento";
            this.btn_CrearMovimiento.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 437);
            this.dataGridView1.TabIndex = 42;
            // 
            // btn_categorias
            // 
            this.btn_categorias.Location = new System.Drawing.Point(966, 55);
            this.btn_categorias.Name = "btn_categorias";
            this.btn_categorias.Size = new System.Drawing.Size(127, 41);
            this.btn_categorias.TabIndex = 36;
            this.btn_categorias.Text = "Ver categorias";
            this.btn_categorias.UseVisualStyleBackColor = true;
            // 
            // Principal_forms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 687);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal_forms";
            this.Text = "Principal_forms";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Usuarios)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_RepAuditoria;
        private System.Windows.Forms.Button btn_RepMovimientos;
        private System.Windows.Forms.Button btn_RepStock;
        private System.Windows.Forms.Label lbl_Usuarios;
        private System.Windows.Forms.Button btn_CrearUsuario;
        private System.Windows.Forms.DataGridView DataGrid_Usuarios;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lbl_Productos;
        private System.Windows.Forms.Button btn_CrearProducto;
        private System.Windows.Forms.DataGridView DataGrid_Productos;
        private System.Windows.Forms.Label lbl_Movimientos;
        private System.Windows.Forms.Button btn_CrearMovimiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_categorias;
    }
}