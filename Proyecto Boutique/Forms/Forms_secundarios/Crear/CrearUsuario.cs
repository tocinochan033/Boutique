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
    public partial class CrearUsuario : Form
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

        public CrearUsuario()
        {
            InitializeComponent();
            try
            {
                RefrescarCampoRol();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        public void RefrescarCampoRol()
        {
            try
            {
                //Se limpian los elementos actuales del combobox "Rol"
                cmb_Rol.Items.Clear();

                //se abre conexion
                conexion.Open();

                //Comando de consulta para extraer los roles de la tabla "ROL" para rellenar el combobox de "Roles"
                SqlCommand cm = new SqlCommand("select*from ROLES", conexion.getConnection());

                //Se crea un objeto sqldatareader para leer los Roles
                SqlDataReader dr = cm.ExecuteReader();

                //se crea un ciclo while para rellenar el combobox de Roles
                while (dr.Read())
                {
                    cmb_Rol.Items.Add(dr.GetString(1));
                }

                //Se cierra la conexion
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
            //Se cierra la ventana/formulario actual
            this.Close();
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtbox_Contra.Text == "" || txtbox_Correo.Text == "" || txtbox_IdUsuario.Text == "" || txtbox_NombreUsuario.Text == "" || txtbox_ReingresoContra.Text == "" || cmb_Rol.Text == "")
                {
                    MessageBox.Show("Favor de no dejar campos en blanco");
                }
                else
                {
                    //Creacion de la variable para capturar el ID del rol seleccionado
                    int rolSeleccionado = 0;

                    //Se abre conexion
                    conexion.Open();

                    //Proceso para capturar la ID correspondiente al elemento seleccionado
                    //Se crea un comando para seleccionar el elemento que coincida con el nombre del rol seleccionado
                    SqlCommand cm = new SqlCommand("Select*from ROLES where Nombre = '" + cmb_Rol.Text + "'", conexion.getConnection());
                    //Se crea un sqldatareader
                    SqlDataReader dr = cm.ExecuteReader();

                    //Se captura la id en una variable declarada anteriormente
                    if (dr.Read() == true)
                    {
                        rolSeleccionado = int.Parse(dr["ID_Rol"].ToString());
                    }
                    conexion.Close();


                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un nombre igual al recien ingresado
                    string query = "SELECT COUNT(*) FROM USUARIO WHERE Nombre = @nombre";
                    SqlCommand command = new SqlCommand(query, conexion.getConnection());
                    command.Parameters.AddWithValue("@nombre", txtbox_NombreUsuario.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count = (int)command.ExecuteScalar();

                    conexion.Close();

                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un ID igual al recien ingresado
                    string query2 = "SELECT COUNT(*) FROM USUARIO WHERE ID_Usuario = @id";
                    SqlCommand command2 = new SqlCommand(query2, conexion.getConnection());
                    command2.Parameters.AddWithValue("@id", txtbox_IdUsuario.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count2 = (int)command2.ExecuteScalar();

                    conexion.Close();

                    //Se realiza una comparacion sencilla para verificar que la contraseña y su reingreso sean correctas para proceder con la insercion
                    if (txtbox_Contra.Text == txtbox_ReingresoContra.Text)
                    {

                        //Se evalua la existencia del dato, si no existe se inserta normalmente, si si existe se solicita que se cambie de nombre
                        if (count == 0 && count2 == 0)
                        {
                            conexion.Open();

                            //Se crea un string que contenga todo el comando de insercion a la base de datos
                            string insercion = "INSERT INTO USUARIO (ID_Usuario,Nombre,Contrasena,Rol,Correo,Visibilidad)\r\nVALUES ( " +
                                txtbox_IdUsuario.Text + ",'" + txtbox_NombreUsuario.Text + "','" + txtbox_Contra.Text + "'," + rolSeleccionado + ",'" +
                                txtbox_Correo.Text + "', 1)";

                            //se crea un sql command para insertar los datos
                            SqlCommand comandoInsercion = new SqlCommand(insercion, conexion.getConnection());

                            //Ejecucion del comando
                            comandoInsercion.ExecuteNonQuery();

                            //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                            MessageBox.Show("Registro agregado exitosamente");

                            conexion.Close();

                            Principal_forms principal_Forms = new Principal_forms();
                            principal_Forms.ObtenerRegistrosUsuarios();
                            

                            limpiarcampos();
                        }

                        else
                        {
                            MessageBox.Show("Ya existe un usuario con ese nombre o ID, favor de ingresar otro");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La contraseña ingresada y su reingreso no coinciden, favor de revisar");
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

        public void limpiarcampos()
        {
            txtbox_IdUsuario.Clear();
            txtbox_NombreUsuario.Clear();
            txtbox_Contra.Clear();
            txtbox_ReingresoContra.Clear();
            txtbox_Correo.Clear();
            cmb_Rol.SelectedIndex = -1;
        }

        private void txtbox_IdUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void CrearUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
