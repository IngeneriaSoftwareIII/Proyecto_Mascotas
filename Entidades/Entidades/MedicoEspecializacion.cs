using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entidades
{
    public class MedicoEspecializacion
    {
        [ForeignKey("Medico")]
        [Required]
        public string IdentificacionMedico { get; set; }
        public Medico Medico { get; set; }

        [ForeignKey("TipoAnimal")]
        [Required]
        public int IdTipoAnimal { get; set; }
        public TipoAnimal TipoAnimal { get; set; }
    }
}
