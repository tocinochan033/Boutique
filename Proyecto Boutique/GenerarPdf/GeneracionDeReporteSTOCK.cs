using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Boutique.GenerarPdf
{
    public partial class GeneracionDeReporteSTOCK : Form
    {
        public GeneracionDeReporteSTOCK()
        {
            InitializeComponent();
        }

        private void GeneracionDeReporteSTOCK_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
