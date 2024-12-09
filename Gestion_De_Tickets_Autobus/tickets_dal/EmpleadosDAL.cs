using Gestion_De_Tickets_Autobus.Tickets_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_De_Tickets_Autobus.Tickets_ViewModels;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class EmpleadosDAL
    {
        //INSERTAR
        public static string InsertarEmpleados(Personas PrEmpleados)
        {
            string Mensaje = "";
            try
            {
                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(ScriptsDatabase.InsertarEmpleados, conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    string fechaformateada = PrEmpleados.per_FechaNacimiento.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@per_NombreCompleto", PrEmpleados.per_NombreCompleto);
                    cmd.Parameters.AddWithValue("@per_DNI", PrEmpleados.per_DNI);
                    cmd.Parameters.AddWithValue("@per_Extranjero", PrEmpleados.per_Extranjero);
                    cmd.Parameters.AddWithValue("@per_Telefono", PrEmpleados.per_Telefono);
                    cmd.Parameters.AddWithValue("@per_Correo", PrEmpleados.per_Correo);
                    cmd.Parameters.AddWithValue("@per_FechaNacimiento", fechaformateada);
                    cmd.Parameters.AddWithValue("@sex_ID", PrEmpleados.per_Sexo);
                    cmd.Parameters.AddWithValue("@car_ID", PrEmpleados.per_Cargo);
                    cmd.Parameters.AddWithValue("@ciud_ID", PrEmpleados.per_Ciudad);
                    cmd.Parameters.AddWithValue("@per_Direccion", PrEmpleados.per_Direccion);
                    cmd.Parameters.AddWithValue("@usu_UsuarioCreacion", PrEmpleados.usu_UsuarioCreacion);
                    cmd.Parameters.AddWithValue("@per_FechaCreacion", PrEmpleados.per_FechaCreacion);


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

        // LISTAR

        public static List<EmpleadosViewModel> ListarEmpleados()
        {
            List<EmpleadosViewModel> lista = new List<EmpleadosViewModel>();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                conexion.Open();
                string query = ScriptsDatabase.ListarEmpleados;
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    EmpleadosViewModel EmpleadosView = new EmpleadosViewModel();
                    EmpleadosView.per_ID = reader.GetInt32(0);
                    EmpleadosView.NombreCompleto = reader.GetString(1);
                    EmpleadosView.Correo = reader.GetString(2);
                    EmpleadosView.DNI = reader.GetString(3);
                    EmpleadosView.Telefono = reader.GetString(4);
                    EmpleadosView.FechaNacimiento = reader.GetDateTime(5);
                    EmpleadosView.Sexo_Descripcion = reader.GetString(6);
                    EmpleadosView.Ciud_Descripcion = reader.GetString(7);
                    EmpleadosView.Dept_Descripcion = reader.GetString(8);
                    EmpleadosView.Pais_Descripcion = reader.GetString(9);
                    EmpleadosView.Direccion = reader.GetString(10);


                    lista.Add(EmpleadosView);
                }

                conexion.Close();
                return lista;
            }
        }

        //  EDITAR
            public static Personas Editar_CargarDatos(int emp_ID)
            {
                Personas empleados = null;
                try
                {
                    using (SqlConnection conexion = BDConnection.ObtenerConexion())
                    {
                        conexion.Open();
                        SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarEmpleados_CargarInformacion, conexion);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@per_Id", emp_ID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                empleados = new Personas


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
                return empleados;
            }

            public static string EditarEmpleados(Personas empleados)
            {
                string mensaje = "";
                try
                {
                    using (SqlConnection conexion = BDConnection.ObtenerConexion())
                    {
                        conexion.Open();
                        SqlCommand cmd = new SqlCommand(ScriptsDatabase.EditarEmpleados, conexion);
                        cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@per_ID", empleados.per_Id);
                    cmd.Parameters.AddWithValue("@per_NombreCompleto", empleados.per_NombreCompleto);
                    cmd.Parameters.AddWithValue("@per_Correo", empleados.per_Correo);
                    cmd.Parameters.AddWithValue("@per_DNI", empleados.per_DNI);
                    cmd.Parameters.AddWithValue("@per_extranjero", empleados.per_Extranjero);
                    cmd.Parameters.AddWithValue("@per_Telefono", empleados.per_Telefono);
                    cmd.Parameters.AddWithValue("@per_FechaNacimiento", empleados.per_FechaNacimiento);
                    cmd.Parameters.AddWithValue("@sex_ID", empleados.per_Sexo);
                    cmd.Parameters.AddWithValue("@car_ID", empleados.per_Cargo);
                    cmd.Parameters.AddWithValue("@ciud_Id", empleados.per_Ciudad);
                    cmd.Parameters.AddWithValue("@per_Direccion", empleados.per_Direccion);
                    cmd.Parameters.AddWithValue("@usu_UsuarioModificacion", empleados.usu_UsuarioModificacion);
                    cmd.Parameters.AddWithValue("@per_FechaModificacion", empleados.per_FechaModificacion);



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

    }
    
}
