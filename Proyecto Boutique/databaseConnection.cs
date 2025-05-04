using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Boutique
{

    /*
        Martin: MARTIN\\SQLEXPRESS
    */
    internal class databaseConnection
    {
        string connection = "Data Source=DESKTOP-BF3NJMJ; Initial Catalog= BOUTIQUE; Integrated Security=True";
        //Equipos:
        //Chuy: DESKTOP-BF3NJMJ

        public SqlConnection connectiondb = new SqlConnection();

        public databaseConnection()
        {
            connectiondb.ConnectionString = connection;
        }

        public void open()
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

        public void close()
        {
            connectiondb.Close();
        }

        public SqlConnection getConnection()
        {
            return connectiondb;
        }
    }
}

