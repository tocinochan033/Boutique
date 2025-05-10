using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace Proyecto_Boutique
{
    internal class PDFGenerador
    {
        public static void GeneratePdfFromHtml(string html, string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                using (StringReader sr = new StringReader(html))
                {
                    HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                    htmlparser.Parse(sr);
                }

                pdfDoc.Close();
                stream.Close();
            }
        }
        public static void ShowSaveDialogAndGenerate(string html, string defaultFileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = defaultFileName
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                GeneratePdfFromHtml(html, saveFileDialog.FileName);
                MessageBox.Show("Reporte generado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

