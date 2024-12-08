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

            [DisplayName("Marca")]
            public int mar_Descripcion { get; set; }

            [DisplayName("Modelo")]
            public int mod_Descripcion { get; set; }

            [DisplayName("Exclusividad VIP")]
            public string aut_esVIP { get; set; }

            [DisplayName("Cantidad de Asientos")]
            public int aut_cantAsientos { get; set; }
        }
    }


