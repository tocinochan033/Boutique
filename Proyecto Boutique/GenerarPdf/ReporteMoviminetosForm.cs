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

namespace Proyecto_Boutique.Forms.GenerarPDF
{
    public partial class ReporteMoviminetosForm : Form
    {
        private string connectionString = "Data Source= MARTIN\\SQLEXPRESS; Initial Catalog= BOUTIQUE; Integrated Security=True";
        public ReporteMoviminetosForm()
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
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT ID_Tipo, Nombre FROM TIPOMOVIMIENTO";

                using (var command = new SqlCommand(query, connection))
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
                var html = GenerateMovimientosReportHtml();
                PDFGenerador.ShowSaveDialogAndGenerate(html, $"Reporte_Movimientos_{DateTime.Now:yyyyMMdd}.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateMovimientosReportHtml()
        {
            var html = new StringBuilder();
            // Agregar reporte
           
                return html.ToString();
            }
        }
    }
