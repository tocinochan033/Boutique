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

//Librerias para la gestión de los pdf
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Proyecto_Boutique
{
    public partial class ReporteMovimientosForm : Form
    {
        databaseConnection db = new databaseConnection();

        public ReporteMovimientosForm()
        {
            InitializeComponent();

            // Configuración inicial
            dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Now;

            // Puedes cargar comboboxes si necesitas filtros adicionales
            CargarFiltrosAdicionales();

        }

        private void CargarFiltrosAdicionales()
        {
            using (db.getConnection())
            {
                db.Open();
                var query = "SELECT ID_Tipo, Nombre FROM TIPOMOVIMIENTO";

                using (var command = new SqlCommand(query, db.getConnection()))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbTipoMovimiento.Items.Add(new
                        {
                            Id = reader["ID_Tipo"],
                            Name = reader["Nombre"]
                        });
                    }
                }
            }
            cmbTipoMovimiento.DisplayMember = "Name";
            cmbTipoMovimiento.ValueMember = "Id";
        }

        private void Generar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                //Proceso para guardar los pdf
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = DateTime.Now.ToString("ddmmyyyy") + ".pdf"; // Nombre por defecto con el que se guarda
               

                //Estructura html
                string Pagina_HTML_texto = "<h1>HOLA MUNDO</h1>";

                //Condicional para el guardado
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    //Guardado en memoria
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        //Caracteristicas del formato del pdf
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();

                        pdfDoc.Add(new Phrase(""));

                        using(StringReader sr = new StringReader(Pagina_HTML_texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

