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
        private static string connString = "workstation id=TICKETS.mssql.somee.com;packet size=4096;user id=gestion-tickets_SQLLogin_1;pwd=m86l8votyp;data source=TICKETS.mssql.somee.com;persist security info=False;initial catalog=TICKETS;TrustServerCertificate=True";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(connString);

            return conexion;
        }
    }
}
