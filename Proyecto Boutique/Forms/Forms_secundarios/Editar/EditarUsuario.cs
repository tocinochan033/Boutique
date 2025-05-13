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

namespace Proyecto_Boutique
{
    public partial class EditarUsuario : Form
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

        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                //Se hace para que el textbox de la ID no pueda ser modificado y causar problemas
                txtbox_IdUsuario.ReadOnly = true;
                ObtenerRegistrosUsuarios();
                RefrescarCampoRol();
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

        private void DataGrid_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGrid_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_IdUsuario.Text = DataGrid_Usuarios.CurrentRow.Cells[0].Value.ToString();
                txtbox_NombreUsuario.Text = DataGrid_Usuarios.CurrentRow.Cells[1].Value.ToString();
                txtbox_NuevaContra.Text = DataGrid_Usuarios.CurrentRow.Cells[2].Value.ToString();
                txtbox_ReingresoNuevaContra.Text = DataGrid_Usuarios.CurrentRow.Cells[2].Value.ToString();
                cmb_Rol.SelectedIndex = int.Parse(DataGrid_Usuarios.CurrentRow.Cells[3].Value.ToString()) - 1;
                txtbox_Correo.Text = DataGrid_Usuarios.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        private void cmb_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btn_EditarUsuario_Click(object sender, EventArgs e)
        {

            try
            {
                //Creacion de la variable para capturar el ID del rol seleccionado
                int rolSeleccionado = 0;

                if (txtbox_NuevaContra.Text == "" || txtbox_Correo.Text == "" || txtbox_IdUsuario.Text == "" || txtbox_NombreUsuario.Text == "" || txtbox_ReingresoNuevaContra.Text == "" || cmb_Rol.Text == "")
                {
                    MessageBox.Show("Favor de no dejar campos en blanco");
                }
                else {
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

                    //Se realiza una comparacion sencilla para verificar que la contraseña y su reingreso sean correctas para proceder con la insercion
                    if (txtbox_NuevaContra.Text == txtbox_ReingresoNuevaContra.Text)
                    {
                        conexion.Open();

                        //Se crea un string que contenga todo el comando de insercion a la base de datos
                        string modificacion = $"UPDATE USUARIO SET Nombre = '{txtbox_NombreUsuario.Text}',Contrasena = '{txtbox_NuevaContra.Text}',Rol = " +
                            $"{rolSeleccionado},Correo = '{txtbox_Correo.Text}' WHERE ID_Usuario = {txtbox_IdUsuario.Text}";

                        //se crea un sql command para insertar los datos
                        SqlCommand comandoModificacion = new SqlCommand(modificacion, conexion.getConnection());

                        //Ejecucion del comando
                        comandoModificacion.ExecuteNonQuery();

                        //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                        MessageBox.Show("Registro modificado exitosamente");

                        conexion.Close();

                        limpiarcampos();

                    }
                    else
                    {
                        MessageBox.Show("La contraseña ingresada y su reingreso no coinciden, favor de revisar");
                    }
                    ObtenerRegistrosUsuarios();
                }
            }
            catch
            {
                MessageBox.Show("Ah ocurrido un error inesperado");
            }
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
            txtbox_IdUsuario.Clear();
            txtbox_NombreUsuario.Clear();
            txtbox_NuevaContra.Clear();
            txtbox_ReingresoNuevaContra.Clear();
            txtbox_Correo.Clear();
            cmb_Rol.SelectedIndex = -1;
        }

        private void EditarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
        }
    }
}
