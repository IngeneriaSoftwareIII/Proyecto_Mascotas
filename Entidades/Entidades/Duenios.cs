using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades.Entidades
{
    public class Duenios
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public string Identificacion { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(150)]
        public string Apellidos { get; set; }
        [Required]
        [MaxLength(350)]
        public string Direccion { get; set; }
        [Required]
        [MaxLength(50)]
        public string Telefono { get; set; }

        public ICollection<Mascota> Mascota { get; set; }
    }
}
