using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;

namespace Proyecto_Boutique
{

    /*
        Martin: MARTIN\\SQLEXPRESS
        chuy; DESKTOP-BF3NJMJ
        Sandra: LAPTOP-FVNNPBGP
    */
    internal class databaseConnection
    {
        //string connection = "Data Source=MARTIN\\SQLEXPRESS; Initial Catalog= BOUTIQUE; Integrated Security=True";
        //Equipos:
        //Chuy: DESKTOP-BF3NJMJ
        private string connection;
        public SqlConnection connectiondb;

       // public SqlConnection connectiondb = new SqlConnection();

        public databaseConnection()
        {
            // Ruta del archivo JSON junto al .exe
            string path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

            // Construir el objeto de configuración
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Obtener la cadena de conexión
            connection = config.GetConnectionString("DefaultConnection");
            connectiondb = new SqlConnection(connection);
        }

        public void Open()
        {
            try
            {
                connectiondb.Open();
                Console.WriteLine("Conexion Abierta.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la base de datos. ", ex.Message);
            }
        }

        public void Close()
        {
            connectiondb.Close();
            Console.WriteLine("Conexion Cerrada.");
        }

        public SqlConnection getConnection()
        {
            return connectiondb;
        }


    }
}

