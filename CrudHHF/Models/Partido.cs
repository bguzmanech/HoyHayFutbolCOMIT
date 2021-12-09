using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHHF.Models
{
    public class Partido
    {
        [Key]
        public int ID { get; set; }

        //[Required(ErrorMessage ="Se necesita un nombre para el partido")]
        [StringLength(50, ErrorMessage ="El {0} debe ser al menos {2} y máximo {1} caracteres", MinimumLength = 3)]
        
        public string Nombre { get; set; }
        public string Complejo { get; set; }

        //[Required(ErrorMessage = "El precio es obligatorio")]
        [Display(Name = "Precio Total")]
        public int PrecioTotal { get; set; }

        [Display(Name = "Fecha del partido")]
        public DateTime FechaPartido { get; set; }
        public string Genero { get; set; }

        [Display(Name = "Tipo de partido")]
        public string TipoPartido { get; set; }

        [Display(Name = "Tipo de techo")]
        public string TipoTecho { get; set; }

        [Display(Name = "Tipo de piso")]
        public string TipoPiso { get; set; }

        [Display(Name = "Rango de edad")]
        public int RangoEtario { get; set; }
    }
}
