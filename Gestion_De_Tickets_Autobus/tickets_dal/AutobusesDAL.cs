using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_De_Tickets_Autobus.Tickets_Entities;
using Gestion_De_Tickets_Autobus.Tickets_ViewModels;
using System.Windows.Forms;

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
        // LISTAR
        public static List<Autobuses> ObtenerTodosLosAutobuses()
        {
            List<Autobuses> listaAutobuses = new List<Autobuses>();

            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT aut_Id, mar_Descripcion, mod_Descripcion, aut_Matricula, aut_cantAsientos, aut_esVIP FROM Autobuses", conexion);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Autobuses autobus = new Autobuses
                        {
                            aut_Id = reader.GetInt32(reader.GetOrdinal("aut_Id")),
                            mar_Descripcion = reader.GetString(reader.GetOrdinal("mar_Descripcion")),
                            mod_Descripcion = reader.GetString(reader.GetOrdinal("mod_Descripcion")),
                            aut_Matricula = reader.GetString(reader.GetOrdinal("aut_Matricula")),
                            aut_cantAsientos = reader.GetInt32(reader.GetOrdinal("aut_cantAsientos")),
                            aut_esVIP = reader.GetBoolean(reader.GetOrdinal("aut_esVIP"))
                        };
                        listaAutobuses.Add(autobus);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los autobuses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaAutobuses;
        }


        //COMBOBOX
        public DataTable CargarAutobuses(int pre_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.Autobuses_CMBX, conexion))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pre_ID", pre_ID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static string Autobus_Precio(int audes_ID)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.Autobus_Precio, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@audes_ID", audes_ID);

                    object resultado = cmd.ExecuteScalar();
                    mensaje = Convert.ToString(resultado);
                }

            }
            catch (Exception ex)
            {
                mensaje = "Error: " + ex.Message;
                throw;
            }

            return mensaje;


        }

        public static List<(int pas_ID, int num_Asiento, bool disponibilidad)> ObtenerAsientos(int audes_ID)
        {
            var listaAsientos = new List<(int, int, bool)>();
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.Autobuses_Asientos, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@audes_ID", audes_ID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        listaAsientos.Add((
                            reader.GetInt32(0), // pas_ID
                            reader.GetInt32(1), // num_Asiento
                            reader.GetBoolean(2)  // disponibilidad
                        ));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return listaAsientos;
        }


    }
}
