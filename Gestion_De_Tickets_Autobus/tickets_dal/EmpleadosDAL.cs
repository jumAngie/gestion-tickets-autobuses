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
                    EmpleadosView.NombreCompleto = reader.GetString(0);
                    EmpleadosView.Correo = reader.GetString(1);
                    EmpleadosView.DNI = reader.GetString(2);
                    EmpleadosView.Telefono = reader.GetString(3);
                    EmpleadosView.FechaNacimiento = reader.GetDateTime(4);
                    EmpleadosView.Sexo_Descripcion = reader.GetString(5);
                    EmpleadosView.Ciud_Descripcion = reader.GetString(6);
                    EmpleadosView.Dept_Descripcion = reader.GetString(7);
                    EmpleadosView.Pais_Descripcion = reader.GetString(8);
                    EmpleadosView.Direccion = reader.GetString(9);


                    lista.Add(EmpleadosView);
                }

                conexion.Close();
                return lista;
            }
        }
    }
}
