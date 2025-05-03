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
            db.open();
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
                db.open();
                string query = "SELECT COUNT(*) FROM USUARIO WHERE Nombre = @usuario AND Contrasena = @contrasena";
                SqlCommand cmd = new SqlCommand(query, db.getConnection());
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    this.Hide();
                    Principal_forms principal = new Principal_forms(); // otro form
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
        }
    }
}
