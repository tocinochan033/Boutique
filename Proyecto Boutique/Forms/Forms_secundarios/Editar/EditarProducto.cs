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

namespace Proyecto_Boutique
{
    public partial class EditarProducto : Form
    {
        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion = new databaseConnection();

        //Creacion de un objeto SqlDataAdapter para reutilizarlo mas adelante
        SqlDataAdapter adaptador = new SqlDataAdapter();

        public EditarProducto()
        {
            InitializeComponent();
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            ObtenerRegistrosProductos();
            RefrescarCampoCategoria();
            RefrescarCampoColor();
            RefrescarCampoMarca();

            txtbox_IDProducto.ReadOnly = true;
        }

        public void ObtenerRegistrosProductos()
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
            DataGrid_Productos.DataSource = dtPRODUCTOS;
            conexion.Close();
        }

        private void limpiarcampos()
        {
            txtbox_Cantidad.Clear();
            txtbox_DescripcionProducto.Clear();
            txtbox_MaximoStock.Clear();
            txtbox_MinimoStock.Clear();
            txtbox_NombreProducto.Clear();
            txtbox_Precio.Clear();
            txtbox_PuntoReorden.Clear();
            txtbox_talla.Clear();
            txtbox_IDProducto.Clear();

            cmb_Marca.SelectedIndex = -1;
            cmb_Color.SelectedIndex = -1;
            cmb_Categoria.SelectedIndex = -1;
        }

        public void RefrescarCampoCategoria()
        {
            //Se limpian los elementos actuales del combobox "Rol"
            cmb_Categoria.Items.Clear();

            //se abre conexion
            conexion.Open();

            //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
            SqlCommand cm = new SqlCommand("select*from CATEGORIA WHERE Visibilidad = 1", conexion.getConnection());

            //Se crea un objeto sqldatareader para leer los Roles
            SqlDataReader dr = cm.ExecuteReader();

            //se crea un ciclo while para rellenar el combobox de Roles
            while (dr.Read())
            {
                cmb_Categoria.Items.Add(dr.GetString(1));
            }

            //Se cierra la conexion
            conexion.Close();
        }
        public void RefrescarCampoColor()
        {
            //Se limpian los elementos actuales del combobox "Rol"
            cmb_Color.Items.Clear();

            //se abre conexion
            conexion.Open();

            //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
            SqlCommand cm = new SqlCommand("select*from COLOR WHERE Visibilidad = 1", conexion.getConnection());

            //Se crea un objeto sqldatareader para leer los Roles
            SqlDataReader dr = cm.ExecuteReader();

            //se crea un ciclo while para rellenar el combobox de Roles
            while (dr.Read())
            {
                cmb_Color.Items.Add(dr.GetString(1));
            }

            //Se cierra la conexion
            conexion.Close();
        }

        public void RefrescarCampoMarca()
        {
            //Se limpian los elementos actuales del combobox "Rol"
            cmb_Marca.Items.Clear();

            //se abre conexion
            conexion.Open();

            //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
            SqlCommand cm = new SqlCommand("select*from MARCA WHERE Visibilidad = 1", conexion.getConnection());

            //Se crea un objeto sqldatareader para leer los Roles
            SqlDataReader dr = cm.ExecuteReader();

            //se crea un ciclo while para rellenar el combobox de Roles
            while (dr.Read())
            {
                cmb_Marca.Items.Add(dr.GetString(1));
            }

            //Se cierra la conexion
            conexion.Close();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
            //Se cierra la ventana/formulario actual
            this.Close();
        }

