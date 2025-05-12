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
    public partial class Inicio_Sesion : Form
    {
        databaseConnection db = new databaseConnection();
        public Inicio_Sesion()
        {
            InitializeComponent();
            db.Open();
        }

        //Metodo para impedir que se pueda pegar texto en los campos
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.V))
            {
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string contrasena = txt_Contra.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor, ingresa usuario y contraseña.");
                return;
            }

            try
            {
                db.Open();

                string query = "SELECT ROL FROM USUARIO WHERE Nombre = @usuario AND Contrasena = @contrasena";
                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int idRol = Convert.ToInt32(result); // Aquí obtenemos el ID del rol (1 o 2)
                    SessionData.RolId = idRol;

                    MessageBox.Show("Inicio de sesión exitoso. Rol ID: " + idRol);

                    this.Hide();
                    Principal_forms principal = new Principal_forms();
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }

                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            Recuperar_Contrasena recuperar = new Recuperar_Contrasena();
            recuperar.Show();
            this.Hide();
        }

        private bool showPassword = false;

        private void visiblePassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                txt_Contra.PasswordChar = '\0'; // Muestra la contraseña
                visiblePassword.Image = Properties.Resources.ojo; // Cambia la imagen a ojo abierto
            }
            else
            {
                txt_Contra.PasswordChar = '*';
                visiblePassword.Image = Properties.Resources.hide; // Cambia la imagen a ojo cerrado
            }
        }
    }
}
