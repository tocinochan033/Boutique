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
    public partial class CrearProducto : Form
    {

        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion = new databaseConnection();

        //Metodo para impedir que se pueda pegar texto en los campos
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public CrearProducto()
        {
            InitializeComponent();
        }

        private void CrearProducto_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarCampoCategoria();
                RefrescarCampoColor();
                RefrescarCampoMarca();
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
                SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Producto) FROM PRODUCTOS", conexion.getConnection());
                object result = cmd.ExecuteScalar();
                int ultimaId;
                int sumultimaID;

                ultimaId = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                if (ultimaId == 0)
                {
                    txtbox_IDProducto.Text = 1.ToString();
                }
                else
                {
                    sumultimaID = ultimaId + 1;

                    txtbox_IDProducto.Text = sumultimaID.ToString();
                }
                conexion.Close();

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        private void actualizacion_TimeP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
            //Se cierra la ventana/formulario actual
            this.Close();
        }

        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
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
                    // Consulta SQL para verificar si existe un usuario con un nombre igual al recien ingresado
                    string query = "SELECT COUNT(*) FROM PRODUCTOS WHERE Nombre = @nombre";
                    SqlCommand command = new SqlCommand(query, conexion.getConnection());
                    command.Parameters.AddWithValue("@nombre", txtbox_NombreProducto.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count = (int)command.ExecuteScalar();

                    conexion.Close();

                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un ID igual al recien ingresado
                    string query2 = "SELECT COUNT(*) FROM PRODUCTOS WHERE ID_Producto = @id";
                    SqlCommand command2 = new SqlCommand(query2, conexion.getConnection());
                    command2.Parameters.AddWithValue("@id", txtbox_IDProducto.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count2 = (int)command2.ExecuteScalar();

                    conexion.Close();

                        //Se evalua la existencia del dato, si no existe se inserta normalmente, si si existe se solicita que se cambie de nombre
                        if (count == 0 && count2 == 0)
                        {
                            conexion.Open();

                            //Se crea un string que contenga todo el comando de insercion a la base de datos
                            string insercion = "INSERT INTO PRODUCTOS (Nombre, Marca, Descripcion, Categoria, Precio, Cantidad, Color, Talla, FechaEntrada, " +
                            $"PuntoReorden, Maximo, Minimo, Visibilidad) VALUES ('{txtbox_NombreProducto.Text}',{marcaSeleccionada},'{txtbox_DescripcionProducto.Text}'," +
                            $"{categoriaSeleccionada}, {txtbox_Precio.Text}, {txtbox_Cantidad.Text}, {colorSeleccionado}, '{txtbox_talla.Text}', GETDATE(), {txtbox_PuntoReorden.Text}, " +
                            $"{txtbox_MaximoStock.Text}, {txtbox_MinimoStock.Text}, 1)";

                            //se crea un sql command para insertar los datos
                            SqlCommand comandoInsercion = new SqlCommand(insercion, conexion.getConnection());

                            //Ejecucion del comando
                            comandoInsercion.ExecuteNonQuery();

                            //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                            MessageBox.Show("Registro agregado exitosamente");

                            conexion.Close();

                            limpiarcampos();
                            actualizarID();
                        }

                        else
                        {
                            MessageBox.Show("Ya existe un usuario con ese nombre o ID, favor de ingresar otro");
                        }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ah ocurrido un error inesperado:" + ex.Message);
                conexion.Close();
                limpiarcampos();
            }
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
            try
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
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }
        public void RefrescarCampoColor()
        {
            try
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
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void RefrescarCampoMarca()
        {
            try
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
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        private void txtbox_IDProducto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir Control de teclas como retroceso
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            //Permitir solo digitos y punto
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //Permitir solo un punto
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtbox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbox_PuntoReorden_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbox_MaximoStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbox_MinimoStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CrearProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
        }
    }
}
