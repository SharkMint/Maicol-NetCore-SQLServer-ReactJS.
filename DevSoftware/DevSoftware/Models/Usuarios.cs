using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevSoftware.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Genero { get; set; }
        public int Cedula { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public string SupervisorInmediato { get; set; }
    }
   
}
