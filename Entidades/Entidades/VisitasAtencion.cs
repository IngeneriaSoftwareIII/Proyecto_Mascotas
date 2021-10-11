using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entidades
{
    public class VisitasAtencion
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public bool Domiciliaria { get; set; }
        [Required]
        public float Temperatura { get; set; }
        [Required]
        public float Peso { get; set; }
        [Required]
        public int FrecuenciaRespiratoria { get; set; }
        [Required]
        public int FrecuenciaCardiaca { get; set; }
        [Required]
        [MaxLength(500)]
        public string EstadoAnimo { get; set; }
        [Required]
        public DateTime Fechavisita { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Recomendaciones { get; set; }//(incluyendo medicamentos formulados en caso de que se requiera, lo cual se diligencia en un cuadro de texto).
        [MaxLength(500)]
        public string DireccionVisita { get; set; }

        [ForeignKey("Veterinaria")]
        [Required]
        public int IdVeterinaria { get; set; }
        public Veterinaria Veterinaria { get; set; }

        [ForeignKey("Mascota")]
        [Required]
        public int IdMascota { get; set; }
        public Mascota Mascota { get; set; }

        [ForeignKey("Medico")]
        [Required]
        public string IdentificacionMedico { get; set; }
        public Medico Medico { get; set; }

        [ForeignKey("SolicitudVisitaDomiciliaria")]
        public int? IdSolicitud { get; set; }
        public SolicitudVisitaDomiciliaria Solicitud { get; set; }
    }
}
