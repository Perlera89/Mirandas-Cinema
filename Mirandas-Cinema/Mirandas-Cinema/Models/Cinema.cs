using Mirandas_Cinema.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Models
{
    public class Cinema : IBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        [Required(ErrorMessage ="El logo es necesario")]
        public string Logo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="El nombre es necesario")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="El nombre debe tener entre 3 y 50 caracteres")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage ="La descrpcion es necesaria")]
        public string Description { get; set; }

        //Relaciones
        public List<Movie> Movies { get; set; }
    }
}
