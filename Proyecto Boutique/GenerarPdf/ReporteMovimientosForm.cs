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
    public partial class ReporteMovimientosForm : Form
    {
        private string connection = "Data Source=EDUARDO\\SQLEXPRESS; Initial Catalog= BOUTIQUE; Integrated Security=True";
        private string connectionString;
        databaseConnection db = new databaseConnection();

        public ReporteMovimientosForm()
        {
            InitializeComponent();
            InitializeConnectionString();

            // Configuración inicial
            dtpFechaDesde.Value = DateTime.Now.AddMonths(-1);
            dtpFechaHasta.Value = DateTime.Now;

            // Puedes cargar comboboxes si necesitas filtros adicionales
            CargarFiltrosAdicionales();

        }

        private void InitializeConnectionString()
        {
            connectionString = "Server=EDUARDO.;Database=BOUTIQUE;Integrated Security=True;";
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
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Error: No se ha configurado la conexión a la base de datos.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            //HTML
            var html = new StringBuilder();
            // Estilos CSS
            html.Append(@"<html>
                <head>
                <style>
                    body { font-family: Arial, sans-serif; margin: 20px; }
                    h1, h2, h3 { color: #2c3e50; }
                    table { width: 100%; border: 4px solid black; border-collapse: collapse; table-layout: fixed; }
                    td, th { border: 2px solid black; height: 30px; padding-left: 8px; padding-right: 8px; }
                    .right-align { text-align: right; }
                    .center { text-align: center; }
                    .no-border { border-color: white; }
                    .signature-space { height: 150px; }
                </style>
                </head>
                <body>");

            // Obtener datos necesarios de la base de datos
            int totalStock = 0;
            int entradasProveedor = 0;
            int entradasSucursal = 0;
            int entradasDevolucion = 0;
            int salidasVenta = 0;
            int salidasSucursal = 0;
            int salidasRobo = 0;
            int salidasDaniada = 0;
            int salidasSobreStock = 0;
            int salidasTemporada = 0;
            int salidasDescontinuada = 0;

            using (var connection = new SqlConnection())
            {
                connection.Open();
                // Obtener total de stock actual
                var queryTotal = "SELECT SUM(Cantidad) FROM PRODUCTOS WHERE Visibilidad = 1";
                using (var command = new SqlCommand(queryTotal, connection))
                {
                    totalStock = Convert.ToInt32(command.ExecuteScalar());
                }
                // Obtener movimientos de entrada y salida en el período seleccionado
                var queryMovimientos = @"
            SELECT 
                tm.Nombre as TipoMovimiento,
                c.Causa,
                SUM(m.Cantidad) as Cantidad
            FROM MOVIMIENTOS m
            JOIN TIPOMOVIMIENTO tm ON m.TipoMovimiento = tm.ID_Tipo
            JOIN CAUSA c ON m.Causa = c.ID_Causa
            WHERE m.Fecha BETWEEN @FechaDesde AND @FechaHasta
            GROUP BY tm.Nombre, c.Causa";

                using (var command = new SqlCommand(queryMovimientos, connection))
                {
                    command.Parameters.AddWithValue("@FechaDesde", dtpFechaDesde.Value);
                    command.Parameters.AddWithValue("@FechaHasta", dtpFechaHasta.Value.AddDays(1));

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tipo = reader["TipoMovimiento"].ToString();
                            var causa = reader["Causa"].ToString();
                            var cantidad = Convert.ToInt32(reader["Cantidad"]);

                            if (tipo == "Entrada")
                            {
                                if (causa == "Compra a proveedor") entradasProveedor = cantidad;
                                else if (causa == "Transferencia entre sucursales") entradasSucursal = cantidad;
                                else if (causa == "Devolución de cliente") entradasDevolucion = cantidad;
                            }
                            else if (tipo == "Salida")
                            {
                                if (causa == "Venta") salidasVenta = cantidad;
                                else if (causa == "Transferencia entre sucursales") salidasSucursal = cantidad;
                                else if (causa == "Robo") salidasRobo = cantidad;
                                else if (causa == "Dañado") salidasDaniada = cantidad;
                                else if (causa == "Sobre stock") salidasSobreStock = cantidad;
                                else if (causa == "Temporada finalizada") salidasTemporada = cantidad;
                                else if (causa == "Producto descontinuado") salidasDescontinuada = cantidad;
                            }
                        }
                    }
                }
            }
            // Encabezado principal
            html.Append(@"<center>
                <h1>AUDITORÍA DE INVENTARIO</h1>
                
                <table>
                    <tr class='center'>
                        <th rowspan='2'>LOGO</th>
                        <td rowspan='2' width='500px'><h2>Reporte de Stock</h2></td>
                        <td>Páginas : 1 de 1</td>
                        <td>Reporte No. " + DateTime.Now.ToString("yyyyMMdd") + @"</td>
                    </tr>
                    <tr class='center'>
                        <td colspan='2'>Fecha de Expedición: " + DateTime.Now.ToString("dd / MM / yyyy") + @"</td>
                    </tr>
                </table>");
            // Datos generales
            html.Append(@"<h3>Datos Generales</h3>
                <table>
                    <tr>
                        <td>Usuario:</td>
                        <td colspan='2'>" + GetCurrentUserName() + @"</td>
                    </tr>
                    <tr>
                        <td colspan='2'>Periodo de Evaluación: " +
                                dtpFechaDesde.Value.ToString("dd / MM / yyyy") + " a " +
                                dtpFechaHasta.Value.ToString("dd / MM / yyyy") + @"</td>
                        <td>Hora de Generación: " + DateTime.Now.ToString("hh:mm:ss tt") + @"</td>
                    </tr>
                </table>");
            // Datos del inventario
            html.Append(@"<h3>Datos del Inventario</h3>
                <table>
                    <tr>
                        <th width='50px'>Folio.</th>
                        <th>Factores a Evaluar</th>
                        <th width='150px'>Unidades:</th>
                    </tr>
                    <tr style='border: 4px solid black'>
                        <td colspan='3' class='center'>Total de mercancía actual en sistema: " + totalStock + @"</td>
                    </tr>
                    <tr style='border: 4px solid black'>
                        <td colspan='3'>Entrada :</td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>Total de mercancía recibida (De proveedor).</td>
                        <td class='right-align'>" + entradasProveedor + @"</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>Total de mercancía recibida de otra sucursal.</td>
                        <td class='right-align'>" + entradasSucursal + @"</td>
                    </tr>
                    <tr>
                        <td>3</td>
                        <td>Total de mercancía que fue re-integrada (Por devolución de cliente).</td>
                        <td class='right-align'>" + entradasDevolucion + @"</td>
                    </tr>
                    <tr style='border: 4px solid black'>
                        <td colspan='3'>Salida : </td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>Total de mercancía que salió (De venta).</td>
                        <td class='right-align'>" + salidasVenta + @"</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>Total de mercancía mandada a otra sucursal.</td>
                        <td class='right-align'>" + salidasSucursal + @"</td>
                    </tr>
                    <tr>
                        <td>3</td>
                        <td>Total de mercancía robada.</td>
                        <td class='right-align'>" + salidasRobo + @"</td>
                    </tr>
                    <tr>
                        <td>4</td>
                        <td>Total de mercancía dañada.</td>
                        <td class='right-align'>" + salidasDaniada + @"</td>
                    </tr>
                    <tr>
                        <td>5</td>
                        <td>Total de mercancía devuelta a proveedor (Por sobre stock).</td>
                        <td class='right-align'>" + salidasSobreStock + @"</td>
                    </tr>
                    <tr>
                        <td>6</td>
                        <td>Total de mercancía devuelta a proveedor (Mercancía de Temporada).</td>
                        <td class='right-align'>" + salidasTemporada + @"</td>
                    </tr>
                    <tr>
                        <td>7</td>
                        <td>Total de mercancía devuelta a proveedor (Mercancía descontinuada).</td>
                        <td class='right-align'>" + salidasDescontinuada + @"</td>
                    </tr>
                </table>");
            // Resultados (simplificado sin gráfica)
            html.Append(@"<h3>Resultados</h3>
                <table>
                    <tr>
                        <th colspan='2'>Resumen de movimientos</th>
                    </tr>
                    <tr>
                        <td>Total Entradas</td>
                        <td class='right-align'>" + (entradasProveedor + entradasSucursal + entradasDevolucion) + @"</td>
                    </tr>
                    <tr>
                        <td>Total Salidas</td>
                        <td class='right-align'>" + (salidasVenta + salidasSucursal + salidasRobo + salidasDaniada +
                                salidasSobreStock + salidasTemporada + salidasDescontinuada) + @"</td>
                    </tr>
                    <tr>
                        <td>Diferencia</td>
                        <td class='right-align'>" + ((entradasProveedor + entradasSucursal + entradasDevolucion) -
                                (salidasVenta + salidasSucursal + salidasRobo + salidasDaniada +
                                salidasSobreStock + salidasTemporada + salidasDescontinuada)) + @"</td>
                    </tr>
                </table>");
            // Firmas
            html.Append(@"<br>
                <table style='border-color: white;'>
                    <tr class='signature-space'>
                        <td class='no-border'></td>
                        <td class='no-border'></td>
                    </tr>
                    <tr>
                        <td class='no-border'>_____________________________________</td>
                        <td class='no-border'>_____________________________________</td>
                    </tr>
                    <tr>
                        <td class='no-border'>Firma del Responsable</td>
                        <td class='no-border'>Sello de Validación</td>
                    </tr>
                </table>
                </center>");

            html.Append("</body></html>");

            return html.ToString();
        }
        // Método auxiliar para obtener el nombre del usuario actual
        private string GetCurrentUserName()
        {
            // Implementa según tu sistema de autenticación
            return System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            // O si usas tu tabla USUARIO:
            // return "Nombre del usuario desde tu sistema";
        }
    }
}


