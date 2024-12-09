using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_ViewModels
{
    public class DatosUsuarioViewModel
    {
        public int usu_Id { get; set; }
        public string usu_Usuario { get; set; }
        public int per_ID { get; set; }
        public string per_NombreCompleto { get; set; }
        public string per_Correo { get; set; }
        public string rol_Descripcion { get; set; }
        public int rol_Id { get; set; }
        public int sex_Id { get; set; }
    }
}
