using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Models
{
    public class CursoEscolar
    {
        [Required]
        public int id { get; set; }

        [Required]
        public int ano_inicio { get; set; }

        [Required]
        public int ano_fin { get; set; }
    }
}
