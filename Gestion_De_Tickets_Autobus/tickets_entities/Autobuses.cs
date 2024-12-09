using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_Entities
{
    public class Autobuses
    {
        public int aut_Id { get; set; }
        public string aut_Matricula { get; set; }
        public int mar_ID { get; set; }
        public int mod_ID { get; set; }
        public bool aut_esVIP { get; set; }
        public int aut_cantAsientos { get; set; }
        public bool aut_Estado { get; set; }
        public int usu_UsuarioCreacion { get; set; }
        public DateTime aut_FechaCreacion { get; set; }
        public int usu_UsuarioModificacion { get; set; }
        public DateTime aut_FechaModificacion { get; set; }
        public string mod_Descripcion { get; internal set; }
        public string mar_Descripcion { get; internal set; }
    }
}
