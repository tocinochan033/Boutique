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

namespace Proyecto_Boutique.Mostrar_Detalles
{
    public partial class MostrarDetallesUsuarios : Form
    {

        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion = new databaseConnection();

        public MostrarDetallesUsuarios(int id, string nombre, string contrasena, int rol, string correo)
        {
            InitializeComponent();

            try
            {
                RefrescarCampoRol();

                txtbox_NombreUsuario.Text = nombre;
                txtbox_IdUsuario.Text = id.ToString();
                txtbox_Correo.Text = correo;
                txtbox_Contra.Text = contrasena;
                cmb_Rol.SelectedIndex = rol - 1;
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
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
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }


    }
}
