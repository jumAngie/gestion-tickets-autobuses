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
using Gestion_De_Tickets_Autobus.Tickets_Formularios;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class ClientesDAL
    {

        //INSERTAR
        public static string InsertarClientes(Personas PrClientes)
        {
            string Mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.InsertarClientes, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    string fechaformateada = PrClientes.per_FechaNacimiento.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@per_NombreCompleto", PrClientes.per_NombreCompleto);
                    cmd.Parameters.AddWithValue("@per_Correo", PrClientes.per_Correo);
                    cmd.Parameters.AddWithValue("@per_DNI", PrClientes.per_DNI);
                    cmd.Parameters.AddWithValue("@per_Extranjero", PrClientes.per_Extranjero);
                    cmd.Parameters.AddWithValue("@per_Telefono", PrClientes.per_Telefono);
                    cmd.Parameters.AddWithValue("@per_FechaNacimiento", fechaformateada);
                    cmd.Parameters.AddWithValue("@sex_ID", PrClientes.per_Sexo);
                    cmd.Parameters.AddWithValue("@car_ID", PrClientes.per_Cargo);
                    cmd.Parameters.AddWithValue("@ciud_ID", PrClientes.per_Ciudad);
                    cmd.Parameters.AddWithValue("@per_Direccion", PrClientes.per_Direccion);
                    cmd.Parameters.AddWithValue("@usu_UsuarioCreacion", PrClientes.usu_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@per_FechaCreacion", PrClientes.per_FechaCreacion);


                    Mensaje = (string)cmd.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                Mensaje = "Error: " + ex.Message;
                throw;
            }



            return Mensaje;
        }

        //LISTAR
        public static List<ClientesViewModel> ListarClientes()
        {
            List<ClientesViewModel> lista = new List<ClientesViewModel>();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                conexion.Open();
                string query = ScriptsDatabase.ListarClientes;
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    ClientesViewModel ClienteView = new ClientesViewModel();
                    ClienteView.per_ID = reader.GetInt32(0);
                    ClienteView.NombreCompleto = reader.GetString(1);
                    ClienteView.DNI = reader.GetString(2);
                    ClienteView.Telefono = reader.GetString(3);
                    ClienteView.Correo = reader.GetString(4);
                    ClienteView.FechaNacimiento = reader.GetDateTime(5);
                    ClienteView.Sexo_Descripcion = reader.GetString(6);
                    ClienteView.Ciud_Descripcion = reader.GetString(7);
                    ClienteView.Dept_Descripcion = reader.GetString(8);
                    ClienteView.Pais_Descripcion = reader.GetString(9);
                    ClienteView.Direccion = reader.GetString(10);


                    lista.Add(ClienteView);
                }

                conexion.Close();
                return lista;
            }
        }

        //CARGAR DATOS EDITAR Y EDITAR
        public static Personas Editar_CargarDatos(int clien_ID)
        {
            Personas clientes = null;
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarClientes_CargarInformacion, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@per_Id", clien_ID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clientes = new Personas


                            {
                                per_NombreCompleto = reader.GetString(0),
                                per_Correo = reader.GetString(1),
                                per_DNI = reader.GetString(2),
                                per_Telefono = reader.GetString(3),
                                per_FechaNacimiento = reader.GetDateTime(4),
                                per_Sexo = reader.GetInt32(5),
                                per_Cargo = reader.GetInt32(6),
                                per_Ciudad = reader.GetInt32(7),
                                per_Direccion = reader.GetString(8),
                                dept_Id = reader.GetInt32(9),
                                pais_Id = reader.GetInt32(10),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar la información de los clientes: " + ex.Message);
            }

            return clientes;
        }

        public static string EditarClientes(Personas clientes)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarClientes, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@per_ID", clientes.per_Id);
                    cmd.Parameters.AddWithValue("@per_NombreCompleto", clientes.per_NombreCompleto);
                    cmd.Parameters.AddWithValue("@per_Correo", clientes.per_Correo);
                    cmd.Parameters.AddWithValue("@per_DNI", clientes.per_DNI);
                    cmd.Parameters.AddWithValue("@per_extranjero", clientes.per_Extranjero);
                    cmd.Parameters.AddWithValue("@per_Telefono", clientes.per_Telefono);
                    cmd.Parameters.AddWithValue("@per_FechaNacimiento", clientes.per_FechaNacimiento);
                    cmd.Parameters.AddWithValue("@sex_ID", clientes.per_Sexo);
                    cmd.Parameters.AddWithValue("@car_ID", clientes.per_Cargo);
                    cmd.Parameters.AddWithValue("@ciud_Id", clientes.per_Ciudad);
                    cmd.Parameters.AddWithValue("@per_Direccion", clientes.per_Direccion);
                    cmd.Parameters.AddWithValue("@usu_UsuarioModificacion", clientes.usu_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@per_FechaModificacion", clientes.per_FechaModificacion);



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

        //EXISTENCIAS DNI
        public static bool ExistenciaDNI(string Existencia)
        {
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.ExistenciaDNI, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@per_DNI", Existencia);


                    int resultado = (int)cmd.ExecuteScalar();
                    return resultado == 1;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
                return false;
            }
        }
            //COMBOBOX
            public DataTable CargarPersonasC()
            {
                DataTable dt = new DataTable();

                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.PersonasExistentes_Clientes, conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }

                return dt;
            }

        public static string PersonaExist(int per_Id)
        {
            string mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.PersonasExistentes_Empleados, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@per_ID",per_Id);                    

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
