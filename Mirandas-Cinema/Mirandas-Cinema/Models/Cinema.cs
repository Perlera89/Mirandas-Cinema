using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Logo")]
        public string Logo { get; set; }

        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        //Relaciones
        public List<Movie> Movies { get; set; }
    }
}
