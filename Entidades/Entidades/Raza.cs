﻿using System.ComponentModel.DataAnnotations;

namespace Entidades.Entidades
{
    public class Raza
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }
    }
}
