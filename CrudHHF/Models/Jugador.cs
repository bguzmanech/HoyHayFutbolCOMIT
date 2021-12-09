using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHHF.Models
{
    public class Jugador : Persona
    {
        [Required]
        public int NumeroDocumento { get; set; }
        
        [Required]
        public DateTime FechaNacimiento { get; set; }
        
        [Required]
        public int Genero { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [DefaultValue("0000000")]
        public string Celular { get; set; }



    }
}
