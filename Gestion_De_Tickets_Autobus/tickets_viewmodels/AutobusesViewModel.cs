using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        namespace Gestion_De_Tickets_Autobus.Tickets_ViewModels
    {
        public class AutobusesViewModel
        {
            [DisplayName("ID del Autobús")]
            public int aut_Id { get; set; }

            [DisplayName("Matrícula")]
            public string aut_Matricula { get; set; }

            [DisplayName("ID de Marca")]
            public int mar_ID { get; set; }

            [DisplayName("ID de Modelo")]
            public int mod_ID { get; set; }

            [DisplayName("Exclusividad VIP")]
            public bool aut_esVIP { get; set; }

            [DisplayName("Cantidad de Asientos")]
            public int aut_cantAsientos { get; set; }

            [DisplayName("Estado Activo")]
            public bool aut_Estado { get; set; }

            [DisplayName("Usuario de Creación")]
            public int usu_UsuarioCreacion { get; set; }

            [DisplayName("Fecha de Creación")]
            public DateTime aut_FechaCreacion { get; set; }

            [DisplayName("Usuario de Modificación")]
            public int usu_UsuarioModificacion { get; set; }

            [DisplayName("Fecha de Modificación")]
            public DateTime aut_FechaModificacion { get; set; }
        }
    }


