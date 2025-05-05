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
            
        }

        private void GenerarPDFDesdeHTML(string nombreArchivo, string htmlContent)
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                    ColorMode = ColorMode.Color,
                    Orientation = DinkToPdf.Orientation.Portrait,
                    PaperSize = PaperKind.A4
                },
                Objects =
                {
                    new ObjectSettings()
                    {
                        HtmlContent = htmlContent,
                        WebSettings = {DefaultEncoding="utf-8"}
                    }
                }

            };
            var pdf=_converter.Convert(doc);
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nombreArchivo + ".pdf");
            File.WriteAllBytes(ruta, pdf);
            MessageBox.Show("PDF Generado","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }
    }
}
