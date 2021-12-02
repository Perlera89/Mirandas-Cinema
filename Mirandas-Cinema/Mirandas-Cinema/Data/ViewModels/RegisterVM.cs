using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Nombre completo")]
        [MinLength(4, ErrorMessage = " El mínimo de caracteres es 4 ")]
        [MaxLength(50, ErrorMessage = " El máximo de caracteres es 50 ")]
        [Required(ErrorMessage = "El nombre completo es requerido")]
        public string FullName { get; set; }

        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "El correo electronico es requerido")]
        [RegularExpression(@"^[_a-z0-9-]+(.[_a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)(.[a-z]{2,4})$", ErrorMessage = "Correo incorrecto")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Mínimo ocho caracteres, al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La Contraseña es requerida")]
        public string Password { get; set; }

        [Display(Name = "Confirmar contraseña")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La confirmacion es requerida")]
        [Compare("Password", ErrorMessage = "La contraseña no coincide")]
        public string ConfirmPassword { get; set; }
    }
}
