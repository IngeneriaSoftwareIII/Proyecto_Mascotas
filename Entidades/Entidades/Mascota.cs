using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entidades
{
    public class Mascota
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(100)]
        public string ColorOjos { get; set; }
        [Required]
        [MaxLength(100)]
        public string ColorPiel { get; set; }
        [Required]
        public float Estatura { get; set; }
      
        [ForeignKey("Raza")]
        [Required]
        public int IdRaza { get; set; }
        public Raza Raza { get; set; }

        [ForeignKey("TipoAnimal")]
        [Required] 
        public int IdTipoAnimal { get; set; }
        public TipoAnimal TipoAnimal { get; set; }

        [ForeignKey("Duenios")]
        [Required]
        public string IdentificacionDuenios { get; set; }
        public Duenios Duenios { get; set; }
    }
}
