using Mirandas_Cinema.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Models
{
    public class Producer : IBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de perfil")]
        [Required(ErrorMessage = "La foto de perfil es requirida.")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "La nombre es requirida.")]
        public string FullName { get; set; }

        [Display(Name = "Biografia")]
        [Required(ErrorMessage = "La biografia es requirida.")]
        public string Bio { get; set; }



        //Relaciones
        public List<Movie> Movies { get; set; }

    }
}
