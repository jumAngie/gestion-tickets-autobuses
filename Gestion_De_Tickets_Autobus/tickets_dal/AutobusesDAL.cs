using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_De_Tickets_Autobus.Tickets_Entities;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    internal class AutobusesDAL
    {


        //INSERTAR
        public static string InsertarAutobuses(Autobuses aut)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.InsertarAutobuses, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@aut_Matricula", aut.aut_Matricula);
                    cmd.Parameters.AddWithValue("@mar_ID", aut.mar_ID);
                    cmd.Parameters.AddWithValue("@mod_ID", aut.mod_ID);
                    cmd.Parameters.AddWithValue("@aut_esVIP", aut.aut_esVIP);
                    cmd.Parameters.AddWithValue("@aut_cantAsientos", aut.aut_cantAsientos);
                    cmd.Parameters.AddWithValue("@aut_Estado", aut.aut_Estado);
                    cmd.Parameters.AddWithValue("@usu_UsuarioCreacion", aut.usu_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@aut_FechaCreacion", aut.aut_FechaCreacion);

                    mensaje = (string)cmd.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;
                throw;
            }

            return mensaje;
        }
    }
}
