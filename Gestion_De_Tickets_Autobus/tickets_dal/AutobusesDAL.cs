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
                    cmd.Parameters.AddWithValue("@mod_ID", aut.mod_ID);
                    cmd.Parameters.AddWithValue("@aut_esVIP", aut.aut_esVIP);
                    cmd.Parameters.AddWithValue("@aut_cantAsientos", aut.aut_cantAsientos);
                    cmd.Parameters.AddWithValue("@aut_UsuarioCreacion", aut.usu_UsuarioCreacion);
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
        public static List<AutobusesViewModel> ListarAutobuses()
        {
            List<AutobusesViewModel> listaAutobuses = new List<AutobusesViewModel>();

            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.ListarAutobuses, conexion);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AutobusesViewModel autobus = new AutobusesViewModel
                        {
                            aut_Id = reader.GetInt32(reader.GetOrdinal("aut_Id")),
                            aut_Matricula = reader.GetString(reader.GetOrdinal("aut_Matricula")),
                            mar_Descripcion = reader.GetString(reader.GetOrdinal("mar_Descripcion")),
                            mod_Descripcion = reader.GetString(reader.GetOrdinal("mod_Descripcion")),
                            aut_cantAsientos = reader.GetInt32(reader.GetOrdinal("aut_cantAsientos")),
                            aut_esVIP = reader.GetString(reader.GetOrdinal("aut_esVIP"))
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

        //CARGAR DATOS EDITAR 
        public static Autobuses EditarAutobuses_CargarInformacion(int aut_ID)
        {
            Autobuses aut = null;
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarAutobuses_CargarInformacion, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@aut_ID", aut_ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            aut = new Autobuses
                            {
                                aut_Id = reader.GetInt32(0),
                                aut_Matricula = reader.GetString(1),
                                mar_ID = reader.GetInt32(2),
                                mod_ID = reader.GetInt32(3),
                                aut_esVIP = reader.GetBoolean(4),
                                aut_cantAsientos = reader.GetInt32(5),
                                aut_Estado = reader.GetBoolean(6),
                                
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la información de los Autobuses: " + ex.Message);
            }

            return aut;
        }


        // Editar autobuses
        public static string EditarAutobuses(Autobuses aut)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarAutobuses, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@aut_ID", aut.aut_Id);
                    cmd.Parameters.AddWithValue("@aut_Matricula", aut.aut_Matricula);
                    cmd.Parameters.AddWithValue("@mod_ID", aut.mod_ID);
                    cmd.Parameters.AddWithValue("@aut_esVIP", aut.aut_esVIP);
                    cmd.Parameters.AddWithValue("@aut_cantAsientos", aut.aut_cantAsientos);
                    cmd.Parameters.AddWithValue("@aut_UsuarioModificacion", aut.usu_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@aut_FechaModificacion", aut.aut_FechaModificacion);

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

        //ELIMINAR REGISTRO

        public static string EliminarAutobuses(Autobuses autobuses)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EliminarAutobuses, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@aut_ID", autobuses.aut_Id);
                    cmd.Parameters.AddWithValue("@aut_UsuarioModificacion", autobuses.usu_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@aut_FechaModificacion", autobuses.aut_FechaModificacion);

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
