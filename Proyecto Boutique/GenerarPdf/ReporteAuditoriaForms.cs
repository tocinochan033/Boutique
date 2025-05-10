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
            CargarUsuarios();
            CargarTiposAccion();
        }

        private void CargarUsuarios()
        {
            try
            {
                using (db.getConnection())
                {
                    var query = "SELECT ID_Usuario, Nombre FROM USUARIO WHERE Visibilidad = 1 ORDER BY Nombre";
                    var adapter = new SqlDataAdapter(query, db.getConnection());
                    var table = new DataTable();
                    adapter.Fill(table);

                    cmbUsuario.DisplayMember = "Nombre";
                    cmbUsuario.ValueMember = "ID_Usuario";
                    cmbUsuario.Items.Insert(0, new { ID_Usuario = 0, Nombre = "Todos los usuarios" });
                    cmbUsuario.DataSource  = table;
                    cmbUsuario.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarTiposAccion()
        {
            cmbTipoAccion.Items.AddRange(new object[] {
                "Todas las acciones",
                "Login",
                "Logout",
                "Creación",
                "Modificación",
                "Eliminación",
                "Movimiento de stock"
            });
            cmbTipoAccion.SelectedIndex = 0;
        }
        private bool ValidarFechas()
        {
            if (dtpFechaDesde.Value > dtpFechaHasta.Value)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'",
                              "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void generar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var html = GenerateAuditoriaReportHtml();
                PDFGenerador.ShowSaveDialogAndGenerate(html, $"Reporte_Auditoria_{DateTime.Now:yyyyMMdd}.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //PARTE HTML
        private string GenerateAuditoriaReportHtml()
        {
            var html = new StringBuilder();

            return html.ToString();
        }
    }
}
