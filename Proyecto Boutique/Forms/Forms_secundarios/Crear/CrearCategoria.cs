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
    public partial class CrearCategoria : Form
    {

        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion =  new databaseConnection();


        //Creacion de un objeto SqlDataAdapter para reutilizarlo mas adelante
        SqlDataAdapter adaptador = new SqlDataAdapter();
        public CrearCategoria()
        {
            InitializeComponent();
        }

        private void btn_CrearCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_IDCategoria.Text == "" || txtbox_NombreCategoria.Text == "" || txtbox_DescripcionCategoria.Text == "") 
                {
                    MessageBox.Show("Favor de no dejar campos en blanco");
                }
                else
                {
                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un nombre igual al recien ingresado
                    string query = "SELECT COUNT(*) FROM CATEGORIA WHERE Nombre = @nombre";
                    SqlCommand command = new SqlCommand(query, conexion.getConnection());
                    command.Parameters.AddWithValue("@nombre", txtbox_NombreCategoria.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count = (int)command.ExecuteScalar();

                    conexion.Close();

                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un ID igual al recien ingresado
                    string query2 = "SELECT COUNT(*) FROM MARCA WHERE ID_Marca = @id";
                    SqlCommand command2 = new SqlCommand(query2, conexion.getConnection());
                    command2.Parameters.AddWithValue("@id", txtbox_IDCategoria.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count2 = (int)command2.ExecuteScalar();

                    conexion.Close();
                    //Se evalua la existencia del dato, si no existe se inserta normalmente, si si existe se solicita que se cambie de nombre
                    if (count == 0 && count2 == 0)
                    {
                        conexion.Open();

                        //Se crea un string que contenga todo el comando de insercion a la base de datos
                        string insercion = $"INSERT INTO CATEGORIA (ID_Categoria,Nombre,Descripcion,Visibilidad) VALUES({txtbox_IDCategoria.Text},'{txtbox_NombreCategoria.Text}','{txtbox_DescripcionCategoria.Text}',1)";

                        //se crea un sql command para insertar los datos
                        SqlCommand comandoInsercion = new SqlCommand(insercion, conexion.getConnection());

                        //Ejecucion del comando
                        comandoInsercion.ExecuteNonQuery();

                        //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                        MessageBox.Show("Categoria agregada exitosamente");

                        conexion.Close();

                        limpiarcampos();
                        ObtenerRegistrosCategoria();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un elemento con esa ID o nombre, favor de ingresar otro");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
            
        }

        private void DataGrid_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_CrearCategoria_Click(object sender, EventArgs e)
        {

        }

        private void CrearCategoria_Load(object sender, EventArgs e)
        {
            ObtenerRegistrosCategoria();
        }
        public void ObtenerRegistrosCategoria()
        {
            conexion.Open();
            //Creacion de consulta para visualizar todos los campos de las respectivas tablas
            String ConsultaCategoria = "Select * from CATEGORIA";

            //Se utiliza el objeto sqldataadapter creado anteriormente
            adaptador = new SqlDataAdapter(ConsultaCategoria, conexion.getConnection());

            //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
            DataTable dtCATEGORIAS = new DataTable();

            //Se pasan los datos del datatable al objeto adaptador
            adaptador.Fill(dtCATEGORIAS);

            //Se envian los parametros al datagridview de usuarios
            DataGrid_Categorias.DataSource = dtCATEGORIAS;
            conexion.Close();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
            //Se cierra la ventana/formulario actual
            this.Close();
        }
    
        private void limpiarcampos()
        {
            txtbox_IDCategoria.Text = "";
            txtbox_NombreCategoria.Text = "";
            txtbox_DescripcionCategoria.Text = "";
        }

        private void btn_EliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {


                if (DataGrid_Categorias.SelectedRows.Count == 1)
                {
                    conexion.Open();

                    int id = Convert.ToInt32(DataGrid_Categorias.CurrentRow.Cells["ID_Categoria"].Value);

                    string query = $"UPDATE CATEGORIA SET Visibilidad = 0 WHERE ID_Categoria = {id}";
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

                    ObtenerRegistrosCategoria();
                }
                else
                {
                    MessageBox.Show("Favor de elegir algun registro");
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado"); 
            }
        }
    }

}