        private void DataGrid_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_IDProducto.Text = DataGrid_Productos.CurrentRow.Cells[0].Value.ToString();
                txtbox_NombreProducto.Text = DataGrid_Productos.CurrentRow.Cells[1].Value.ToString();
                cmb_Marca.SelectedIndex = int.Parse(DataGrid_Productos.CurrentRow.Cells[2].Value.ToString());
                txtbox_DescripcionProducto.Text = DataGrid_Productos.CurrentRow.Cells[3].Value.ToString();
                cmb_Categoria.SelectedIndex = int.Parse(DataGrid_Productos.CurrentRow.Cells[4].Value.ToString());
                txtbox_Precio.Text = DataGrid_Productos.CurrentRow.Cells[5].Value.ToString();
                txtbox_Cantidad.Text = DataGrid_Productos.CurrentRow.Cells[6].Value.ToString();
                cmb_Color.SelectedIndex = int.Parse(DataGrid_Productos.CurrentRow.Cells[7].Value.ToString());
                txtbox_talla.Text = DataGrid_Productos.CurrentRow.Cells[8].Value.ToString();
                txtbox_PuntoReorden.Text = DataGrid_Productos.CurrentRow.Cells[10].Value.ToString();
                txtbox_MaximoStock.Text = DataGrid_Productos.CurrentRow.Cells[11].Value.ToString();
                txtbox_MinimoStock.Text = DataGrid_Productos.CurrentRow.Cells[12].Value.ToString();
            }
            catch
            {
                txtbox_DescripcionProducto.Text = DataGrid_Productos.CurrentRow.Cells[3].Value.ToString();
                txtbox_Precio.Text = DataGrid_Productos.CurrentRow.Cells[5].Value.ToString();
                txtbox_Cantidad.Text = DataGrid_Productos.CurrentRow.Cells[6].Value.ToString();
                txtbox_talla.Text = DataGrid_Productos.CurrentRow.Cells[8].Value.ToString();
                txtbox_PuntoReorden.Text = DataGrid_Productos.CurrentRow.Cells[10].Value.ToString();
                txtbox_MaximoStock.Text = DataGrid_Productos.CurrentRow.Cells[11].Value.ToString();
                txtbox_MinimoStock.Text = DataGrid_Productos.CurrentRow.Cells[12].Value.ToString();
            }
            
        }

        private void btn_EditarProducto_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                if (txtbox_Cantidad.Text == "" || txtbox_DescripcionProducto.Text == "" || txtbox_MaximoStock.Text == "" || txtbox_MinimoStock.Text == "" ||
                    txtbox_NombreProducto.Text == "" || txtbox_Precio.Text == "" || txtbox_PuntoReorden.Text == "" || txtbox_talla.Text == "" || txtbox_IDProducto.Text == "" ||
                    cmb_Categoria.Text == "" || cmb_Color.Text == "" || cmb_Marca.Text == "")
                {
                    MessageBox.Show("Favor de no dejar campos en blanco");
                }
                else
                {
                    //Creacion de la variable para capturar el ID del los elementos seleccionados
                    int categoriaSeleccionada = 0, colorSeleccionado = 0, marcaSeleccionada = 0;

                    //Se abre conexion
                    conexion.Open();

                    //Proceso para capturar la ID correspondiente al elemento seleccionado
                    //Se crea un comando para seleccionar el elemento que coincida con el nombre del rol seleccionado
                    SqlCommand cm = new SqlCommand("Select*from CATEGORIA where Nombre = '" + cmb_Categoria.Text + "'", conexion.getConnection());
                    //Se crea un sqldatareader
                    SqlDataReader dr = cm.ExecuteReader();

                    //Se captura la id en una variable declarada anteriormente
                    if (dr.Read() == true)
                    {
                        categoriaSeleccionada = int.Parse(dr["ID_Categoria"].ToString());
                    }
                    conexion.Close();

                    //Se abre conexion
                    conexion.Open();

                    //Proceso para capturar la ID correspondiente al elemento seleccionado
                    //Se crea un comando para seleccionar el elemento que coincida con el nombre del rol seleccionado
                    SqlCommand cm2 = new SqlCommand("Select*from COLOR where Nombre = '" + cmb_Color.Text + "'", conexion.getConnection());
                    //Se crea un sqldatareader
                    SqlDataReader dr2 = cm2.ExecuteReader();

                    //Se captura la id en una variable declarada anteriormente
                    if (dr2.Read() == true)
                    {
                        colorSeleccionado = int.Parse(dr2["ID_Color"].ToString());
                    }
                    conexion.Close();

                    conexion.Open();
                    //Proceso para capturar la ID correspondiente al elemento seleccionado
                    //Se crea un comando para seleccionar el elemento que coincida con el nombre del rol seleccionado
                    SqlCommand cm3 = new SqlCommand("Select*from MARCA where Nombre = '" + cmb_Marca.Text + "'", conexion.getConnection());
                    //Se crea un sqldatareader
                    SqlDataReader dr3 = cm3.ExecuteReader();

                    //Se captura la id en una variable declarada anteriormente
                    if (dr3.Read() == true)
                    {
                        marcaSeleccionada = int.Parse(dr3["ID_Marca"].ToString());
                    }
                    conexion.Close();

                    conexion.Open();

                    //Se crea un string que contenga todo el comando de insercion a la base de datos
                    string ModificacionProducto = $"UPDATE PRODUCTOS SET Nombre = '{txtbox_NombreProducto.Text}', Marca = {marcaSeleccionada} " +
                        $", Descripcion = '{txtbox_DescripcionProducto.Text}', Categoria = {categoriaSeleccionada}, Precio = {txtbox_Precio.Text}, Cantidad = {txtbox_Cantidad.Text}, " +
                        $"Color = {colorSeleccionado}, Talla = '{txtbox_talla.Text}', FechaEntrada = GETDATE(), " +
                    $"PuntoReorden = {txtbox_PuntoReorden.Text}, Maximo = {txtbox_MaximoStock.Text}, Minimo = {txtbox_MinimoStock.Text}, Visibilidad = 1 WHERE ID_Producto = {txtbox_IDProducto.Text}";

                    //se crea un sql command para insertar los datos
                    SqlCommand comandoModificacion = new SqlCommand(ModificacionProducto, conexion.getConnection());

                    //Ejecucion del comando
                    comandoModificacion.ExecuteNonQuery();

                    //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                    MessageBox.Show("Registro agregado exitosamente");

                    conexion.Close();

                    limpiarcampos();
                    ObtenerRegistrosProductos();

                }

            /*}
            catch (Exception ex)
            {
                MessageBox.Show("Ah ocurrido un error inesperado:" + ex.Message);
                conexion.Close();
                limpiarcampos();
            }*/
        }
    }
}
