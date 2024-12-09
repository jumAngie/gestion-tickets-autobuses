using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_Entities
{
    public class Personas
    {
        public int per_Id { get; set; }
        public string per_NombreCompleto { get; set; }
        public string per_DNI { get; set; }
        public string per_Telefono { get; set; }
        public string per_Correo { get; set; }
        public DateTime per_FechaNacimiento { get; set; }
        public int per_Sexo { get; set; }
        public int per_Cargo { get; set; }
        public int per_Ciudad { get; set; }

        public string per_Direccion { get; set; }
        public int usu_UsuarioCreacion { get; set; }
        public DateTime per_FechaCreacion { get; set; }
        public int usu_UsuarioModificacion { get; set; }
        public DateTime per_FechaModificacion { get; set; }
        public bool per_Estado { get; set; }

        [NotMapped]
        public int dept_Id { get; set; }

        [NotMapped]
        public int pais_Id { get; set; }
        public bool per_Extranjero { get; set; }

        public bool per_existencias { get; set; }
    }
}
