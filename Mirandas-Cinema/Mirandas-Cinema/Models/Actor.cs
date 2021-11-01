using Mirandas_Cinema.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Models
{
    public class Actor : IBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de perfil")]
        [Required(ErrorMessage = "La foto de perfil es requerida")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre completo es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 50 catacteres")]
        public string FullName { get; set; }

        [Display(Name = "Biografia")]
        [Required(ErrorMessage = "La biografia es requerida")]
        public string Bio { get; set; }

        //Relaciones
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
