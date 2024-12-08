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
        public static string ListarEmpleados = "SELECT * FROM Gral.Empleados_Listado";
        public static string BuscarEmpleados = "Gral.Empleados_Buscar";
        public static string InsertarEmpleados = "Gral.UDP_tbPersonas_Insertar";
        public static string EditarEmpleados_CargarInformacion = "Gral.UDP_tbPersonas_CargarInformacion";
        public static string EditarEmpleados = "Gral.UDP_tbPersonas_Editar";
        #endregion

        #region Clientes
        public static string ListarClientes = "SELECT * FROM Gral.Clientes_Listado";
        public static string BuscarClientes = "";
        public static string InertarClientes = "Gral.UDP_tbPersonas_Insertar";
        public static string EditarClientes_CargarInformacion = "Gral.UDP_tbPersonas_CargarInformacion";
        public static string EditarClientes = "Gral.UDP_tbPersonas_Editar";
        #endregion

        #region Autobuses
        public static string ListarAutobuses = "SELECT * FROM Tick.Listado_Autobuses";
        public static string BuscarAutobuses = "";
        public static string InsertarAutobuses = "Tick.UDP_tbAutobuses_Insertar";
        public static string EditarAutobuses_CargarInformacion = "Tick.UDP_tbAutobuses_CargarInformacion";
        public static string EditarAutbouses = "Tick.UDP_tbAutobuses_Editar";
        #endregion
    }
}
