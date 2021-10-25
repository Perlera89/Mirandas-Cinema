using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Foto de perfil")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nombre")]
        public string FullName { get; set; }

        [Display(Name = "Biografia")]
        public string Bio { get; set; }

        //Relaciones
        public List<Movie> Movies { get; set; }
    }
}
