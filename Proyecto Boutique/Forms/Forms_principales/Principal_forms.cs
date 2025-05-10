using Proyecto_Boutique.Forms.Forms_secundarios.Crear;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
        CrearCausa ventanaCrearCausa;

        //Declaracion de objetos para las ventanas de modificacion de elementos
        EditarUsuario ventanaEditarUsuario;
        EditarProducto ventanaEditarProducto;

        //Declaracion de variable auxiliar para la busqueda en datagrid
        string dato = "";

        public Principal_forms()
        {
            InitializeComponent();
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
            //Se mandan a llamar los metodos hechos para obtener los datos de las respectivas tablas de cada apartado
            ObtenerRegistrosUsuarios();
            ObtenerRegistrosProductos();
            ObtenerMovimientos();

            credenciales();
        }

        public void ObtenerRegistrosUsuarios()
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

        private void ObtenerRegistrosProductos()
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

        private void ObtenerMovimientos()
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


        //===========================================Metodos y procesos para abrir y cerrar ventanas (Cierre y creacion de elementos)========================================================

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            //Estructura condicional para que solo se pueda abrir una ventana para crear usuario
            if(ventanaCrearUsuario == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearUsuario = new CrearUsuario();

                //Comando auxiliar para el proceso
                ventanaCrearUsuario.FormClosed += new FormClosedEventHandler (CierreVentanaCrearUsuario);

                //Se muestra la ventana correspondiente
                ventanaCrearUsuario.Show();

                this.Close();
            }

        }

        void CierreVentanaCrearUsuario(object sender, EventArgs e)
        {
            ventanaCrearUsuario = null;
        }

        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
            //Estructura condicional para que solo se pueda abrir una ventana para crear usuario
            if (ventanaCrearProducto == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearProducto = new CrearProducto();

                //Comando auxiliar para el proceso
                ventanaCrearProducto.FormClosed += new FormClosedEventHandler(CierreVentanaCrearProducto);

                //Se muestra la ventana correspondiente
                ventanaCrearProducto.Show();

                this.Close();
            }
        }

        void CierreVentanaCrearProducto(object sender, EventArgs e)
        {
            ventanaCrearProducto = null;
        }

        private void btn_CrearMovimiento_Click(object sender, EventArgs e)
        {
            if (ventanaCrearMovimiento == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearMovimiento = new CrearMovimiento();

                //Comando auxiliar para el proceso
                ventanaCrearMovimiento.FormClosed += new FormClosedEventHandler(CierreVentanaCrearMovimiento);

                //Se muestra la ventana correspondiente
                ventanaCrearMovimiento.Show();

                this.Close();
            }
        }

        void CierreVentanaCrearMovimiento(object sender, EventArgs e)
        {
            ventanaCrearMovimiento = null;
        }

        private void btn_CrearCategorias_Click(object sender, EventArgs e)
        {
            if (ventanaCrearCategoria == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearCategoria = new CrearCategoria();

                //Comando auxiliar para el proceso
                ventanaCrearCategoria.FormClosed += new FormClosedEventHandler(CierreVentanaCrearCategoria);

                //Se muestra la ventana correspondiente
                ventanaCrearCategoria.Show();

                this.Close();
            }
        }

        void CierreVentanaCrearCategoria(object sender, EventArgs e)
        {
            ventanaCrearCategoria = null;
        }

        private void btn_CrearMarca_Click(object sender, EventArgs e)
        {
            if (ventanaCrearMarca == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearMarca = new CrearMarca();

                //Comando auxiliar para el proceso
                ventanaCrearMarca.FormClosed += new FormClosedEventHandler(CierreVentanaCrearMarca);

                //Se muestra la ventana correspondiente
                ventanaCrearMarca.Show();
               
                this.Close();
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
            if (ventanaCrearColor == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearColor = new CrearColores();

                //Comando auxiliar para el proceso
                ventanaCrearColor.FormClosed += new FormClosedEventHandler(CierreVentanaCrearColor);

                //Se muestra la ventana correspondiente
                ventanaCrearColor.Show();

                this.Close();
            }
        }

        void CierreVentanaCrearColor(object sender, EventArgs e)
        {
            ventanaCrearColor = null;
        }

        private void btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            if (ventanaEditarProducto == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaEditarProducto = new EditarProducto();

                //Comando auxiliar para el proceso
                ventanaEditarProducto.FormClosed += new FormClosedEventHandler(CierreVentanaModificarProducto);

                //Se muestra la ventana correspondiente
                ventanaEditarProducto.Show();

                this.Close();
            }
        }

        void CierreVentanaModificarProducto(object sender, EventArgs e)
        {
            ventanaEditarProducto = null;
        }

        private void btn_Causas_Click(object sender, EventArgs e)
        {
            if (ventanaCrearCausa == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearCausa = new CrearCausa();

                //Comando auxiliar para el proceso
                ventanaCrearCausa.FormClosed += new FormClosedEventHandler(CierreVentanaCrearCausa);

                //Se muestra la ventana correspondiente
                ventanaCrearCausa.Show();

                this.Close();
            }
        }

        void CierreVentanaCrearCausa(object sender, EventArgs e)
        {
            ventanaCrearCausa = null;
        }

        //====================================================================================================================================================================================


        //Procedimiento para implementar una busqueda dinamica en la barra de busqueda (El mismo tiempo que se escribe se filtra)
        private void txtbox_Buscar_TextChanged(object sender, EventArgs e)
        {
            if(rdbtn_Nombre.Checked == true)
            {
                //En este caso se utiliza la consulta "LIKE" para mostrar los valores que coinciden con los caracteres escritos
                (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '{0}%' OR Nombre LIKE '%{0}%'", txtbox_BuscarUsuario.Text);
            }
            else if(rdbtn_ID.Checked == true)
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

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGrid_Usuarios.SelectedRows.Count == 1)
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

        private void btn_ModificarUsuario_Click(object sender, EventArgs e)
        {
            //Estructura condicional para que solo se pueda abrir una ventana para crear usuario
            if (ventanaEditarUsuario == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaEditarUsuario = new EditarUsuario();

                //Comando auxiliar para el proceso
                ventanaEditarUsuario.FormClosed += new FormClosedEventHandler(CierreVentanaEditarUsuarios);

                //Se muestra la ventana correspondiente
                ventanaEditarUsuario.Show();

                this.Close();
            }
        
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGrid_Productos.SelectedRows.Count == 1)
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
            try
            {
                if (DataGrid_Movimientos.SelectedRows.Count == 1)
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
            /*try
            {*/
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
          /*  }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }*/
        }

        private void btn_RepStock_Click(object sender, EventArgs e)
        {
            ReporteStockForm frm = new ReporteStockForm();
            frm.Show();
        }

        private void btn_RepMovimientos_Click(object sender, EventArgs e)
        {
            ReporteMovimientosForm frm = new ReporteMovimientosForm();
            frm.Show();
        }

        private void btn_RepAuditoria_Click(object sender, EventArgs e)
        {
            ReporteAuditoriaForms frm = new ReporteAuditoriaForms();
            frm.Show();
        }

        private void credenciales()
        {
            btn_Eliminar.Visible = false;
        }
    }
}
