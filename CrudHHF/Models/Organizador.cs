using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudHHF.Models
{
    public class Organizador
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="El nombre del torneo es obligatorio")]
        [Display(Name ="Nombre del torneo")]
        public string NombreTorneo { get; set; }

        [Required(ErrorMessage = "El nombre del complejo es obligatorio")]
        [Display(Name = "Complejo")]
        public string NombreComplejo { get; set; }

        [Required(ErrorMessage = "La dirección del complejo es obligatoria")]
        [Display(Name = "Dirección del complejo")]
        public string DireccionComplejo { get; set; }

        [Required(ErrorMessage = "La localidad del complejo es obligatoria")]
        [Display(Name = "Localidad del complejo")]
        public string LocalidadComplejo { get; set; }

        [Required(ErrorMessage = "El precio por equipo es obligatorio")]
        [Display(Name = "Precio por equipo")]
        public int PrecioPorEquipo { get; set; }

        [Required(ErrorMessage = "La fecha del torneo es obligatoria")]
        [Display(Name = "Fecha del torneo")]
        [DataType(DataType.Date)]
        public DateTime FechaDelTorneo { get; set; }

        [Required(ErrorMessage = "La modalidad del torneo es obligatoria")]
        [Display(Name = "Modalidad de torneo")]
        public string ModalidadDePartido { get; set; }

        [Required(ErrorMessage = "El genero del torneo es obligatorio")]
        public string Genero { get; set; }

        

    }
}
