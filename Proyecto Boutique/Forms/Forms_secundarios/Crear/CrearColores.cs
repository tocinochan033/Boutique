using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Boutique
{
    public partial class CrearColores : Form
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

        public CrearColores()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
            //Se cierra la ventana/formulario actual
            this.Close();
        }

        private void CrearColores_Load(object sender, EventArgs e)
        {
            ObtenerRegistrosColores();
            actualizarID();
        }


        public void actualizarID()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(ID_Color) FROM COLOR", conexion.getConnection());
                object result = cmd.ExecuteScalar();
                int ultimaId;
                int sumultimaID;

                ultimaId = result != DBNull.Value ? Convert.ToInt32(result) : 0;

                if (ultimaId == 0)
                {
                    txtbox_IDColor.Text = 1.ToString();
                }
                else
                {
                    sumultimaID = ultimaId + 1;

                    txtbox_IDColor.Text = sumultimaID.ToString();
                }
                conexion.Close();

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }
        public void ObtenerRegistrosColores()
        {
            try
            {
                conexion.Open();
                //Creacion de consulta para visualizar todos los campos de las respectivas tablas
                String ConsultaColores = "Select * from COLOR";

                //Se utiliza el objeto sqldataadapter creado anteriormente
                adaptador = new SqlDataAdapter(ConsultaColores, conexion.getConnection());

                //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
                DataTable dtCOLORES = new DataTable();

                //Se pasan los datos del datatable al objeto adaptador
                adaptador.Fill(dtCOLORES);

                //Se envian los parametros al datagridview de usuarios
                DataGrid_Colores.DataSource = dtCOLORES;
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un problema inesperado");
            }
        }

        private void btn_EliminarColor_Click(object sender, EventArgs e)
        {
            //Se declara una variable tipo "DialogResult para capturar la resultasta a la ventana de dialogo de confirmacion
            DialogResult dg;

            try
            {
                if (DataGrid_Colores.SelectedRows.Count == 1)
                {
                    dg = MessageBox.Show("Desea eiminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    //Se evalua para saber si se quiere proceder con la operacion, de ser el caso que se seleccione "Aceptar" realiza la eliminacion
                    if (dg == DialogResult.OK)
                    {
                        conexion.Open();

                        int id = Convert.ToInt32(DataGrid_Colores.CurrentRow.Cells["ID_Color"].Value);

                        string query = $"UPDATE COLOR SET Visibilidad = 0 WHERE ID_Color = {id}";
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

                        ObtenerRegistrosColores();
                    }
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

        private void btn_CrearColor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_IDColor.Text == "" || txtbox_NombreColor.Text == "")
                {
                    MessageBox.Show("Favor de no dejar campos en blanco");
                }
                else
                {
                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un nombre igual al recien ingresado
                    string query = "SELECT COUNT(*) FROM COLOR WHERE Nombre = @nombre";
                    SqlCommand command = new SqlCommand(query, conexion.getConnection());
                    command.Parameters.AddWithValue("@nombre", txtbox_NombreColor.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count = (int)command.ExecuteScalar();

                    conexion.Close();

                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un ID igual al recien ingresado
                    string query2 = "SELECT COUNT(*) FROM COLOR WHERE ID_Color = @id";
                    SqlCommand command2 = new SqlCommand(query2, conexion.getConnection());
                    command2.Parameters.AddWithValue("@id", txtbox_IDColor.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count2 = (int)command2.ExecuteScalar();

                    conexion.Close();
                    //Se evalua la existencia del dato, si no existe se inserta normalmente, si si existe se solicita que se cambie de nombre
                    if (count == 0 && count2 == 0)
                    {
                        conexion.Open();

                        //Se crea un string que contenga todo el comando de insercion a la base de datos
                        string insercion = $"INSERT INTO COLOR (Nombre,Visibilidad) VALUES('{txtbox_NombreColor.Text}',1)";

                        //se crea un sql command para insertar los datos
                        SqlCommand comandoInsercion = new SqlCommand(insercion, conexion.getConnection());

                        //Ejecucion del comando
                        comandoInsercion.ExecuteNonQuery();

                        //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                        MessageBox.Show("Color agregado exitosamente");

                        conexion.Close();

                        limpiarcampos();
                        ObtenerRegistrosColores();
                        actualizarID();
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
            txtbox_IDColor.Text = "";
            txtbox_NombreColor.Text = "";
        }

        private void txtbox_IDColor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CrearColores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
        }
    }
}
