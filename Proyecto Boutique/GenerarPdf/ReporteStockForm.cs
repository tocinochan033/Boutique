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
    public partial class ReporteStockForm : Form
    {
        databaseConnection db = new databaseConnection();
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
                using (db.getConnection())
                {
                    var query = "SELECT ID_Categoria, Nombre FROM CATEGORIA WHERE Visibilidad = 1";
                    var adapter = new SqlDataAdapter(query, db.getConnection());
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

        private void btnGenerar_Click_Click(object sender, EventArgs e)
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
