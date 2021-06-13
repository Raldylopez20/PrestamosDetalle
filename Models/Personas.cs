using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PrestamosDetalle.Models.Validaciones;
using System.ComponentModel.DataAnnotations;

namespace PrestamosDetalle.Models
{
    public class Personas
    {

        [Key]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombres { get; set; }

        [CedulaV]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;

        public double Balance { get; set; }

    }
}
