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
    public partial class ReporteAuditoriaForms : Form
    {
        databaseConnection db = new databaseConnection();
        public ReporteAuditoriaForms()
        {
            InitializeComponent();

            // Configuración específica para auditoría
            dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Now;
        }
        private void ReporteAuditoriaForms_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarAuditores();
        }
        
        private void CargarCategorias()
        {
            try
            {
                db.Open();
                {
                    SqlCommand cmd = new SqlCommand("SELECT ID_Categoria, Nombre FROM CATEGORIA WHERE Visibilidad = 1", db.getConnection());
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbCategoria.Items.Clear();
                    
                    while (reader.Read())
                    {
                        cmbCategoria.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)));
                    }

                    cmbCategoria.DisplayMember = "Value";
                    cmbCategoria.ValueMember = "Key";
                    cmbCategoria.SelectedIndex = 0;
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarAuditores()
        {
            try
            {
               db.Open ();
                {                   
                    SqlCommand cmd = new SqlCommand("SELECT ID_Usuario, Nombre FROM USUARIO WHERE Visibilidad = 1 AND Rol = 1", db.getConnection()); // Rol 1 = Administrador
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbAuditor.Items.Clear();
                    while (reader.Read())
                    {
                        cmbAuditor.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)));
                    }
                    cmbAuditor.DisplayMember = "Value";
                    cmbAuditor.ValueMember = "Key";
                    if (cmbAuditor.Items.Count > 0)
                    {
                        cmbAuditor.SelectedIndex = 0;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void generar_btn_Click(object sender, EventArgs e)
        {
            // Obtener parámetros del formulario
            DateTime fechaInicio = dtpFechaDesde.Value;
            DateTime fechaFin = dtpFechaHasta.Value;
            string auditor = cmbAuditor.Text;
            int? idCategoria = null;
            if (cmbCategoria.SelectedIndex > 0)
            {
                idCategoria = ((KeyValuePair<int, string>)cmbCategoria.SelectedItem).Key;
            }
            // Obtener datos de la base de datos
            DataTable datosAuditoria = ObtenerDatosAuditoria(fechaInicio, fechaFin, idCategoria);

            // Generar HTML
            string html = GenerarHtmlReporteAuditoria(datosAuditoria, fechaInicio, fechaFin, auditor, idCategoria);

            // Guardar diálogo para PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"Reporte_Auditoria_{DateTime.Now:yyyyMMdd}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                PDFGenerador.GeneratePdfFromHtml(html, saveFileDialog.FileName);
            }
        }

        private DataTable ObtenerDatosAuditoria(DateTime fechaInicio, DateTime fechaFin, int? idCategoria)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Factor");
            dt.Columns.Add("Cantidad", typeof(int));
            try
            {
                db.Open();
                {
                    // Total en sistema
                    int totalEnSistema = ObtenerTotalEnSistema(idCategoria);
                    dt.Rows.Add("Total en sistema", totalEnSistema);

                    // Entradas
                    dt.Rows.Add("Entrada - Total", 0);

                    // Entradas individuales
                    string[] causasEntrada = { "Recibida (Proveedor)", "Recibida (Otra Sucursal)", "Recibida (Mercancia Re-Integrada)" };
                    foreach (string causa in causasEntrada)
                    {
                        int cantidad = ObtenerCantidadMovimientos(fechaInicio, fechaFin, idCategoria, causa);
                        dt.Rows.Add("Entrada - " + causa, cantidad);
                        dt.Rows[1]["Cantidad"] = (int)dt.Rows[1]["Cantidad"] + cantidad; // Sumar al total de entradas
                    }
                    // Salidas
                    dt.Rows.Add("Salida - Total", 0);

                    // Salidas individuales
                    string[] causasSalida = {
                    "Salida (Venta)", "Salida (Envio a otra sucursal)", "Salida (Robada)",
                    "Salida (Mercancia dañada)", "Devuelta al proveedor (Sobre Stock)",
                    "Devuelta al proveedor (Temporada)", "Devuelta al proveedor (Descontinuada)"
                    };
                    foreach (string causa in causasSalida)
                    {
                        int cantidad = ObtenerCantidadMovimientos(fechaInicio, fechaFin, idCategoria, causa);
                        dt.Rows.Add("Salida - " + causa, cantidad);
                        dt.Rows[dt.Rows.Count - causasSalida.Length - 2]["Cantidad"] =
                            (int)dt.Rows[dt.Rows.Count - causasSalida.Length - 2]["Cantidad"] + cantidad; // Sumar al total de salidas
                    }
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de auditoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        private int ObtenerTotalEnSistema(int? idCategoria)
        {
            int total = 0;
            try
            {
                db.Open();
                {
                    string query = "SELECT SUM(Cantidad) FROM PRODUCTOS WHERE Visibilidad = 1";

                    if (idCategoria.HasValue)
                    {
                        query += " AND Categoria = @IdCategoria";
                    }
                    SqlCommand cmd = new SqlCommand(query, db.getConnection());

                    if (idCategoria.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria.Value);
                    }

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        total = Convert.ToInt32(result);
                    }

                }
                db.Close ();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener total en sistema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return total;
        }
        private int ObtenerCantidadMovimientos(DateTime fechaInicio, DateTime fechaFin, int? idCategoria, string causa)
        {
            int cantidad = 0;
            try
            {
                db.Open();
                {
                    string query = @"
                    SELECT ISNULL(SUM(m.Cantidad), 0)
                    FROM MOVIMIENTOS m
                    JOIN PRODUCTOS p ON m.Producto = p.ID_Producto
                    JOIN CAUSA c ON m.Causa = c.ID_Causa
                    WHERE m.Fecha BETWEEN @FechaInicio AND @FechaFin
                    AND c.Causa = @Causa";

                    if (idCategoria.HasValue)
                    {
                        query += " AND p.Categoria = @IdCategoria";
                    }
                    SqlCommand cmd = new SqlCommand(query, db.getConnection());
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin.AddDays(1)); // Para incluir todo el día final
                    cmd.Parameters.AddWithValue("@Causa", causa);

                    if (idCategoria.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@IdCategoria", idCategoria.Value);
                    }

                    cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener cantidad de movimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cantidad;
        }
        //PARTE HTML
        private string GenerarHtmlReporteAuditoria(DataTable datosAuditoria, DateTime fechaInicio, DateTime fechaFin, string auditor, int? idCategoria)
        {
            // Obtener el nombre de la categoría
            string nombreCategoria="";
            if (idCategoria.HasValue && cmbCategoria.SelectedIndex > 0)
            {
                nombreCategoria = ((KeyValuePair<int, string>)cmbCategoria.SelectedItem).Value;
            }
            // Calcular porcentajes (simplificado)
            int totalEnSistema = Convert.ToInt32(datosAuditoria.Rows[0]["Cantidad"]);
            int totalEntradas = Convert.ToInt32(datosAuditoria.Rows[1]["Cantidad"]);
            int totalSalidas = Convert.ToInt32(datosAuditoria.Rows[datosAuditoria.Rows.Count-9]["Cantidad"]);

            double porcentajeGanancias = totalEnSistema > 0 ? (totalEntradas * 100.0 / totalEnSistema) : 0;
            double porcentajePerdidas = totalEnSistema > 0 ? (totalSalidas * 100.0 / totalEnSistema) : 0;
            
            // Construir el HTML basado en tu plantilla
            StringBuilder html = new StringBuilder();
            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<head>");
            html.AppendLine("<title>Reporte de Auditoria</title>");
            html.AppendLine("<style>");
            html.AppendLine("table { width: 50%; border: 4px solid black; border-collapse: collapse; table-layout: fixed; }");
            html.AppendLine("td, th { border: 2px solid black; height: 30px; padding-left: 8px; padding-right: 8px; }");
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body style='text-align: center;'>");

            // Encabezado principal
            html.AppendLine("<h1>AUDITORÍA DE INVENTARIO</h1>");
            html.AppendLine("<table>");
            html.AppendLine("<tr style='text-align: center;'>");
            html.AppendLine("<th rowspan='2'>LOGO</th>");
            html.AppendLine("<td rowspan='2' width='500px'><h2>Entrada y Salida de Mercancia</h2></td>");
            html.AppendLine("<td>Páginas : 1 de 1</td>");
            html.AppendLine("<td>Auditoría No. 1</td>");
            html.AppendLine("</tr>");
            html.AppendLine("<tr style='text-align: center;'>");
            html.AppendLine($"<td colspan='2'>Fecha de Expedición: {DateTime.Now:dd / MM / yyyy}</td>");
            html.AppendLine("</tr>");
            html.AppendLine("</table>");

            // Datos generales
            html.AppendLine("<h3>Datos Generales</h3>");
            html.AppendLine("<table>");
            html.AppendLine("<tr>");
            html.AppendLine($"<td>Auditor: {auditor}</td>");
            html.AppendLine($"<td colspan='2'>Categoría de la mercancia auditada: {nombreCategoria}</td>");
            html.AppendLine("</tr>");
            html.AppendLine("<tr>");
            html.AppendLine($"<td colspan='2'>Periodo de Evaluación: {fechaInicio:dd / MM / yyyy} a {fechaFin:dd / MM / yyyy}</td>");
            html.AppendLine($"       <td>Hora de generación: {DateTime.Now:hh:mm:ss tt}</td>");
            html.AppendLine("</tr>");
            html.AppendLine("</table>");

            // Datos del inventario
            html.AppendLine("<h3>Datos del Inventario</h3>");
            html.AppendLine("<table>");
            html.AppendLine("<tr>");
            html.AppendLine("<th width='50px'>Folio.</th>");
            html.AppendLine("<th>Factores a Evaluar</th>");
            html.AppendLine("<th width='150px'>Unidades:</th>");
            html.AppendLine("</tr>");

            // Total en sistema
            html.AppendLine("<tr style='border: 4px solid black'>");
            html.AppendLine($"<td colspan='3' style='text-align: center'>Total de mercancia (respecto a la categoría) actual en sistema: {totalEnSistema}</td>");
            html.AppendLine("</tr>");

            // Entradas
            html.AppendLine("<tr style='border: 4px solid black'>");
            html.AppendLine("<td colspan='3'>Entrada :</td>");
            html.AppendLine("</tr>");

            // Filas de entradas
            for (int i = 2; i <= 4; i++)
            {
                html.AppendLine("<tr>");
                html.AppendLine($"<td>{i - 1}</td>");
                html.AppendLine($"<td>{datosAuditoria.Rows[i]["Factor"].ToString().Replace("Entrada - ", "")}</td>");
                html.AppendLine($"<td style='text-align: right;'>{datosAuditoria.Rows[i]["Cantidad"]}</td>");
                html.AppendLine("</tr>");
            }

            // Salidas
            html.AppendLine("<tr style='border: 4px solid black'>");
            html.AppendLine("<td colspan='3'>Salida : </td>");
            html.AppendLine("</tr>");

            // Filas de salidas
            for (int i = 5; i < datosAuditoria.Rows.Count; i++)
            {
                html.AppendLine("<tr>");
                html.AppendLine($"<td>{i - 4}</td>");
                html.AppendLine($"<td>{datosAuditoria.Rows[i]["Factor"].ToString().Replace("Salida - ", "")}</td>");
                html.AppendLine($"<td style='text-align: right;'>{datosAuditoria.Rows[i]["Cantidad"]}</td>");
                html.AppendLine("</tr>");
            }
            html.AppendLine("</table>");
            
            // Resultados
            html.AppendLine("<h3>Resultados</h3>");
            html.AppendLine("<table>");
            html.AppendLine("<tr>");
            html.AppendLine("<th rowspan='3' style='height: 150px;'> GRAFICA </th>");
            html.AppendLine("<th colspan='2' style='width: 400px'> Porcentajes respecto al total en inventario: </th>");
            html.AppendLine("</tr>");
            html.AppendLine("<tr>");
            html.AppendLine("<td>Ganancias</td>");
            html.AppendLine($"<td style='text-align: right;'> {porcentajeGanancias:0.00}% </td>");
            html.AppendLine("</tr>");
            html.AppendLine("<tr>");
            html.AppendLine("<td>Perdidas</td>");
            html.AppendLine($"<td style='text-align: right;'> {porcentajePerdidas:0.00}% </td>");
            html.AppendLine("</tr>");
            html.AppendLine("</table>");

            // Firmas
            html.AppendLine("<br>");
            html.AppendLine("<table style='text-align: center; border-color: white;'>");
            html.AppendLine("<tr style='height: 150px;'>");
            html.AppendLine("<td style='border-color: white;'></td>");
            html.AppendLine("<td style='border-color: white;'></td>");
            html.AppendLine("</tr>");
            html.AppendLine("<tr>");
            html.AppendLine("<td style='height: 2px; border-color: white;'>_____________________________________</td>");
            html.AppendLine("<td style='height: 2px; border-color: white;'>_____________________________________</td>");
            html.AppendLine("</tr>");
            html.AppendLine("<tr>");
            html.AppendLine("<td style='border-color: white;'>Firma del Auditor.</td>");
            html.AppendLine("<td style='border-color: white;'>Sello de Validación.</td>");
            html.AppendLine("</tr>");
            html.AppendLine("</table>");

            html.AppendLine("</body>");
            html.AppendLine("</html>");

            return html.ToString();
        }
    }
}
