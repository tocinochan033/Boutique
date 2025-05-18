using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Boutique
{
    public partial class Recuperar_Contrasena : Form
    {
        public Recuperar_Contrasena()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            var user = new NRecuperarPassword();
            var result = user.recoverPassword(txtUsuario.Text);
            lblResult.Text = result;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Inicio_Sesion inicio = new Inicio_Sesion();
            inicio.Show();
            this.Hide();
        }
    }
}
