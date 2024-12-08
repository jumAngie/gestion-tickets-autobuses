using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus
{
    public class ScriptsDatabase
    {
        #region Empleados
        public static string ListarEmpleados = "";
        public static string BuscarEmpleados = "Gral.Empleados_Buscar";
        public static string InsertarEmpleados = "Gral.UDP_tbPersonas_Insertar";
        #endregion
        #region Clientes
        public static string InsertarClientes = "Gral.UDP_tbPersonas_Insertar";
        public static string ListarClientes = "SELECT * FROM Gral.DatosGenerales_Cliente";
        #endregion
        #region Autobuses
        public static string InsertarAutobuses = "Tick.UDP_tbAutobuses_Insertar";
        #endregion
    }
}
