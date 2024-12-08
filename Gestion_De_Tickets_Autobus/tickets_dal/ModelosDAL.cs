using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    internal class ModelosDAL
    {
        public DataTable CargarModelosPorMarca(int mar_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = BDConnection.ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.Modelos_CMBX, conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mar_ID", mar_ID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}

