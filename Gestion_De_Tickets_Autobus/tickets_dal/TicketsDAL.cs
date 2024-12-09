using Gestion_De_Tickets_Autobus.Tickets_ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class TicketsDAL
    {
        //LISTAR
        public static List<TicketsViewModel> ListarTickets()
        {
            List<TicketsViewModel> lista = new List<TicketsViewModel>();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                conexion.Open();
                string query = ScriptsDatabase.ListarTickets;
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    TicketsViewModel ticket = new TicketsViewModel();
                    ticket.tik_ID = reader.GetInt32(0);
                    ticket.per_NombreCompleto = reader.GetString(1);
                    ticket.meto_Descripcion = reader.GetString(2);
                    ticket.tik_Subtotal = reader.GetDecimal(3);
                    ticket.tik_Descuento = reader.GetDecimal(4);
                    ticket.tik_Impuesto = reader.GetDecimal(5);
                    ticket.tik_Total = reader.GetDecimal(6);


                    lista.Add(ticket);
                }

                conexion.Close();
                return lista;
            }
        }
    }
}
