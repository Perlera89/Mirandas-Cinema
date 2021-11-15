using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Correo electronico")]
        [Required(ErrorMessage = "El correo electronico es requerido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La Contraseña es requerida")]
        public string Password { get; set; }
    }
}
