using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades.Entidades
{
    public class Veterinaria
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(50)]
        public string NIT { get; set; }
        [Required]
        [MaxLength(350)]
        public string dirección { get; set; }
        public ICollection<Medico> medicos { get; set; }

    }
}
