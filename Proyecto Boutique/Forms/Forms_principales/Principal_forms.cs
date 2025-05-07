using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DinkToPdf;
using DinkToPdf.Contracts;

namespace Proyecto_Boutique
{
    public partial class Principal_forms : Form
    {
        private readonly IConverter _converter;
        public Principal_forms()
        {
            InitializeComponent();  
            _converter = new SynchronizedConverter(new PdfTools());
        }

        private void lbl_Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btn_RepStock_Click(object sender, EventArgs e)
        {
            using (var form = new ReporteStockForm())
            {
                form.ShowDialog();
            }
        }

        private void btn_RepMovimientos_Click(object sender, EventArgs e)
        {
            using (var form = new ReporteMovimientosForm())
            {
                form.ShowDialog();
            }
        }

        private void btn_RepAuditoria_Click(object sender, EventArgs e)
        {
            using (var form = new ReporteAuditoriaForm())
            {
                form.ShowDialog();
            }
        }
    }
}
