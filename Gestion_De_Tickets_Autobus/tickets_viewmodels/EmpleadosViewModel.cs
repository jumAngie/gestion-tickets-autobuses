﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_De_Tickets_Autobus.Tickets_ViewModels
{
    public class EmpleadosViewModel
    {

        [DisplayName("Nombre Completo")]
        public string NombreCompleto { get; set; }

        [DisplayName("DNI Cliente")]
        public string DNI { get; set; }

        [DisplayName("Telefono")]
        public string Telefono { get; set; }

        [DisplayName("Correo")]
        public string Correo { get; set; }

        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Sexo")]
        public string Sexo_Descripcion { get; set; }

        [DisplayName("Ciudad")]
        public string Ciud_Descripcion { get; set; }
       

        [DisplayName("Departamnto")]
        public string Dept_Descripcion { get; set; }

        [DisplayName("Pais")]
        public string Pais_Descripcion { get; set; }


        [DisplayName("Direccion")]
        public string Direccion { get; set; }


    }
}