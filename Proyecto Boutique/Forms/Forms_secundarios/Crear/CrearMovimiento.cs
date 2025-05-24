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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Proyecto_Boutique
{
    public partial class CrearMovimiento : Form
    {

        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion = new databaseConnection();

        //Creacion de un objeto SqlDataAdapter para reutilizarlo mas adelante
        SqlDataAdapter adaptador = new SqlDataAdapter();

        //Metodo para impedir que se pueda pegar texto en los campos
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private Principal_forms formsprincipal;

        public CrearMovimiento(Principal_forms princsforms)
        {
            InitializeComponent();

            formsprincipal = princsforms;
        }

        private void CrearMovimiento_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarCampoTipoMovimiento();
                RefrescarCampoProductos();
                RefrescarCampoUsuario();
                ObtenerRegistrosUsuarios();
                ObtenerRegistrosProductos();
                actualizarID();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void actualizarID()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Movimiento) FROM MOVIMIENTOS", conexion.getConnection());
                object result = cmd.ExecuteScalar();
                int ultimaId;
                int sumultimaID;

                ultimaId = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                if (ultimaId == 0)
                {
                    txt_IDMovimiento.Text = 1.ToString();
                }
                else
                {
                    sumultimaID = ultimaId + 1;

                    txt_IDMovimiento.Text = sumultimaID.ToString();
                }
                conexion.Close();

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        public void RefrescarCampoCausaEntrada()
        {
            try
            {
                //Se limpian los elementos actuales del combobox "Rol"
                cmb_Causa.Items.Clear();

                //se abre conexion
                conexion.Open();

                //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
                SqlCommand cm = new SqlCommand("select*from CAUSA WHERE Visibilidad = 1 AND ID_Causa < 4 OR ID_Causa > 10", conexion.getConnection());

                //Se crea un objeto sqldatareader para leer los Roles
                SqlDataReader dr = cm.ExecuteReader();

                //se crea un ciclo while para rellenar el combobox de Roles
                while (dr.Read())
                {
                    cmb_Causa.Items.Add(dr.GetString(1));
                }

                //Se cierra la conexion
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void RefrescarCampoCausaSalida()
        {
            try
            {
                //Se limpian los elementos actuales del combobox "Rol"
                cmb_Causa.Items.Clear();

                //se abre conexion
                conexion.Open();

                //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
                SqlCommand cm = new SqlCommand("select*from CAUSA WHERE Visibilidad = 1 AND ID_Causa > 3", conexion.getConnection());

                //Se crea un objeto sqldatareader para leer los Roles
                SqlDataReader dr = cm.ExecuteReader();

                //se crea un ciclo while para rellenar el combobox de Roles
                while (dr.Read())
                {
                    cmb_Causa.Items.Add(dr.GetString(1));
                }

                //Se cierra la conexion
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void RefrescarCampoTipoMovimiento()
        {
            try
            {
                //Se limpian los elementos actuales del combobox "Rol"
                cmb_TipoMovimiento.Items.Clear();

                //se abre conexion
                conexion.Open();

                //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
                SqlCommand cm = new SqlCommand("select*from TIPOMOVIMIENTO", conexion.getConnection());

                //Se crea un objeto sqldatareader para leer los Roles
                SqlDataReader dr = cm.ExecuteReader();

                //se crea un ciclo while para rellenar el combobox de Roles
                while (dr.Read())
                {
                    cmb_TipoMovimiento.Items.Add(dr.GetString(1));
                }

                //Se cierra la conexion
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void RefrescarCampoProductos()
        {
            try
            {
                //Se limpian los elementos actuales del combobox "Rol"
                cmb_Producto.Items.Clear();

                //se abre conexion
                conexion.Open();

                //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
                SqlCommand cm = new SqlCommand("select*from PRODUCTOS WHERE Visibilidad = 1", conexion.getConnection());

                //Se crea un objeto sqldatareader para leer los Roles
                SqlDataReader dr = cm.ExecuteReader();

                //se crea un ciclo while para rellenar el combobox de Roles
                while (dr.Read())
                {
                    cmb_Producto.Items.Add(dr.GetString(1));
                }

                //Se cierra la conexion
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void RefrescarCampoUsuario()
        {
            try
            {
                //Se limpian los elementos actuales del combobox "Rol"
                cmb_UsuarioResponsable.Items.Clear();

                //se abre conexion
                conexion.Open();

                //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
                SqlCommand cm = new SqlCommand("select*from USUARIO WHERE Visibilidad = 1", conexion.getConnection());

                //Se crea un objeto sqldatareader para leer los Roles
                SqlDataReader dr = cm.ExecuteReader();

                //se crea un ciclo while para rellenar el combobox de Roles
                while (dr.Read())
                {
                    cmb_UsuarioResponsable.Items.Add(dr.GetString(1));
                }

                //Se cierra la conexion
                conexion.Close();
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
                String ConsultaUsuarios = "Select * from USUARIO WHERE Visibilidad = 1";

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
                String ConsultaProductos = "Select * from PRODUCTOS WHERE Visibilidad = 1";

                //Se utiliza el objeto sqldataadapter creado anteriormente
                adaptador = new SqlDataAdapter(ConsultaProductos, conexion.getConnection());

                //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
                DataTable dtPRODUCTOS = new DataTable();

                //Se pasan los datos del datatable al objeto adaptador
                adaptador.Fill(dtPRODUCTOS);

                //Se envian los parametros al datagridview de usuarios
                datagrid_Productos.DataSource = dtPRODUCTOS;
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        private void DataGrid_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = cmb_UsuarioResponsable.FindStringExact(DataGrid_Usuarios.CurrentRow.Cells[1].Value.ToString());

            cmb_UsuarioResponsable.SelectedIndex = indice;
        }

        private void datagrid_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = cmb_Producto.FindStringExact(datagrid_Productos.CurrentRow.Cells[1].Value.ToString());

            cmb_Producto.SelectedIndex = indice;
        }

        private void txtbox_BuscarUSUARIO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbtn_NombreUSUARIOS.Checked == true)
                {
                    //En este caso se utiliza la consulta "LIKE" para mostrar los valores que coinciden con los caracteres escritos
                    (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '{0}%' OR Nombre LIKE '%{0}%'", txtbox_BuscarUSUARIO.Text);
                }
                else if (rdbtn_IDUSUARIOS.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BuscarUSUARIO.Text, out int id))
                    {
                        (DataGrid_Usuarios.DataSource as DataTable).DefaultView.RowFilter = $"ID_Usuario = {txtbox_BuscarUSUARIO.Text}";
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
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        private void txtbox_BuscarPRODUCTO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbtn_NombrePRODUCTOS.Checked == true)
                {
                    //En este caso se utiliza la consulta "LIKE" para mostrar los valores que coinciden con los caracteres escritos
                    (datagrid_Productos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombre LIKE '{0}%' OR Nombre LIKE '%{0}%'", txtbox_BuscarPRODUCTO.Text);
                }
                else if (rdbtn_IDPRODUCTOS.Checked == true)
                {
                    // Para campos numéricos, no usar LIKE sino comparación directa
                    if (int.TryParse(txtbox_BuscarPRODUCTO.Text, out int id))
                    {
                        (datagrid_Productos.DataSource as DataTable).DefaultView.RowFilter = $"ID_Producto = {txtbox_BuscarPRODUCTO.Text}";
                    }
                    else
                    {
                        // Si no es número válido, limpiar el filtro
                        (datagrid_Productos.DataSource as DataTable).DefaultView.RowFilter = "";
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

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
            //Se cierra la ventana/formulario actual
            this.Close();
        }

        private void btn_CrearMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Causa.Text == "" || cmb_Producto.Text == "" || txtbox_CantidadProducto.Text == "" ||
                    txt_IDMovimiento.Text == "" || cmb_TipoMovimiento.Text == "" || cmb_UsuarioResponsable.Text == "")
                {
                    MessageBox.Show("Favor de no dejar campos en blanco");
                }
                else
                {
                    //Creacion de la variable para capturar el ID del elemento seleccionado
                    int causaSeleccionada = 0, productoSeleccionado = 0, tipoMovimientoSeleccionado = 0, usuarioSeleccionado = 0;

                    //Se abre conexion
                    conexion.Open();

                    //Proceso para capturar la ID correspondiente al elemento seleccionado
                    //Se crea un comando para seleccionar el elemento que coincida con el nombre del rol seleccionado
                    SqlCommand cm = new SqlCommand("Select*from CAUSA where Causa = '" + cmb_Causa.Text + "'", conexion.getConnection());
                    //Se crea un sqldatareader
                    SqlDataReader dr = cm.ExecuteReader();

                    //Se captura la id en una variable declarada anteriormente
                    if (dr.Read() == true)
                    {
                        causaSeleccionada = int.Parse(dr["ID_Causa"].ToString());
                    }
                    conexion.Close();

                    //Se abre conexion
                    conexion.Open();

                    //Proceso para capturar la ID correspondiente al elemento seleccionado
                    //Se crea un comando para seleccionar el elemento que coincida con el nombre del rol seleccionado
                    SqlCommand cm2 = new SqlCommand("Select*from PRODUCTOS where Nombre = '" + cmb_Producto.Text + "'", conexion.getConnection());
                    //Se crea un sqldatareader
                    SqlDataReader dr2 = cm2.ExecuteReader();

                    //Se captura la id en una variable declarada anteriormente
                    if (dr2.Read() == true)
                    {
                        productoSeleccionado = int.Parse(dr2["ID_Producto"].ToString());
                    }
                    conexion.Close();

                    //Se abre conexion
                    conexion.Open();

                    //Proceso para capturar la ID correspondiente al elemento seleccionado
                    //Se crea un comando para seleccionar el elemento que coincida con el nombre del rol seleccionado
                    SqlCommand cm3 = new SqlCommand("Select*from TIPOMOVIMIENTO where Nombre = '" + cmb_TipoMovimiento.Text + "'", conexion.getConnection());
                    //Se crea un sqldatareader
                    SqlDataReader dr3 = cm3.ExecuteReader();

                    //Se captura la id en una variable declarada anteriormente
                    if (dr3.Read() == true)
                    {
                        tipoMovimientoSeleccionado = int.Parse(dr3["ID_Tipo"].ToString());
                    }
                    conexion.Close();

                    //Se abre conexion
                    conexion.Open();

                    //Proceso para capturar la ID correspondiente al elemento seleccionado
                    //Se crea un comando para seleccionar el elemento que coincida con el nombre del rol seleccionado
                    SqlCommand cm4 = new SqlCommand("Select*from USUARIO where Nombre = '" + cmb_UsuarioResponsable.Text + "'", conexion.getConnection());
                    //Se crea un sqldatareader
                    SqlDataReader dr4 = cm4.ExecuteReader();

                    //Se captura la id en una variable declarada anteriormente
                    if (dr4.Read() == true)
                    {
                        usuarioSeleccionado = int.Parse(dr4["ID_Usuario"].ToString());
                    }
                    conexion.Close();

//----------------------------------------------------------------------------------------------------------------------------------------------------------------

                    conexion.Open();
                    // Consulta SQL para verificar si existe un Movimiento con un ID igual al recien ingresado
                    string query = "SELECT COUNT(*) FROM MOVIMIENTOS WHERE ID_Movimiento = @id";
                    SqlCommand command = new SqlCommand(query, conexion.getConnection());
                    command.Parameters.AddWithValue("@id", txt_IDMovimiento.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count = (int)command.ExecuteScalar();

                    conexion.Close();

                    //Se evalua la existencia del dato, si no existe se inserta normalmente, si si existe se solicita que se cambie de nombre
                    if (count == 0)
                    {

                        //ESTA SECCION ES PARA OBTENER EL VALOR ACTUAL DE LOS PRODUCTOS Y SUMARLO AL DE ENTRADA
                        conexion.Open();

                        //Se crea un string que contenga todo el comando de insercion a la base de datos
                        string consulta = $"SELECT Cantidad FROM PRODUCTOS WHERE ID_Producto = {productoSeleccionado}";

                        //se crea un sql command para insertar los datos
                        SqlCommand comandoConsulta = new SqlCommand(consulta, conexion.getConnection());

                        //Ejecucion del comando
                        int cantidadActual = (int)comandoConsulta.ExecuteScalar();

                        int cantidadModificada = int.Parse(txtbox_CantidadProducto.Text);

                        conexion.Close();

                        int resta = 1;

                        //SE EVALUA ANTES QUE NADA QUE SI ES UNA SALIDA NO PUEDA DEJAR EN NUMEROS NEGATIVOS AL STOCK
                        if (tipoMovimientoSeleccionado == 2)
                        {
                            resta = cantidadActual - cantidadModificada;
                        }

                        if (resta >= 0)
                        {
                            //AQUI SE EXTRAE EL VALOR DEL PUNTO DE REORDEN DEL PRODUCTO
                            conexion.Open();
                            //Se crea un string que contenga todo el comando de insercion a la base de datos
                            string consultaPuntoReorden = $"SELECT PuntoReorden FROM PRODUCTOS WHERE ID_Producto = {productoSeleccionado}";

                            //se crea un sql command para insertar los datos
                            SqlCommand comandoConsultaReorden = new SqlCommand(consultaPuntoReorden, conexion.getConnection());

                            //Ejecucion del comando
                            int cantidadReorden = (int)comandoConsultaReorden.ExecuteScalar();
                            conexion.Close();

                            conexion.Open();

                            //Se crea un string que contenga todo el comando de insercion a la base de datos
                            string insercion = "INSERT INTO MOVIMIENTOS (Usuario, Producto, TipoMovimiento, Cantidad, Causa, Fecha) " +
                            $"VALUES ({usuarioSeleccionado},{productoSeleccionado},{tipoMovimientoSeleccionado},{txtbox_CantidadProducto.Text}" +
                            $",{causaSeleccionada},GETDATE())";

                            //se crea un sql command para insertar los datos
                            SqlCommand comandoInsercion = new SqlCommand(insercion, conexion.getConnection());

                            //Ejecucion del comando
                            comandoInsercion.ExecuteNonQuery();

                            //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                            MessageBox.Show("Registro agregado exitosamente");

                            conexion.Close();

                            //SI LA VARIABLE ES IGUAL A 1 SIGNIFICA QUE FUE ENTRADA
                            if (tipoMovimientoSeleccionado == 1)
                            {

                                int suma = cantidadModificada + cantidadActual;

                                //ESTA SECCION ES PARA EJECUTAR EL QUERY Y ACTUALIZAR EL VALOR
                                conexion.Open();

                                string actualizacionDeCantidad = $"UPDATE PRODUCTOS SET Cantidad = {suma} WHERE ID_Producto = {productoSeleccionado}";

                                //se crea un sql command para insertar los datos
                                SqlCommand comandoActualizacionDeValores = new SqlCommand(actualizacionDeCantidad, conexion.getConnection());

                                comandoActualizacionDeValores.ExecuteNonQuery();

                                conexion.Close();


                                //AQUI SE EXTRAE EL VALOR MAXIMO DE STOCK DEL PRODUCTO SELECCIONADO
                                conexion.Open();
                                //Se crea un string que contenga todo el comando de insercion a la base de datos
                                string consultaMaximoProducto = $"SELECT Maximo FROM PRODUCTOS WHERE ID_Producto = {productoSeleccionado}";

                                //se crea un sql command para insertar los datos
                                SqlCommand comandoConsultaMaximo = new SqlCommand(consultaMaximoProducto, conexion.getConnection());

                                //Ejecucion del comando
                                int cantidadMaxima = (int)comandoConsultaMaximo.ExecuteScalar();
                                conexion.Close();                            

                                //ESTA CONDICION VERIFICARA EN CASO DE QUE SE HAYA REVASADO LA CANTIDAD MAXIMA DE STOCK
                                if (suma >= cantidadMaxima)
                                {
                                    MessageBox.Show("Ah excedido la cantidad Maxima de stock, favor de tomar las acciones pertinentes");
                                }
                                else if (suma <= cantidadReorden)
                                {
                                    MessageBox.Show("El punto de reorden ha sido pasado, favor de rehabastecer stock");
                                }
                            }
                            else
                            {
                                //ESTA SECCION ES PARA EJECUTAR EL QUERY Y ACTUALIZAR EL VALOR
                                conexion.Open();

                                string actualizacionDeCantidadRESTA = $"UPDATE PRODUCTOS SET Cantidad = {resta} WHERE ID_Producto = {productoSeleccionado}";

                                //se crea un sql command para insertar los datos
                                SqlCommand comandoActualizacionDeValores = new SqlCommand(actualizacionDeCantidadRESTA, conexion.getConnection());

                                comandoActualizacionDeValores.ExecuteNonQuery();

                                conexion.Close();

                                //AQUI SE EXTRAE EL VALOR MINIMO DE STOCK DEL PRODUCTO SELECCIONADO
                                conexion.Open();
                                //Se crea un string que contenga todo el comando de insercion a la base de datos
                                string consultaMinimoProducto = $"SELECT Minimo FROM PRODUCTOS WHERE ID_Producto = {productoSeleccionado}";

                                //se crea un sql command para insertar los datos
                                SqlCommand comandoConsultaMinimo = new SqlCommand(consultaMinimoProducto, conexion.getConnection());

                                //Ejecucion del comando
                                int cantidadMinima = (int)comandoConsultaMinimo.ExecuteScalar();
                                conexion.Close();

                                //ESTA CONDICION VERIFICARA EN CASO DE QUE SE HAYA REVASADO LA CANTIDAD MAXIMA DE STOCK
                                if (resta <= cantidadMinima)
                                {
                                    MessageBox.Show("Ah excedido la cantidad Minima de stock, favor de tomar las acciones pertinentes");

                                    if (resta <= cantidadReorden)
                                    {
                                        MessageBox.Show("El punto de reorden ha sido pasado, favor de rehabastecer stock");
                                    }
                                }
                                else if (resta <= cantidadReorden)
                                {
                                    MessageBox.Show("El punto de reorden ha sido pasado, favor de rehabastecer stock");
                                }
                            }

                            limpiarcampos();
                            ObtenerRegistrosProductos();
                            ObtenerRegistrosUsuarios();
                            actualizarID();

                            formsprincipal.ObtenerMovimientos();
                            formsprincipal.ObtenerRegistrosMovimientosParaReportes();
                        }
                        else
                        {
                            MessageBox.Show("La cantidad seleccionada rebasa la capacidad actual del stock");
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un Movimiento esa ID, favor de ingresar otra");
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah ocurrido un error inesperado:" + ex.Message);
                conexion.Close();
            }
        }

        private void limpiarcampos()
        {
            txtbox_BuscarPRODUCTO.Text = "";
            txtbox_BuscarUSUARIO.Text = "";
            txtbox_CantidadProducto.Text = "";
            txt_IDMovimiento.Text = "";
            cmb_Causa.SelectedIndex = -1;
            cmb_Producto.SelectedIndex = -1;
            cmb_TipoMovimiento.SelectedIndex = -1;
            cmb_UsuarioResponsable.SelectedIndex = -1;
        }

        private void CrearMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_IDMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir Control de teclas como retroceso
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            //Permitir solo digitos y punto
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbox_CantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir Control de teclas como retroceso
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            //Permitir solo digitos y punto
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CrearMovimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void cmb_TipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_TipoMovimiento.SelectedIndex == 0)
            {
                RefrescarCampoCausaEntrada();
            }
            else if(cmb_TipoMovimiento.SelectedIndex == 1)
            {
                RefrescarCampoCausaSalida();
            }
        }
    }
}
