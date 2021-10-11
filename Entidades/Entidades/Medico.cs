using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entidades.Entidades
{
    public class Medico
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
        [MaxLength(50)]
        public string Telefono { get; set; }
        [Required]
        [MaxLength(50)]
        public string TarjetaProfesional { get; set; }

        [ForeignKey("Veterinaria")]
        [Required]
        public int IdVeterinaria { get; set; }
        public Veterinaria Veterinaria { get; set; }
        // especialización de tipo de animal(gatos, Perros, Pájaro), o los 3.
        public ICollection<TipoAnimal> TiposEspecializacion { get; set; }
    }
}
