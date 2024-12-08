using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_De_Tickets_Autobus.Tickets_Entities;
using Gestion_De_Tickets_Autobus.Tickets_ViewModels;

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
                    ClienteView.NombreCompleto = reader.GetString(0);
                    ClienteView.Correo = reader.GetString(1);
                    ClienteView.DNI = reader.GetString(2);
                    ClienteView.Telefono = reader.GetString(3);
                    ClienteView.FechaNacimiento = reader.GetDateTime(4);
                    ClienteView.Sexo_Descripcion = reader.GetString(5);
                    ClienteView.Ciud_Descripcion = reader.GetString(6);
                    ClienteView.Dept_Descripcion = reader.GetString(7);
                    ClienteView.Pais_Descripcion = reader.GetString(8);
                    ClienteView.Direccion = reader.GetString(9);
       

                    lista.Add(ClienteView);
                }

                conexion.Close();
                return lista;
            }
        }
    }
}
