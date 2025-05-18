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
    public partial class MostrarDetallesProductos : Form
    {
        //Declaracion de la cadena de conexion
        //SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");
        databaseConnection conexion = new databaseConnection();

        public MostrarDetallesProductos(int id, string nombre, int IDmarca, string descripcion, int IDcategoria, float precio, int cantidad, int IDcolor, string talla, string fecha,int puntoreorden, int maximo, int minimo)
        {
            InitializeComponent();

            try
            {
                conexion.Open();

                string query = $"SELECT Nombre FROM MARCA WHERE ID_Marca = {IDmarca}";
                SqlCommand cmd = new SqlCommand(query, conexion.getConnection());

                object marca = cmd.ExecuteScalar();

                conexion.Close();

                conexion.Open();

                string query2 = $"SELECT Nombre FROM CATEGORIA WHERE ID_Categoria = {IDcategoria}";
                SqlCommand cmd2 = new SqlCommand(query2, conexion.getConnection());

                object categoria = cmd2.ExecuteScalar();

                conexion.Close();

                conexion.Open();

                string query3 = $"SELECT Nombre FROM COLOR WHERE ID_Color = {IDcolor}";
                SqlCommand cmd3 = new SqlCommand(query3, conexion.getConnection());

                object color = cmd3.ExecuteScalar();

                conexion.Close();



                txtbox_IDProducto.Text = id.ToString();
                txtbox_NombreProducto.Text = nombre.ToString();
                txtbox_Marca.Text = marca.ToString();
                txtbox_DescripcionProducto.Text = descripcion.ToString();
                txtbox_Categoria.Text = categoria.ToString();
                txtbox_Precio.Text = precio.ToString();
                txtbox_Cantidad.Text = cantidad.ToString();
                txtbox_Color.Text = color.ToString();
                txtbox_talla.Text = talla.ToString();
                txtbox_Fecha.Text = fecha.ToString();
                txtbox_PuntoReorden.Text = puntoreorden.ToString();
                txtbox_MaximoStock.Text = maximo.ToString();
                txtbox_MinimoStock.Text = minimo.ToString();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }

        private void txtbox_talla_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarDetallesProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
