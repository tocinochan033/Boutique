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
            
            db = new databaseConnection();
            dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Now;

            //Cargar Filtros
            CargarCategorias();
        }
       
        private void CargarCategorias()
        {
            try
            {
                db.Open();
                {
                    SqlCommand cmd = new SqlCommand("SELECT ID_Categoria, Nombre FROM CATEGORIA WHERE Visibilidad = 1", db.getConnection());
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbCategorias.Items.Clear();
                    
                    while (reader.Read())
                    {
                        cbCategorias.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)));
                    }

                    cbCategorias.DisplayMember = "Value";
                    cbCategorias.ValueMember = "Key";
                    cbCategorias.SelectedIndex = 0;
                }
                db.Close();
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
            if (string.IsNullOrEmpty("Data Source=EDUARDO\\SQLEXPRESS; Initial Catalog= BOUTIQUE; Integrated Security=True"))
            {
                MessageBox.Show("Error: No se ha configurado la conexión a la base de datos.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            //REPORTE CONTEO
            // Obtener datos de los controles del formulario
            DateTime fechaDesde = dtpFechaDesde.Value;
            DateTime fechaHasta = dtpFechaHasta.Value;
            int? idCategoria = cbCategorias.SelectedIndex > -1 ? (int?)cbCategorias.SelectedValue : null;
            // Obtener datos de la base de datos
            DataTable datosStock = ObtenerDatosStock(fechaDesde, fechaHasta, idCategoria);

            var html = new StringBuilder();
            // Encabezado HTML
            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<head>");
            html.AppendLine("  <title>Reporte de Stock</title>");
            html.AppendLine("  <style>");
            html.AppendLine("    table { width: 50%; border: 4px solid black; border-collapse: collapse; table-layout: fixed; }");
            html.AppendLine("    td, th { border: 2px solid black; height: 30px; padding-left: 8px; padding-right: 8px; }");
            html.AppendLine("  </style>");
            html.AppendLine("</head>");
            html.AppendLine("<body style='text-align: center;'>");
            // Título del reporte
            html.AppendLine("  <h1>REPORTE DE STOCK</h1>");
            // Información del reporte
            html.AppendLine("  <table>");
            html.AppendLine("    <tr style='text-align: center;'>");
            html.AppendLine("        <th rowspan='2'>LOGO</th>");
            html.AppendLine($"       <td rowspan='2' width='500px'><h2>Stock de Mercancía</h2></td>");
            html.AppendLine("        <td>Páginas: 1 de 1</td>");
            html.AppendLine("        <td>Reporte No. 1</td>");
            html.AppendLine("    </tr>");
            html.AppendLine("    <tr style='text-align: center;'>");
            html.AppendLine($"       <td colspan='2'>Fecha de Expedición: {DateTime.Now:dd/MM/yyyy}</td>");
            html.AppendLine("    </tr>");
            html.AppendLine("  </table>");
            // Datos generales
            html.AppendLine("  <h3>Datos Generales</h3>");
            html.AppendLine("  <table>");
            html.AppendLine("    <tr>");
            html.AppendLine("        <td colspan='2'>Usuario generador: [NombreUsuario]</td>");
            html.AppendLine($"       <td style='width: 400px'>Categoría: {(idCategoria.HasValue ? cbCategorias.Text : "Todas")}</td>");
            html.AppendLine("    </tr>");
            html.AppendLine("    <tr>");
            html.AppendLine($"       <td colspan='2'>Período: {fechaDesde:dd/MM/yyyy} a {fechaHasta:dd/MM/yyyy}</td>");
            html.AppendLine($"       <td>Hora de generación: {DateTime.Now:hh:mm:ss tt}</td>");
            html.AppendLine("    </tr>");
            html.AppendLine("  </table>");
            // Datos del inventario
            html.AppendLine("  <h3>Datos del Inventario</h3>");
            html.AppendLine("  <table>");
            html.AppendLine("    <tr>");
            html.AppendLine("        <th width='50px'>ID</th>");
            html.AppendLine("        <th>Producto</th>");
            html.AppendLine("        <th>Cantidad inicial</th>");
            html.AppendLine("        <th>Cantidad actual</th>");
            html.AppendLine("        <th width='150px'>Variación</th>");
            html.AppendLine("    </tr>");
            foreach (DataRow row in datosStock.Rows)
            {
                html.AppendLine("    <tr>");
                html.AppendLine($"       <td style='text-align:center'>{row["ID_Producto"]}</td>");
                html.AppendLine($"       <td>{row["Nombre"]}</td>");
                html.AppendLine($"       <td style='text-align: right;'>{row["CantidadInicial"]}</td>");
                html.AppendLine($"       <td style='text-align: right;'>{row["CantidadActual"]}</td>");
                html.AppendLine($"       <td style='text-align: right;'>{row["Variacion"]}</td>");
                html.AppendLine("    </tr>");
            }

            html.AppendLine("  </table>");
            // Firmas
            html.AppendLine("  <h3>Validación</h3>");
            html.AppendLine("  <br>");
            html.AppendLine("  <table style='text-align: center; border-color: white;'>");
            html.AppendLine("    <tr style='height: 150px;'>");
            html.AppendLine("        <td style='border-color: white;'></td>");
            html.AppendLine("        <td style='border-color: white;'></td>");
            html.AppendLine("    </tr>");
            html.AppendLine("    <tr>");
            html.AppendLine("        <td style='height: 2px; border-color: white;'>_____________________________________</td>");
            html.AppendLine("        <td style='height: 2px; border-color: white;'>_____________________________________</td>");
            html.AppendLine("    </tr>");
            html.AppendLine("    <tr>");
            html.AppendLine("        <td style='border-color: white;'>Firma del Responsable</td>");
            html.AppendLine("        <td style='border-color: white;'>Sello de Validación</td>");
            html.AppendLine("    </tr>");
            html.AppendLine("  </table>");

            html.AppendLine("</body>");
            html.AppendLine("</html>");
            return html.ToString();
        }
        private DataTable ObtenerDatosStock(DateTime fechaDesde, DateTime fechaHasta, int? idCategoria)
        {
            DataTable table = new DataTable();
            try
            {
                using (db.getConnection())
                {
                    string query = @"SELECT p.ID_Producto, p.Nombre, 
                            ISNULL((SELECT SUM(Cantidad) FROM MOVIMIENTOS_STOCK 
                                   WHERE ID_Producto = p.ID_Producto AND Fecha < @FechaDesde), 0) as CantidadInicial,
                            ISNULL((SELECT SUM(Cantidad) FROM MOVIMIENTOS_STOCK 
                                   WHERE ID_Producto = p.ID_Producto AND Fecha BETWEEN @FechaDesde AND @FechaHasta), 0) as CantidadActual,
                            ISNULL((SELECT SUM(Cantidad) FROM MOVIMIENTOS_STOCK 
                                   WHERE ID_Producto = p.ID_Producto AND Fecha BETWEEN @FechaDesde AND @FechaHasta), 0) as Variacion
                            FROM PRODUCTOS p
                            WHERE (@ID_Categoria IS NULL OR p.ID_Categoria = @ID_Categoria)";

                    var adapter = new SqlDataAdapter(query, db.getConnection());
                    adapter.SelectCommand.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    adapter.SelectCommand.Parameters.AddWithValue("@FechaHasta", fechaHasta);
                    adapter.SelectCommand.Parameters.AddWithValue("@ID_Categoria", idCategoria ?? (object)DBNull.Value);

                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de stock: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }
    }
}
