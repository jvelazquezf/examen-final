using System.ComponentModel.DataAnnotations;

namespace ExamenFinal.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string? Nombres { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(25)]
        public string? Apellidos { get; set; }
        [Required]
        [MaxLength(10)]
        public string? Documento { get; set; }
        [Required]
        public string? Telefono { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? FechaNacimiento { get; set; }
        [Required]
        public string? Ciudad { get; set; }
        [Required]
        public string? Nacionalidad { get; set; }
        [Required]
        public string? Cargo { get; set; }
        [Required]
        public string? Antiguedad { get; set; }

    }
}
