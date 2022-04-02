using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Models
{
    public class Asignatura
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public double creditos { get; set; }
        [Required]
        public string tipo { get; set; }
        [Required]
        public int curso { get; set; }
        [Required]
        public int cuatrimestre { get; set; }
        [Required]
        public int id_profesor { get; set; }
        [Required]
        public int id_grado { get; set; }
    }
}
