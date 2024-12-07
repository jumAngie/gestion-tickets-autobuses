using Gestion_De_Tickets_Autobus.Tickets_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class EmpleadosDAL
    {
        //INSERTAR
        public static string InsertarClientes(Personas PrEmpleados)
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
                    cmd.Parameters.AddWithValue("@per_Sexo", PrEmpleados.per_Sexo);
                    cmd.Parameters.AddWithValue("@per_Cargo", PrEmpleados.per_Cargo);
                    cmd.Parameters.AddWithValue("@per_Direccion", PrEmpleados.per_Direccion);
                    cmd.Parameters.AddWithValue("@per_Estado", PrEmpleados.per_Estado);
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
    }
}
