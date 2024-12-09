using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_ViewModels
{
    public class TicketsDetallesViewModel
    {
        [DisplayName("ID")]
        public int tdt_ID {  get; set; }

        [DisplayName("Número de Asiento")]
        public int num_Asiento { get; set; }

        [DisplayName("Fecha")]
        public DateTime pln_Fecha { get; set; }

        [DisplayName("Tipo de Autobus")]
        public string aut_esVIP { get; set; }

        [DisplayName("Marícula")]
        public string aut_Matricula { get; set; }

        [DisplayName("Ruta")]
        public string hor_ruta { get; set; }

        [DisplayName("Hora")]
        public string hor_hora { get; set; }
        
        [DisplayName("Punto de Salida")]
        public string desSalida { get; set; }

        [DisplayName("Punto Destino")]
        public string desDestino { get; set; }

        [DisplayName("Precio")]
        public decimal pre_precio { get; set; }

    }
}
