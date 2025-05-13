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

namespace Proyecto_Boutique.Forms.Forms_secundarios.Crear
{
    public partial class CrearCausa : Form
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

        public CrearCausa()
        {
            InitializeComponent();
        }

        private void CrearCausa_Load(object sender, EventArgs e)
        {
            ObtenerRegistrosCausas();
        }

        public void ObtenerRegistrosCausas()
        {
            try
            {
                conexion.Open();
                //Creacion de consulta para visualizar todos los campos de las respectivas tablas
                String ConsultaCausas = "Select * from CAUSA";

                //Se utiliza el objeto sqldataadapter creado anteriormente
                adaptador = new SqlDataAdapter(ConsultaCausas, conexion.getConnection());

                //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
                DataTable dtCAUSA = new DataTable();

                //Se pasan los datos del datatable al objeto adaptador
                adaptador.Fill(dtCAUSA);

                //Se envian los parametros al datagridview de usuarios
                DataGrid_Causas.DataSource = dtCAUSA;
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

        private void btn_EliminarCausa_Click(object sender, EventArgs e)
        {
            //Se declara una variable tipo "DialogResult para capturar la resultasta a la ventana de dialogo de confirmacion
            DialogResult dg;

            try
            {
                if (DataGrid_Causas.SelectedRows.Count == 1)
                {
                    dg = MessageBox.Show("Desea eiminar el elemento seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    //Se evalua para saber si se quiere proceder con la operacion, de ser el caso que se seleccione "Aceptar" realiza la eliminacion
                    if (dg == DialogResult.OK)
                    {
                        conexion.Open();

                        int id = Convert.ToInt32(DataGrid_Causas.CurrentRow.Cells["ID_Causa"].Value);

                        string query = $"UPDATE CAUSA SET Visibilidad = 0 WHERE ID_Causa = {id}";
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

                        ObtenerRegistrosCausas();
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

        private void btn_CrearCausa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_IDCausa.Text == "" || txtbox_NombreCausa.Text == "")
                {
                    MessageBox.Show("Favor de no dejar campos en blanco");
                }
                else
                {
                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un nombre igual al recien ingresado
                    string query = "SELECT COUNT(*) FROM CAUSA WHERE Causa = @nombre";
                    SqlCommand command = new SqlCommand(query, conexion.getConnection());
                    command.Parameters.AddWithValue("@nombre", txtbox_NombreCausa.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count = (int)command.ExecuteScalar();

                    conexion.Close();

                    conexion.Open();
                    // Consulta SQL para verificar si existe un usuario con un ID igual al recien ingresado
                    string query2 = "SELECT COUNT(*) FROM CAUSA WHERE ID_Causa = @id";
                    SqlCommand command2 = new SqlCommand(query2, conexion.getConnection());
                    command2.Parameters.AddWithValue("@id", txtbox_IDCausa.Text);

                    //Ejecutar la consulta y guardar la variable resultante en una variable entera
                    int count2 = (int)command2.ExecuteScalar();

                    conexion.Close();
                    //Se evalua la existencia del dato, si no existe se inserta normalmente, si si existe se solicita que se cambie de nombre
                    if (count == 0 && count2 == 0)
                    {
                        conexion.Open();

                        //Se crea un string que contenga todo el comando de insercion a la base de datos
                        string insercion = $"INSERT INTO CAUSA (ID_Causa,Causa,Visibilidad) VALUES({txtbox_IDCausa.Text},'{txtbox_NombreCausa.Text}',1)";

                        //se crea un sql command para insertar los datos
                        SqlCommand comandoInsercion = new SqlCommand(insercion, conexion.getConnection());

                        //Ejecucion del comando
                        comandoInsercion.ExecuteNonQuery();

                        //Salta un mensaje que indique que se han insertado los registros satisfactoriamente
                        MessageBox.Show("Causa agregada exitosamente");

                        conexion.Close();

                        limpiarcampos();
                        ObtenerRegistrosCausas();
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
            txtbox_NombreCausa.Text = "";
            txtbox_IDCausa.Text = "";
        }

        private void txtbox_IDCausa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CrearCausa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
        }
    }
}
