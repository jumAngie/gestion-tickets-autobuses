using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_ViewModels
{
    public class DatosUsuarioViewModel
    {
        public int usua_Id { get; set; }
        public string usua_Usuario { get; set; }
        public int dato_Id { get; set; }
        public string dato_NombreCompleto { get; set; }
        public string dato_email { get; set; }
        public string role_Descripcion { get; set; }
        public int role_Id { get; set; }
        public int sexo_Id { get; set; }
    }
}
