using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Proyecto_Boutique.Forms.Forms_secundarios.Crear;
using Proyecto_Boutique.Mostrar_Detalles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proyecto_Boutique
{
    public partial class Principal_forms : Form
    {
        //Declaracion de objetos para las ventanas de creacion de elementos
        CrearUsuario ventanaCrearUsuario;
        CrearProducto ventanaCrearProducto;
        CrearMovimiento ventanaCrearMovimiento;
        CrearCategoria ventanaCrearCategoria;
        CrearMarca ventanaCrearMarca;
        CrearColores ventanaCrearColor;

        //Declaracion de objetos para las ventanas de modificacion de elementos
        EditarUsuario ventanaEditarUsuario;
        EditarProducto ventanaEditarProducto;

        //Declaracion de variable auxiliar para la busqueda en datagrid
        string dato = "";

        //Metodo para impedir que se pueda pegar texto en los campos
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public Principal_forms()
        {
            InitializeComponent();
            credenciales();

            this.FormBorderStyle = FormBorderStyle.None; //Oculta la barra de titulo
        }

        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion = new databaseConnection();

        //Creacion de un objeto SqlDataAdapter para reutilizarlo mas adelante
        SqlDataAdapter adaptador = new SqlDataAdapter();

        private void lbl_Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void Principal_forms_Load(object sender, EventArgs e)
        {
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; //Maximiza el formulario al abrirlo
            try
            {

                //Se mandan a llamar los metodos hechos para obtener los datos de las respectivas tablas de cada apartado
                ObtenerRegistrosUsuarios();
                VerificarFilasUsuarios();
                ObtenerRegistrosProductos();
                VerificarFilasProductos();
                ObtenerMovimientos();
                VerificarFilasMovimientos();
                ObtenerRegistrosProductosParaReportes();
                ObtenerRegistrosMovimientosParaReportes();

                credenciales();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void ObtenerRegistrosUsuarios()
        {
            try
            {
                conexion.Open();
                //Creacion de consulta para visualizar todos los campos de las respectivas tablas
                String ConsultaUsuarios = "Select * from USUARIO";

                //Se utiliza el objeto sqldataadapter creado anteriormente
                adaptador = new SqlDataAdapter(ConsultaUsuarios, conexion.getConnection());

                //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
                DataTable dtUSUARIO = new DataTable();

                //Se pasan los datos del datatable al objeto adaptador
                adaptador.Fill(dtUSUARIO);

                //Se envian los parametros al datagridview de usuarios
                DataGrid_Usuarios.DataSource = dtUSUARIO;
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void ObtenerRegistrosProductos()
        {
            try
            {
                conexion.Open();
                //Creacion de consulta para visualizar todos los campos de las respectivas tablas
                String ConsultarProductos = "Select * from PRODUCTOS";

                //Se utiliza el objeto sqldataadapter creado anteriormente
                adaptador = new SqlDataAdapter(ConsultarProductos, conexion.getConnection());

                //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
                DataTable dtPRODUCTOS = new DataTable();

                //Se pasan los datos del datatable al objeto adaptador
                adaptador.Fill(dtPRODUCTOS);

                //Se envian los parametros al datagridview de usuarios
                DataGrid_Productos.DataSource = dtPRODUCTOS;
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void ObtenerRegistrosProductosParaReportes()
        {
            try
            {
                conexion.Open();
                //Creacion de consulta para visualizar todos los campos de las respectivas tablas
                String ConsultarProductos = "SELECT P.ID_Producto, P.Nombre, C.Nombre AS Categoria, P.Cantidad FROM PRODUCTOS P INNER JOIN CATEGORIA C ON P.Categoria = C.ID_Categoria WHERE P.Visibilidad = 1";

                //Se utiliza el objeto sqldataadapter creado anteriormente
                adaptador = new SqlDataAdapter(ConsultarProductos, conexion.getConnection());

                //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
                DataTable dtPRODUCTOS = new DataTable();

                //Se pasan los datos del datatable al objeto adaptador
                adaptador.Fill(dtPRODUCTOS);

                //Se envian los parametros al datagridview de usuarios
                datagridAuxiliar_Productos.DataSource = dtPRODUCTOS;
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }



        public void ObtenerMovimientos()
        {
            try
            {
                conexion.Open();
                //Creacion de consulta para visualizar todos los campos de las respectivas tablas
                String ConsultaMovimientos = "Select * from MOVIMIENTOS";

                //Se utiliza el objeto sqldataadapter creado anteriormente
                adaptador = new SqlDataAdapter(ConsultaMovimientos, conexion.getConnection());

                //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
                DataTable dtMOVIMIENTOS = new DataTable();

                //Se pasan los datos del datatable al objeto adaptador
                adaptador.Fill(dtMOVIMIENTOS);

                //Se envian los parametros al datagridview de usuarios
                DataGrid_Movimientos.DataSource = dtMOVIMIENTOS;
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void ObtenerRegistrosMovimientosParaReportes()
        {
            try
            {
                conexion.Open();
                //Creacion de consulta para visualizar todos los campos de las respectivas tablas
                String ConsultaMovimientos = "SELECT M.ID_Movimiento, P.Nombre AS Producto, TM.Nombre AS TipoMovimiento, C.Causa AS Causa, P.Cantidad AS Cantidad, M.Fecha AS Fecha\r\nFROM MOVIMIENTOS M\r\nINNER JOIN PRODUCTOS P\r\nON M.Producto = P.ID_Producto\r\nINNER JOIN TIPOMOVIMIENTO TM\r\nON M.TipoMovimiento = TM.ID_Tipo\r\nINNER JOIN CAUSA C\r\nON M.Causa = C.ID_Causa";

                //Se utiliza el objeto sqldataadapter creado anteriormente
                adaptador = new SqlDataAdapter(ConsultaMovimientos, conexion.getConnection());

                //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
                DataTable dtMOVIMIENTOS = new DataTable();

                //Se pasan los datos del datatable al objeto adaptador
                adaptador.Fill(dtMOVIMIENTOS);

                //Se envian los parametros al datagridview de usuarios
                datagridAuxiliar_Movimientos.DataSource = dtMOVIMIENTOS;
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        //===========================================Metodos y procesos para abrir y cerrar ventanas (Cierre y creacion de elementos)========================================================

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Estructura condicional para que solo se pueda abrir una ventana para crear usuario
                if (ventanaCrearUsuario == null)
                {
                    //Se crea un objeto de la ventana CrearUsuario
                    ventanaCrearUsuario = new CrearUsuario(this);

                    //Comando auxiliar para el proceso
                    ventanaCrearUsuario.FormClosed += new FormClosedEventHandler(CierreVentanaCrearUsuario);

                    //Se muestra la ventana correspondiente
                    ventanaCrearUsuario.Show();

                    //this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }

        }

        void CierreVentanaCrearUsuario(object sender, EventArgs e)
        {
            ventanaCrearUsuario = null;
        }

        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                //Estructura condicional para que solo se pueda abrir una ventana para crear usuario
                if (ventanaCrearProducto == null)
                {
                    //Se crea un objeto de la ventana CrearUsuario
                    ventanaCrearProducto = new CrearProducto(this);

                    //Comando auxiliar para el proceso
                    ventanaCrearProducto.FormClosed += new FormClosedEventHandler(CierreVentanaCrearProducto);

                    //Se muestra la ventana correspondiente
                    ventanaCrearProducto.Show();

                    //this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        void CierreVentanaCrearProducto(object sender, EventArgs e)
        {
            ventanaCrearProducto = null;
        }

        private void btn_CrearMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (ventanaCrearMovimiento == null)
                {
                    //Se crea un objeto de la ventana CrearUsuario
                    ventanaCrearMovimiento = new CrearMovimiento(this);

                    //Comando auxiliar para el proceso
                    ventanaCrearMovimiento.FormClosed += new FormClosedEventHandler(CierreVentanaCrearMovimiento);

                    //Se muestra la ventana correspondiente
                    ventanaCrearMovimiento.Show();

                    //this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        void CierreVentanaCrearMovimiento(object sender, EventArgs e)
        {
            ventanaCrearMovimiento = null;
        }

        private void btn_CrearCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                if (ventanaCrearCategoria == null)
                {
                    //Se crea un objeto de la ventana CrearUsuario
                    ventanaCrearCategoria = new CrearCategoria(this);

                    //Comando auxiliar para el proceso
                    ventanaCrearCategoria.FormClosed += new FormClosedEventHandler(CierreVentanaCrearCategoria);

                    //Se muestra la ventana correspondiente
                    ventanaCrearCategoria.Show();

                    //this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        void CierreVentanaCrearCategoria(object sender, EventArgs e)
        {
            ventanaCrearCategoria = null;
        }

        private void btn_CrearMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (ventanaCrearMarca == null)
                {
                    //Se crea un objeto de la ventana CrearUsuario
                    ventanaCrearMarca = new CrearMarca();

                    //Comando auxiliar para el proceso
                    ventanaCrearMarca.FormClosed += new FormClosedEventHandler(CierreVentanaCrearMarca);

                    //Se muestra la ventana correspondiente
                    ventanaCrearMarca.Show();

                    //this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        void CierreVentanaCrearMarca(object sender, EventArgs e)
        {
            ventanaCrearMarca = null;
        }

        void CierreVentanaEditarUsuarios(object sender, EventArgs e)
        {
            ventanaEditarUsuario = null;
        }

        private void Btn_RegistrarColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (ventanaCrearColor == null)
                {
                    //Se crea un objeto de la ventana CrearUsuario
                    ventanaCrearColor = new CrearColores();

                    //Comando auxiliar para el proceso
                    ventanaCrearColor.FormClosed += new FormClosedEventHandler(CierreVentanaCrearColor);

                    //Se muestra la ventana correspondiente
                    ventanaCrearColor.Show();

                    //this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        void CierreVentanaCrearColor(object sender, EventArgs e)
        {
            ventanaCrearColor = null;
        }

        private void btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ventanaEditarProducto == null)
                {
                    //Se crea un objeto de la ventana CrearUsuario
                    ventanaEditarProducto = new EditarProducto(this);

                    //Comando auxiliar para el proceso
                    ventanaEditarProducto.FormClosed += new FormClosedEventHandler(CierreVentanaModificarProducto);

                    //Se muestra la ventana correspondiente
                    ventanaEditarProducto.Show();

                    //this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        void CierreVentanaModificarProducto(object sender, EventArgs e)
        {
            ventanaEditarProducto = null;
        }

        private void btn_ModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //Estructura condicional para que solo se pueda abrir una ventana para crear usuario
                if (ventanaEditarUsuario == null)
                {
                    //Se crea un objeto de la ventana CrearUsuario
                    ventanaEditarUsuario = new EditarUsuario(this);

                    //Comando auxiliar para el proceso
                    ventanaEditarUsuario.FormClosed += new FormClosedEventHandler(CierreVentanaEditarUsuarios);

                    //Se muestra la ventana correspondiente
                    ventanaEditarUsuario.Show();

                    //this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }


        }

        //====================================================================================================================================================================================


        //Procedimiento para implementar una busqueda dinamica en la barra de busqueda (El mismo tiempo que se escribe se filtra)
        private void txtbox_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbtn_Nombre.Checked == true)
                {
                    //En este caso se utiliza la consulta "LIKE" para mostrar los valores que coinciden con los caracteres escritos
                    (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '{0}%' OR Nombre LIKE '%{0}%'", txtbox_BuscarUsuario.Text);
                }
                else if (rdbtn_ID.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BuscarUsuario.Text, out int id))
                    {
                        (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = $"ID_Usuario = {txtbox_BuscarUsuario.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else if (rdbtn_Rol.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BuscarUsuario.Text, out int id))
                    {
                        (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = $"Rol = {txtbox_BuscarUsuario.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else if (rdbtn_EstadoVisibilidad.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BuscarUsuario.Text, out int id))
                    {
                        (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = $"Visibilidad = {txtbox_BuscarUsuario.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor de elegir una opcion de filtrado");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            //Se declara una variable tipo "DialogResult para capturar la resultasta a la ventana de dialogo de confirmacion
            DialogResult dg;

            try
            {
                if (DataGrid_Usuarios.SelectedRows.Count == 1)
                {
                    dg = MessageBox.Show("Desea eiminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    //Se evalua para saber si se quiere proceder con la operacion, de ser el caso que se seleccione "Aceptar" realiza la eliminacion
                    if(dg == DialogResult.OK)
                    {
                        conexion.Open();

                        int id = Convert.ToInt32(DataGrid_Usuarios.CurrentRow.Cells["ID_Usuario"].Value);

                        string query = $"UPDATE USUARIO SET Visibilidad = 0 WHERE ID_Usuario = {id}";
                        SqlCommand cmd = new SqlCommand(query, conexion.getConnection());

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Eliminacion exitosa");
                        }
                        else
                        {
                            MessageBox.Show("Erro al eliminar");
                        }

                        conexion.Close();

                        ObtenerRegistrosUsuarios();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Favor de elegir algun registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex);
            }


            
        }

        

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            //Se declara una variable tipo "DialogResult para capturar la resultasta a la ventana de dialogo de confirmacion
            DialogResult dg;

            try
            {
                if (DataGrid_Productos.SelectedRows.Count == 1)
                {
                    dg = MessageBox.Show("Desea eiminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    //Se evalua para saber si se quiere proceder con la operacion, de ser el caso que se seleccione "Aceptar" realiza la eliminacion
                    if (dg == DialogResult.OK)
                    {
                        conexion.Open();

                        int id = Convert.ToInt32(DataGrid_Productos.CurrentRow.Cells["ID_Producto"].Value);

                        string query = $"UPDATE PRODUCTOS SET Visibilidad = 0 WHERE ID_Producto = {id}";
                        SqlCommand cmd = new SqlCommand(query, conexion.getConnection());

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Eliminacion exitosa");
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar");
                        }

                        conexion.Close();

                        ObtenerRegistrosProductos();
                        ObtenerRegistrosProductosParaReportes();
                    }
                }
                else
                {
                    MessageBox.Show("Favor de elegir algun registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: ", ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbtn_NombreProducto.Checked == true)
                {
                    //En este caso se utiliza la consulta "LIKE" para mostrar los valores que coinciden con los caracteres escritos
                    (DataGrid_Productos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '{0}%' OR Nombre LIKE '%{0}%'", txtbox_BusquedaProductos.Text);
                }
                else if (rdbtn_IDProducto.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BusquedaProductos.Text, out int id))
                    {
                        (DataGrid_Productos.DataSource as DataTable).DefaultView.RowFilter = $"ID_Producto = {txtbox_BusquedaProductos.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Productos.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else if (rdbtn_CategoriaProducto.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BusquedaProductos.Text, out int id))
                    {
                        (DataGrid_Productos.DataSource as DataTable).DefaultView.RowFilter = $"Categoria = {txtbox_BusquedaProductos.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Productos.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else if (rdbtn_EstadoProducto.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BusquedaProductos.Text, out int id))
                    {
                        (DataGrid_Productos.DataSource as DataTable).DefaultView.RowFilter = $"Visibilidad = {txtbox_BusquedaProductos.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Productos.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor de elegir una opcion de filtrado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message);
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void DataGrid_Movimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btn_EliminarMovimientos_Click(object sender, EventArgs e)
        {
            //Se declara una variable tipo "DialogResult para capturar la resultasta a la ventana de dialogo de confirmacion
            DialogResult dg;

            try
            {
                if (DataGrid_Movimientos.SelectedRows.Count == 1)
                {
                    dg = MessageBox.Show("Desea eiminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    //Se evalua para saber si se quiere proceder con la operacion, de ser el caso que se seleccione "Aceptar" realiza la eliminacion
                    if (dg == DialogResult.OK)
                    {
                        conexion.Open();

                        int id = Convert.ToInt32(DataGrid_Movimientos.CurrentRow.Cells["ID_Movimiento"].Value);

                        string query = $"DELETE FROM MOVIMIENTOS WHERE ID_Movimiento = {id}";
                        SqlCommand cmd = new SqlCommand(query, conexion.getConnection());

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Eliminacion exitosa");
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar");
                        }

                        conexion.Close();

                        ObtenerMovimientos();
                        ObtenerRegistrosMovimientosParaReportes();
                    }
                }
                else
                {
                    MessageBox.Show("Favor de elegir algun registro");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message);
            }
        }

        private void txtbox_BusquedaMovimiento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbtn_IDMovimiento.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BusquedaMovimiento.Text, out int id))
                    {
                        (DataGrid_Movimientos.DataSource as DataTable).DefaultView.RowFilter = $"ID_Movimiento = {txtbox_BusquedaMovimiento.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Movimientos.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else if (rdbtn_ProductoMovimiento.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BusquedaMovimiento.Text, out int id))
                    {
                        (DataGrid_Movimientos.DataSource as DataTable).DefaultView.RowFilter = $"Producto = {txtbox_BusquedaMovimiento.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Movimientos.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else if (rdbtn_TipoMovimiento.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BusquedaMovimiento.Text, out int id))
                    {
                        (DataGrid_Movimientos.DataSource as DataTable).DefaultView.RowFilter = $"TipoMovimiento = {txtbox_BusquedaMovimiento.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Movimientos.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else if (rdbtn_UsuarioMovimiento.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BusquedaMovimiento.Text, out int id))
                    {
                        (DataGrid_Movimientos.DataSource as DataTable).DefaultView.RowFilter = $"Usuario = {txtbox_BusquedaMovimiento.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (DataGrid_Movimientos.DataSource as DataTable).DefaultView.RowFilter = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor de elegir una opcion de filtrado");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        private void btn_RepStock_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_RepMovimientos_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_RepAuditoria_Click(object sender, EventArgs e)
        {
            ReporteAuditoriaForms frm = new ReporteAuditoriaForms();
            frm.Show();
        }

        private void credenciales()
        {
            if(SessionData.RolId == 2) // EN CASO DE SER GENERAL ES 2
            {
                // Se ocultan los botones de crear y eliminar
                btn_CrearUsuario.Visible = false;
                btn_CrearProducto.Visible = false;
                btn_CrearMovimiento.Visible = false;


                btn_Eliminar.Visible = false;
                btn_EliminarProducto.Visible = false;
  
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;

                pictureBox22.Visible = false;

                tabControl1.TabPages.Remove(tabPage1); // Se oculta la pestaña de usuarios
            }
            
        }

        private void btn_MostrarDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGrid_Usuarios.SelectedRows.Count == 1)
                {
                    int id = int.Parse(DataGrid_Usuarios.CurrentRow.Cells[0].Value.ToString());
                    string nombre = DataGrid_Usuarios.CurrentRow.Cells[1].Value.ToString();
                    string contrasena = DataGrid_Usuarios.CurrentRow.Cells[2].Value.ToString();
                    int rol = int.Parse(DataGrid_Usuarios.CurrentRow.Cells[3].Value.ToString());
                    string correo = DataGrid_Usuarios.CurrentRow.Cells[4].Value.ToString();

                    MostrarDetallesUsuarios mostrarDetallesUsuarios = new MostrarDetallesUsuarios(id, nombre, contrasena, rol, correo);

                    mostrarDetallesUsuarios.Show();
                }
                else
                {
                    MessageBox.Show("Favor de seleccionar algun registro");
                }
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        private void btn_MostrarDetallesProductos_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Hide();
                if (DataGrid_Productos.SelectedRows.Count == 1)
                {

                    int IDelemento = Convert.ToInt32(DataGrid_Productos.CurrentRow.Cells["ID_Producto"].Value);
                    conexion.Open();

                    string query = $"SELECT Marca FROM PRODUCTOS WHERE ID_Producto = {IDelemento}";
                    SqlCommand cmd = new SqlCommand(query, conexion.getConnection());

                    int resultadoMarca = Convert.ToInt32(cmd.ExecuteScalar());

                    conexion.Close();

                    conexion.Open();

                    string query2 = $"SELECT Color FROM PRODUCTOS WHERE ID_Producto = {IDelemento}";
                    SqlCommand cmd2 = new SqlCommand(query2, conexion.getConnection());

                    int resultadoColor = Convert.ToInt32(cmd2.ExecuteScalar());

                    conexion.Close();

                    conexion.Open();

                    string query3 = $"SELECT Categoria FROM PRODUCTOS WHERE ID_Producto = {IDelemento}";
                    SqlCommand cmd3 = new SqlCommand(query3, conexion.getConnection());

                    int resultadoCategoria = Convert.ToInt32(cmd3.ExecuteScalar());

                    conexion.Close();

                    int id = int.Parse(DataGrid_Productos.CurrentRow.Cells[0].Value.ToString());
                    string nombre = DataGrid_Productos.CurrentRow.Cells[1].Value.ToString();

                    string descripcion = DataGrid_Productos.CurrentRow.Cells[3].Value.ToString();
                    int categoria = int.Parse(DataGrid_Productos.CurrentRow.Cells[4].Value.ToString());
                    float precio = float.Parse(DataGrid_Productos.CurrentRow.Cells[5].Value.ToString());
                    int cantidad = int.Parse(DataGrid_Productos.CurrentRow.Cells[6].Value.ToString());

                    string talla = DataGrid_Productos.CurrentRow.Cells[8].Value.ToString();
                    string fecha = DataGrid_Productos.CurrentRow.Cells[9].Value.ToString();
                    int puntoreorden = int.Parse(DataGrid_Productos.CurrentRow.Cells[10].Value.ToString());
                    int maximo = int.Parse(DataGrid_Productos.CurrentRow.Cells[11].Value.ToString());
                    int minimo = int.Parse(DataGrid_Productos.CurrentRow.Cells[12].Value.ToString());

                    MostrarDetallesProductos mostrarDetallesProductos = new MostrarDetallesProductos(id, nombre, resultadoMarca, descripcion, resultadoCategoria, precio, cantidad, resultadoColor, talla, fecha, puntoreorden, maximo, minimo);

                    mostrarDetallesProductos.Show();
                }
                else
                {
                    MessageBox.Show("Favor de seleccionar algun registro");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        private void btn_MostrarDetallesMovimientos_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGrid_Movimientos.SelectedRows.Count == 1)
                {

                    int IDelemento = Convert.ToInt32(DataGrid_Movimientos.CurrentRow.Cells["ID_Movimiento"].Value);

                    conexion.Open();

                    string query = $"SELECT Usuario FROM MOVIMIENTOS WHERE ID_Movimiento = {IDelemento}";
                    SqlCommand cmd = new SqlCommand(query, conexion.getConnection());

                    int resultadoUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                    conexion.Close();

                    conexion.Open();

                    string query2 = $"SELECT Producto FROM MOVIMIENTOS WHERE ID_Movimiento = {IDelemento}";
                    SqlCommand cmd2 = new SqlCommand(query2, conexion.getConnection());

                    int resultadoProducto = Convert.ToInt32(cmd2.ExecuteScalar());

                    conexion.Close();

                    conexion.Open();

                    string query3 = $"SELECT TipoMovimiento FROM MOVIMIENTOS WHERE ID_Movimiento = {IDelemento}";
                    SqlCommand cmd3 = new SqlCommand(query3, conexion.getConnection());

                    int resultadoTipoMovimiento = Convert.ToInt32(cmd3.ExecuteScalar());

                    conexion.Close();

                    conexion.Open();

                    string query4 = $"SELECT Causa FROM MOVIMIENTOS WHERE ID_Movimiento = {IDelemento}";
                    SqlCommand cmd4 = new SqlCommand(query4, conexion.getConnection());

                    int resultadoCausa = Convert.ToInt32(cmd4.ExecuteScalar());

                    conexion.Close();

                    int id = int.Parse(DataGrid_Movimientos.CurrentRow.Cells[0].Value.ToString());
                    int cantidad = int.Parse(DataGrid_Movimientos.CurrentRow.Cells[4].Value.ToString());
                    string fecha = DataGrid_Movimientos.CurrentRow.Cells[6].Value.ToString();



                    MostrarDetallesMovimientos mostrarDetallesMovimientos = new MostrarDetallesMovimientos(id, resultadoUsuario, resultadoProducto, resultadoTipoMovimiento, cantidad, resultadoCausa, fecha);

                    mostrarDetallesMovimientos.Show();
                }
                else
                {
                    MessageBox.Show("Favor de seleccionar algun registro");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        private void VerificarFilasMovimientos()
        {
            // Verifica si hay al menos una fila que no sea la fila nueva (si está habilitada)
            btn_MostrarDetallesMovimientos.Visible = DataGrid_Movimientos.Rows.Count > 0 && !DataGrid_Movimientos.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow);
        }

        private void VerificarFilasProductos()
        {
            // Verifica si hay al menos una fila que no sea la fila nueva (si está habilitada)
            btn_MostrarDetallesProductos.Visible = DataGrid_Productos.Rows.Count > 0 && !DataGrid_Productos.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow);
        }

        private void VerificarFilasUsuarios()
        {
            // Verifica si hay al menos una fila que no sea la fila nueva (si está habilitada)
            btn_MostrarDetallesUsuarios.Visible = DataGrid_Usuarios.Rows.Count > 0 && !DataGrid_Usuarios.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow);
        }

        private void DataGrid_Usuarios_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VerificarFilasUsuarios();
        }

        private void DataGrid_Usuarios_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            VerificarFilasUsuarios();
        }

        private void DataGrid_Productos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VerificarFilasProductos();
        }

        private void DataGrid_Productos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            VerificarFilasProductos();
        }

        private void DataGrid_Movimientos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            VerificarFilasMovimientos();
        }

        private void DataGrid_Movimientos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            VerificarFilasMovimientos();
        }

        private void Principal_forms_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_cerrarSesion_Click(object sender, EventArgs e)
        {
            /*Al darle la cruceta (X) del formulario, se aplicara un aviso si quiere salirse del programa
o dirigirse a inicio de sesion*/


            DialogResult result = MessageBox.Show("¿Quieres cerrar sesion?", "Deseas salir ",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);

            // Yes -> salir
            // No -> no hacer nada

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Inicio_Sesion login = new Inicio_Sesion();
                login.Show();
            }
        }

        private void DataGrid_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BotonReportesMovimiento_Click(object sender, EventArgs e)
        {
            // REPORTE DE MOVIMIENTOS
            try
            {
                //Proceso para guardar los pdf
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = "Reporte de Movimientos" + DateTime.Now.ToString("ddmmyyyy") + ".pdf"; // Nombre por defecto con el que se guarda


                //llamado al archivo hmtl para convertirlo a una cadena de texto
                string Pagina_HTML_texto2 = Properties.Resources.Reporte_de__Movimientos.ToString();

                //Remplazo de valores
                Pagina_HTML_texto2 = Pagina_HTML_texto2.Replace("@FECHADEGENERACION", DateTime.Now.ToString("dd / mm / yyyy"));

                //Extraccion del dataview
                string filas2 = string.Empty;
         
                foreach (DataGridViewRow row in datagridAuxiliar_Movimientos.Rows)
                {
                    filas2 += "<tr>";
                    filas2 += "<td style=\"text-align:center\">" + row.Cells["ID_Movimiento"].Value.ToString() + "</td>";
                    filas2 += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                    filas2 += "<td>" + row.Cells["TipoMovimiento"].Value.ToString() + "</td>";
                    filas2 += "<td>" + row.Cells["Causa"].Value.ToString() + "</td>";
                    filas2 += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                    filas2 += "<td style=\"text-align: right;\">" + row.Cells["Fecha"].Value.ToString() + "</td>";
                    filas2 += "</tr>";
                }

                Pagina_HTML_texto2 = Pagina_HTML_texto2.Replace("@FILAS", filas2);

                //Condicional para el guardado
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    //Guardado en memoria
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        //Caracteristicas del formato del pdf
                        Document pdfDoc = new Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //Agregar la imagen al pdf
                        iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Properties.Resources.LOGO_1, System.Drawing.Imaging.ImageFormat.Png);
                        imagen.ScaleToFit(110, 95); //Tamaño de la imagen
                        imagen.Alignment = iTextSharp.text.Image.UNDERLYING; //Propiedad de Superioridad
                        imagen.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 95); //Margen izquierdo
                        imagen.SetAbsolutePosition(pdfDoc.RightMargin, pdfDoc.Top - 105); //Margen derecho
                        pdfDoc.Add(imagen);

                        using (StringReader sr = new StringReader(Pagina_HTML_texto2))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonReportesProductos_Click(object sender, EventArgs e)
        {
            // REPORTE DE ARTICULOS,PRODUCTOS,MERCANCIA
            try
            {
                //Proceso para guardar los pdf
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = "Conteo de Productos" + DateTime.Now.ToString("ddmmyyyy") + ".PDF"; // Nombre por defecto con el que se guarda


                //llamado al archivo hmtl para convertirlo a una cadena de texto
                string Pagina_HTML_texto = Properties.Resources.Reporte_de_Conteo.ToString();

                //Remplazo de valores
                Pagina_HTML_texto = Pagina_HTML_texto.Replace("@FECHADEGENERACION", DateTime.Now.ToString("dd / mm / yyyy"));

                //Extraccion del dataview
                string filas = string.Empty;
   
                foreach (DataGridViewRow row in datagridAuxiliar_Productos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td style=\"text-align:center\">" + row.Cells["ID_Producto"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Categoria"].Value.ToString() + "</td>";
                    filas += "<td style=\"text-align: right;\">" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                    filas += "<td></td>";
                    filas += "<td></td>";
                    filas += "</tr>";
                }

                Pagina_HTML_texto = Pagina_HTML_texto.Replace("@FILAS", filas);

                //Condicional para el guardado
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    //Guardado en memoria
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        //Caracteristicas del formato del pdf
                        Document pdfDoc = new Document(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        //Agregar la imagen al pdf
                        iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(Properties.Resources.LOGO_1,System.Drawing.Imaging.ImageFormat.Png);
                        imagen.ScaleToFit(110,95); //Tamaño de la imagen
                        imagen.Alignment = iTextSharp.text.Image.UNDERLYING; //Propiedad de Superioridad
                        imagen.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 95); //Margen izquierdo
                        imagen.SetAbsolutePosition(pdfDoc.RightMargin, pdfDoc.Top - 105); //Margen derecho
                        pdfDoc.Add(imagen);

                        using (StringReader sr = new StringReader(Pagina_HTML_texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGrid_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
