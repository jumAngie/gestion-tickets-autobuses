using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class DashboardDAL
    {
        public static string CantidadDeClientesRegistrdos()
        {
            string clientesRegistrados = "0";
            var clientes = 0;

            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.ClientesRegistrados, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    clientes = (int)cmd.ExecuteScalar();

                    clientesRegistrados = Convert.ToString(clientes);
                }

            }

            catch (Exception ex)
            {
                clientesRegistrados = "Error: " + ex.Message;
                throw;
            }


            return clientesRegistrados;
        }

        public static string CantidadDeEmpleadosRegistrdos()
        {
            string empleadosRegistrados = "0";
            var clientes = 0;

            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EmpleadosRegistrados, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    clientes = (int)cmd.ExecuteScalar();

                    empleadosRegistrados = Convert.ToString(clientes);
                }

            }

            catch (Exception ex)
            {
                empleadosRegistrados = "Error: " + ex.Message;
                throw;
            }


            return empleadosRegistrados;
        }

        public static string CantidadDeTicketsVendidos()
        {
            string tickets = "0";
            var clientes = 0;

            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.TicketsVendidos, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    clientes = (int)cmd.ExecuteScalar();

                    tickets = Convert.ToString(clientes);
                }

            }

            catch (Exception ex)
            {
                tickets = "Error: " + ex.Message;
                throw;
            }


            return tickets;
        }
    }
}
