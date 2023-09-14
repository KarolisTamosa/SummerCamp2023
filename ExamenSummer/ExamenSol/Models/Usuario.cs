using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Usuario
    {
        [Key]
        public string? Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El campo Nombre no puede tener más de 50 caracteres.")]
        public string? Nombre { get; set; }

        [StringLength(25, ErrorMessage = "El campo Telefono no puede tener más de 25 caracteres.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio.")]
        public DateTime? FechaNacimiento { get; set; }
    }
}