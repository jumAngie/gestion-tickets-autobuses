using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_Entities
{
    public class TicketEncabezado
    {
       public int  per_ID { get; set; }
       public int meto_ID { get; set; }
       public decimal tik_Subtotal { get; set; }
       public decimal tik_Impuesto { get; set; }
        public decimal tik_Total { get; set; }
        public int usu_UsuarioCreacion { get; set; }
        public DateTime tik_FechaCreacion { get; set; }
        public string listaAsientos { get; set; }
    }
}
