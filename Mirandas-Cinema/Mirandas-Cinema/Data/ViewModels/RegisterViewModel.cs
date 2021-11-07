using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage = "El nombre completo es requerido")]
        public string FullName { get; set; }

        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "El correo electronico es requerido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
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
