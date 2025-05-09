using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.Collections;

namespace Proyecto_Boutique.Forms.GenerarPDF
{
    public partial class ReporteStockForm : Form
    {
        private string connectionString = "Data Source= MARTIN\\SQLEXPRESS; Initial Catalog= BOUTIQUE; Integrated Security=True";
        public ReporteStockForm()
        {
            InitializeComponent();
            dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Now;

            //Cargar Filtros
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var query = "SELECT ID_Categoria, Nombre FROM CATEGORIA WHERE Visibilidad = 1";
                    var adapter = new SqlDataAdapter(query, connection);
                    var table = new DataTable();

                    adapter.Fill(table);

                    cbCategorias.DataSource = table;
                    cbCategorias.DisplayMember = "Nombre";
                    cbCategorias.ValueMember = "ID_Categoria";
                    cbCategorias.SelectedIndex = -1; // Ninguna selección por defecto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar categorías: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReporteStockForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var html = GenerarHtmlReporte();
                PDFGenerador.ShowSaveDialogAndGenerate(html, $"Reporte_Stock_{DateTime.Now:yyyyMMdd}.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerarHtmlReporte()
        {
            var html = new StringBuilder();

            //REPORTE
            //DATOS DEL REPORTE
            
            return html.ToString();
        }
    }
}
