using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus
{
    public class BDConnection
    {
        private static string connString = "";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connString);

            return conexion;
        }
    }
}
