using Gestion_De_Tickets_Autobus.Tickets_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_De_Tickets_Autobus.Tickets_ViewModels;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class TicketsDetallesDAL
    {
        public static List<TicketsDetallesViewModel> TicketsDetalles(int tik_ID)
        {
            List<TicketsDetallesViewModel> lista = new List<TicketsDetallesViewModel>();
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.ListarDetallesPorID, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@tik_ID", tik_ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TicketsDetallesViewModel detalle = new TicketsDetallesViewModel();
                            detalle.tdt_ID = reader.GetInt32(0);
                            detalle.num_Asiento = reader.GetInt32(1);
                            detalle.pln_Fecha = reader.GetDateTime(2);
                            detalle.aut_esVIP = reader.GetString(3);
                            detalle.aut_Matricula = reader.GetString(4);
                            detalle.hor_ruta = reader.GetString(5);
                            detalle.hor_hora = reader.GetString(6);
                            detalle.desSalida = reader.GetString(7);
                            detalle.desDestino = reader.GetString(8);
                            detalle.pre_precio = reader.GetDecimal(9);


                            lista.Add(detalle);
                        }

                        conexion.Close();
                        return lista;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la información: " + ex.Message);
            }
        }

    }
}
