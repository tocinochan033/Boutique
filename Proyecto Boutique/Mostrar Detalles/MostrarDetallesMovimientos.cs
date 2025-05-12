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

namespace Proyecto_Boutique.Mostrar_Detalles
{
    public partial class MostrarDetallesMovimientos : Form
    {
        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion = new databaseConnection();


        public MostrarDetallesMovimientos(int id, int resultadousuario, int resultadoproducto, int resultadotipomovimiento, int cantidad, int resultadocausa, string fecha)
        {
            try
            {
                InitializeComponent();

                conexion.Open();

                string query = $"SELECT Nombre FROM USUARIO WHERE ID_Usuario = {resultadousuario}";
                SqlCommand cmd = new SqlCommand(query, conexion.getConnection());

                object usuario = cmd.ExecuteScalar();

                conexion.Close();

                conexion.Open();

                string query2 = $"SELECT Nombre FROM PRODUCTOS WHERE ID_Producto = {resultadoproducto}";
                SqlCommand cmd2 = new SqlCommand(query2, conexion.getConnection());

                object producto = cmd2.ExecuteScalar();

                conexion.Close();

                conexion.Open();

                string query3 = $"SELECT Nombre FROM TIPOMOVIMIENTO WHERE ID_Tipo = {resultadotipomovimiento}";
                SqlCommand cmd3 = new SqlCommand(query3, conexion.getConnection());

                object tipomovimiento = cmd3.ExecuteScalar();

                conexion.Close();

                conexion.Open();

                string query4 = $"SELECT Causa FROM CAUSA WHERE ID_Causa = {resultadocausa}";
                SqlCommand cmd4 = new SqlCommand(query4, conexion.getConnection());

                object causa = cmd4.ExecuteScalar();

                conexion.Close();


                txt_IDMovimiento.Text = id.ToString();
                txtbox_UsuarioResponsable.Text = usuario.ToString();
                txtbox_ProductoMovimiento.Text = producto.ToString();
                txtbox_TipoMovimiento.Text = tipomovimiento.ToString();
                txtbox_CantidadProducto.Text = cantidad.ToString();
                txtbox_Causa.Text = causa.ToString();
                txtbox_Fecha.Text = fecha.ToString();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }
    }
}
