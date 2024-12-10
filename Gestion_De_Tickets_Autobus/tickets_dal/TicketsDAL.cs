using Gestion_De_Tickets_Autobus.Tickets_Entities;
using Gestion_De_Tickets_Autobus.Tickets_ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static string InsertarTicketCompleto(TicketEncabezado encbezado)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.TicketCompleto, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.AddWithValue("@per_ID", encbezado.per_ID);
                    cmd.Parameters.AddWithValue("@meto_ID", encbezado.meto_ID);
                    cmd.Parameters.AddWithValue("@tik_Subtotal", encbezado.tik_Subtotal);
                    cmd.Parameters.AddWithValue("@tik_Impuesto", encbezado.tik_Impuesto);
                    cmd.Parameters.AddWithValue("@tik_Total", encbezado.tik_Total); 
                    cmd.Parameters.AddWithValue("@usu_UsuarioCreacion", encbezado.usu_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@tik_FechaCreacion", encbezado.tik_FechaCreacion);

                    if (string.IsNullOrEmpty(encbezado.listaAsientos))
                    {
                        throw new ArgumentException("La lista de asientos no puede estar vacía.");
                    }

                    cmd.Parameters.AddWithValue("@Lista_Asientos", encbezado.listaAsientos);

                    mensaje = (string)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;
            }

            return mensaje;
        }

        public DataTable CargarClientes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.Clientes_Listar, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }

    }
}
