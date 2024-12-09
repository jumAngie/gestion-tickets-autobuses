using Gestion_De_Tickets_Autobus.Tickets_ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class LoginDAL
    {
        public DatosUsuarioViewModel AutenticarUsuario(string Usuario, string Contrasenia)
        {
            byte[] contraseniaEncriptada = Encriptacion.Encrip(Contrasenia);

            DatosUsuarioViewModel usuarioAutenticado = null;
            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                string query = ScriptsDatabase.IniciarSesion;
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@usua_Usuario", Usuario);
                    comando.Parameters.AddWithValue("@usua_Contrasenia", contraseniaEncriptada);

                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioAutenticado = new DatosUsuarioViewModel
                            {
                                usu_Id = reader.GetInt32(reader.GetOrdinal("usu_Id")),
                                usu_Usuario = reader.GetString(reader.GetOrdinal("usu_Usuario")),
                                per_ID = reader.GetInt32(reader.GetOrdinal("per_ID")),
                                per_NombreCompleto = reader.GetString(reader.GetOrdinal("per_NombreCompleto")),
                                per_Correo = reader.GetString(reader.GetOrdinal("per_Correo")),
                                rol_Descripcion = reader.GetString(reader.GetOrdinal("rol_Descripcion")),
                                rol_Id = reader.GetInt32(reader.GetOrdinal("rol_Id")),
                                sex_Id = reader.GetInt32(reader.GetOrdinal("sex_Id"))
                            };
                        }
                    }
                }
            }

            return usuarioAutenticado;
        }

        public List<PantallasViewModel> ObtenerPantallasPermitidas(int rol_Id)
        {
            List<PantallasViewModel> pantallas = new List<PantallasViewModel>();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                string query = ScriptsDatabase.DibujarPantallas;
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@rol_Id", rol_Id);
                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PantallasViewModel pantalla = new PantallasViewModel
                            {
                                pant_ID = reader.GetInt32(reader.GetOrdinal("pant_ID")),
                                pant_NombrePantalla = reader.GetString(reader.GetOrdinal("pant_NombrePantalla")),
                                pant_NombreBoton = reader.GetString(reader.GetOrdinal("pant_NombreBoton")),
                                pant_RutaImagen = reader.GetString(reader.GetOrdinal("pant_RutaImagen")),
                                PosicionY = reader.GetInt32(reader.GetOrdinal("PosicionY"))
                            };
                            pantallas.Add(pantalla);
                        }
                    }
                }
            }

            return pantallas;
        }
    }
}
