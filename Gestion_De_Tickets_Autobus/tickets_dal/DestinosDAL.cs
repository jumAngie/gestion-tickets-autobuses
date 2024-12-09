using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class DestinosDAL
    {
        public DataTable CargarSalidas()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.Salidad_CMBX, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }

        //COMBOBOX
        public DataTable CargarDestinosPorSalidas(int des_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.Destinos_CMBX, conexion))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@des_ID", des_ID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
