using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Boutique
{
    internal class databaseConnection
    {
        private static string Conexion = "Data Source =DESKTOP-JGTCE3J; Initial Catalog = BKDOS; integrated security=true";

        public static SqlConnection GetConnection()
        {
            SqlConnection db = new SqlConnection(Conexion);

            //Valida el estado de la conexion
            if (db.State != System.Data.ConnectionState.Open)
            {
                db.Open();
            }
            return db;
        }
    }
}
