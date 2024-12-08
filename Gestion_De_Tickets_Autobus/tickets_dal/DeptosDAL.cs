using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_DAL
{
    public class DeptosDAL
    {
        //COMBOBOX
         public DataTable CargarDepartamentosPorPais(int pais_Id)
            {
                DataTable dt = new DataTable();

                using (SqlConnection conexion = BDConnection.ObtenerConexion())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(ScriptsDatabase.Departamentos_CMBX, conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pais_Id", pais_Id);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }

                return dt;
            }
        
    }
}
