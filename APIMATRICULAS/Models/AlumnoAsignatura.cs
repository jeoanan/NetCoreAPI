using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Models
{
    public class AlumnoAsignatura
    {
        [Required]
        public int id_alumno { get; set; }
        [Required]
        public int id_asignatura { get; set; }
        [Required]
        public int id_curso_escolar { get; set; }
        
    }
}
