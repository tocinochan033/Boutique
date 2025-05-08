using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Boutique.Forms.Forms_secundarios.Crear
{
    public partial class CrearMarca : Form
    {

        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion = new databaseConnection();

        //Creacion de un objeto SqlDataAdapter para reutilizarlo mas adelante
        SqlDataAdapter adaptador = new SqlDataAdapter();

        public CrearMarca()
        {
            InitializeComponent();
        }

        private void CrearMarca_Load(object sender, EventArgs e)
        {
            ObtenerRegistrosMarcas();
        }

        public void ObtenerRegistrosMarcas()
        {
            conexion.Open();
            //Creacion de consulta para visualizar todos los campos de las respectivas tablas
            String ConsultaMarcas = "Select * from MARCA";

            //Se utiliza el objeto sqldataadapter creado anteriormente
            adaptador = new SqlDataAdapter(ConsultaMarcas, conexion.getConnection());

            //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
            DataTable dtMARCAS = new DataTable();

            //Se pasan los datos del datatable al objeto adaptador
            adaptador.Fill(dtMARCAS);

            //Se envian los parametros al datagridview de usuarios
            DataGrid_Marcas.DataSource = dtMARCAS;
            conexion.Close();
        }

        private void btn_EliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGrid_Marcas.SelectedRows.Count == 1)
                {
                    conexion.Open();

                    int id = Convert.ToInt32(DataGrid_Marcas.CurrentRow.Cells["ID_Marca"].Value);

                    string query = $"UPDATE MARCA SET Visibilidad = 0 WHERE ID_Marca = {id}";
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

                    ObtenerRegistrosMarcas();
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

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
            //Se cierra la ventana/formulario actual
            this.Close();
        }

        private void btn_CrearMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_IDMarca.Text == "" || txtbox_NombreMarca.Text == "")
                {
                    MessageBox.Show("Favor de no dejar campos en blanco");
                }
                else
                {
                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un nombre igual al recien ingresado
                    string query = "SELECT COUNT(*) FROM MARCA WHERE Nombre = @nombre";
                    SqlCommand command = new SqlCommand(query, conexion.getConnection());
                    command.Parameters.AddWithValue("@nombre", txtbox_NombreMarca.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count = (int)command.ExecuteScalar();

                    conexion.Close();

                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un ID igual al recien ingresado
                    string query2 = "SELECT COUNT(*) FROM MARCA WHERE ID_Marca = @id";
                    SqlCommand command2 = new SqlCommand(query2, conexion.getConnection());
                    command2.Parameters.AddWithValue("@id", txtbox_IDMarca.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count2 = (int)command2.ExecuteScalar();

                    conexion.Close();
                    //Se evalua la existencia del dato, si no existe se inserta normalmente, si si existe se solicita que se cambie de nombre
                    if (count == 0 && count2 == 0)
                    {
                        conexion.Open();

                        //Se crea un string que contenga todo el comando de insercion a la base de datos
                        string insercion = $"INSERT INTO MARCA (ID_Marca,Nombre,Visibilidad) VALUES({txtbox_IDMarca.Text},'{txtbox_NombreMarca.Text}',1)";

                        //se crea un sql command para insertar los datos
                        SqlCommand comandoInsercion = new SqlCommand(insercion, conexion.getConnection());

                        //Ejecucion del comando
                        comandoInsercion.ExecuteNonQuery();

                        //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                        MessageBox.Show("Marca agregada exitosamente");

                        conexion.Close();

                        limpiarcampos();
                        ObtenerRegistrosMarcas();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un elemento con esa ID o Nombre, favor de introducir otro");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");

            }
            
        }

        private void limpiarcampos()
        {
            txtbox_NombreMarca.Text = "";
            txtbox_IDMarca.Text = "";
        }
    }
}
