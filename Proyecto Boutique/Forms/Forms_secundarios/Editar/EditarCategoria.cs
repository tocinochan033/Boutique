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
    public partial class EditarCategoria : Form
    {
        public EditarCategoria()
        {
            InitializeComponent();
        }

        private void EditarCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Principal_forms forms = new Principal_forms();
            forms.Show();
        }
    }
}
