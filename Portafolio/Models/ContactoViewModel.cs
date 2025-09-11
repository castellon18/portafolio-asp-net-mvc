using System.ComponentModel.DataAnnotations;

namespace Portafolio.Models
{
    public class ContactoViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo {0} es requerido.")]
        [StringLength(30, ErrorMessage = "Los {0} no pueden exceder los {2} caracteres.")]
        public string Nombres { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo {0} es requerido.")]
        [StringLength(30, ErrorMessage = "Los {0} no pueden exceder los {2} caracteres.")]
        public string Apellidos { get; set; } = string.Empty;
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo {0} es requerido.")]
        [RegularExpression(@"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$", ErrorMessage = "El formato de correo no es valido.")]
        [EmailAddress(ErrorMessage = @"Por favor ingrese una dirección de correo valida")]
        public string Email { get; set; } = string.Empty;
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Campo {0} es requerido.")]
        public string Mensaje { get; set; } = string.Empty;
    }
}
