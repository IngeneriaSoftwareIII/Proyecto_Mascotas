using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entidades
{
    public class SolicitudVisitaDomiciliaria
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime FechaSolicitud { get; set; }
        [Required]
        public DateTime FechaCita { get; set; }

        [ForeignKey("Mascota")]
        [Required]
        public int IdMascota { get; set; }
        public Mascota Mascota { get; set; }

        [ForeignKey("Medico")]
        [Required]
        public string IdentificacionMedico { get; set; }
        public Medico Medico { get; set; }
    }
}
