using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Models
{
    public class Profesor
    {
        [Required]
        public int id_profesor { get; set; }
        [Required]
        public int id_departamento { get; set; }
    }
}
