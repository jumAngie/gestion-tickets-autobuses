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
        public static List<AutobusesViewModel> ListarAutobuses()
        {
            List<AutobusesViewModel> lista = new List<AutobusesViewModel>();

            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    string query = ScriptsDatabase.ListarAutobuses;
                    SqlCommand comando = new SqlCommand(query, conexion);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        AutobusesViewModel autobus = new AutobusesViewModel
                        {
                            aut_Matricula = reader.GetString(0), 
                            mar_Descripcion = reader.GetInt32(1),  
                            mod_Descripcion = reader.GetInt32(2), 
                            aut_esVIP = reader.GetString(3),   
                            aut_cantAsientos = reader.GetInt32(4),
                        };

                        
                        lista.Add(autobus);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al listar autobuses: " + ex.Message);
            }

            return lista;
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
