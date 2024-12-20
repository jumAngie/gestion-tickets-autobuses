﻿using System;
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
        public static string EliminarEmpleados = "Gral.UDP_tbPersonas_Eliminar";
        #endregion

        #region Clientes
        public static string ListarClientes = "SELECT * FROM Gral.Clientes_Listado";
        public static string BuscarClientes = "";
        public static string InsertarClientes = "Gral.UDP_tbPersonas_Insertar";
        public static string EditarClientes_CargarInformacion = "Gral.UDP_tbPersonas_CargarInformacion";
        public static string EditarClientes = "Gral.UDP_tbPersonas_Editar";
        public static string EliminarClientes = "Gral.UDP_tbPersonas_Eliminar";
        #endregion

        #region Autobuses
        public static string ListarAutobuses = "SELECT * FROM Tick.Listado_Autobuses";
        public static string BuscarAutobuses = "";
        public static string InsertarAutobuses = "Tick.UDP_tbAutobuses_Insertar";
        public static string EditarAutobuses_CargarInformacion = "Tick.UDP_tbAutobuses_CargarInformacion";
        public static string EditarAutobuses = "Tick.UDP_tbAutobuses_Editar";
        public static string Autobuses_Asientos = "Tick.Asientos_Autobus";
        public static string EliminarAutobuses = "Tick.UDP_tbAutobusess_Eliminar";
        #endregion

        #region ComboBox
        public static string Paises_CMBX = "Gral.Paises_CMB";
        public static string Departamentos_CMBX = "Gral.Departamentos_CMB";
        public static string Ciudades_CMBX = "Gral.Ciudades_CMB";
        public static string MetodosPago_CMBX = "Tick.MetodosPago_CMB";
        public static string Modelos_CMBX = "Tick.Modelos_CMB";
        public static string Marcas_CMBX = "Tick.Marcas_CMB";
        public static string Salidad_CMBX = "Gral.Salidas_CMB";
        public static string Destinos_CMBX = "Tick.Destinos_CMB";
        public static string PersonasExistentes_Clientes = "Gral.Clientes";
        public static string PersonasExistentes_Empleados = "Gral.Empleados";
        public static string Autobuses_CMBX = "Tick.Autobus_CMB";
        public static string Clientes_Listar = "Gral.tbClientes_Listar_";
        #endregion

        #region Validaciones
        public static string ExistenciaDNI = "Gral.ValidarExistenciaDNI";
        public static string RegistrarPersonaExistente = "Tick.ActualizarCargo";
        #endregion

        #region Tickets Encabezado
        public static string ListarTickets = "SELECT * FROM Tick.Tickets_Listado";
        public static string Autobus_Precio = "Tick.Autobus_Precio";
        public static string TicketCompleto = "Tick.Insertar_Ticket_Completo";
        #endregion

        #region Tickets Detalle
        public static string ListarDetallesPorID = "Tick.Tickets_Detalles_Listado";
        #endregion

        #region LogIn
        public static string DibujarPantallas = "Acce.UDP_DibujarMenuPorRol";
        public static string IniciarSesion = "Acce.UDP_IniciarSesion";
        #endregion

        #region Dashboard
        public static string ClientesRegistrados = "Tick.ClientesRegistrados";
        public static string EmpleadosRegistrados = "Tick.EmpleadosRegistrados";
        public static string TicketsVendidos = "Tick.TicketsVendidos";
        #endregion
    }
}
