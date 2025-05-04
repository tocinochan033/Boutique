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
    public partial class Principal_forms : Form
    {
        //Declaracion de objetos para las ventanas de creacion de elementos
        CrearUsuario ventanaCrearUsuario;
        CrearProducto ventanaCrearProducto;

        public Principal_forms()
        {
            InitializeComponent();
        }
        
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-BF3NJMJ;Initial Catalog=BOUTIQUE; Integrated Security=True");

        //Creacion de un objeto SqlDataAdapter para reutilizarlo mas adelante
        SqlDataAdapter adaptador = new SqlDataAdapter();

        private void lbl_Usuarios_Click(object sender, EventArgs e)
        {

        }

        private void Principal_forms_Load(object sender, EventArgs e)
        {
            //Se mandan a llamar los metodos hechos para obtener los datos de las respectivas tablas de cada apartado
            ObtenerRegistrosUsuarios();
            ObtenerRegistrosProductos();
            ObtenerMovimientos();
        }

        private void ObtenerRegistrosUsuarios()
        {
            conexion.Open();
            //Creacion de consulta para visualizar todos los campos de las respectivas tablas
            String ConsultaUsuarios = "Select * from USUARIO";

            //Se utiliza el objeto sqldataadapter creado anteriormente
            adaptador = new SqlDataAdapter(ConsultaUsuarios, conexion);

            //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
            DataTable dtUSUARIO = new DataTable();

            //Se pasan los datos del datatable al objeto adaptador
            adaptador.Fill(dtUSUARIO);

            //Se envian los parametros al datagridview de usuarios
            DataGrid_Usuarios.DataSource = dtUSUARIO;
            conexion.Close();
        }

        private void ObtenerRegistrosProductos()
        {
            conexion.Open();
            //Creacion de consulta para visualizar todos los campos de las respectivas tablas
            String ConsultarProductos = "Select * from PRODUCTOS";

            //Se utiliza el objeto sqldataadapter creado anteriormente
            adaptador = new SqlDataAdapter(ConsultarProductos, conexion);

            //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
            DataTable dtPRODUCTOS = new DataTable();

            //Se pasan los datos del datatable al objeto adaptador
            adaptador.Fill(dtPRODUCTOS);

            //Se envian los parametros al datagridview de usuarios
            DataGrid_Productos.DataSource = dtPRODUCTOS;
            conexion.Close();
        }

        private void ObtenerMovimientos()
        {
            conexion.Open();
            //Creacion de consulta para visualizar todos los campos de las respectivas tablas
            String ConsultaMovimientos = "Select * from MOVIMIENTOS";

            //Se utiliza el objeto sqldataadapter creado anteriormente
            adaptador = new SqlDataAdapter(ConsultaMovimientos, conexion);

            //Creacion de un objeto tipo DataTable para rellenar la informacion en el Datagridview
            DataTable dtMOVIMIENTOS = new DataTable();

            //Se pasan los datos del datatable al objeto adaptador
            adaptador.Fill(dtMOVIMIENTOS);

            //Se envian los parametros al datagridview de usuarios
            DataGrid_Movimientos.DataSource = dtMOVIMIENTOS;
            conexion.Close();
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            //Estructura condicional para que solo se pueda abrir una ventana para crear usuario
            if(ventanaCrearUsuario == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearUsuario = new CrearUsuario();

                //Comando auxiliar para el proceso
                ventanaCrearUsuario.FormClosed += new FormClosedEventHandler (CierreVentanaCrearUsuario);

                //Se muestra la ventana correspondiente
                ventanaCrearUsuario.Show();
            }
        }

        //Metodo para cerrar la ventana "CrearUsuario"
        void CierreVentanaCrearUsuario(object sender, EventArgs e)
        {
            ventanaCrearUsuario = null;
        }

        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
            //Estructura condicional para que solo se pueda abrir una ventana para crear usuario
            if (ventanaCrearUsuario == null)
            {
                //Se crea un objeto de la ventana CrearUsuario
                ventanaCrearUsuario = new CrearUsuario();

                //Comando auxiliar para el proceso
                ventanaCrearUsuario.FormClosed += new FormClosedEventHandler(CierreVentanaCrearUsuario);

                //Se muestra la ventana correspondiente
                ventanaCrearUsuario.Show();
            }
        }
    }
}
