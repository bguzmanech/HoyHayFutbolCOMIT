using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHHF.Models
{
    
        public abstract class Persona : EntityBase
        {
            [Required]
            public string Nombre { get; set; }

            [Required]
            public string Apellido { get; set; }
        }
    
}
