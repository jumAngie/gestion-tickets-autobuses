using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_ViewModels
{
    public class TicketsViewModel
    {
        [DisplayName("ID")]
        public int tik_ID {  get; set; }

        [DisplayName("Nombre del Cliente")]
        public string per_NombreCompleto { get; set; }

        [DisplayName("Método de Pago")]
        public string meto_Descripcion { get; set; }

        [DisplayName("Subtotal")]
        public decimal tik_Subtotal { get; set; }

        [DisplayName("Descuento")]
        public decimal tik_Descuento { get; set; }

        [DisplayName("Impuesto (15%)")]
        public decimal tik_Impuesto { get; set; }

        [DisplayName("Monto Total")]
        public decimal tik_Total { get; set; }

    }
}
