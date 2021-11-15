using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.ViewModels
{
    public class MovieVM
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double Price { get; set; }

        [Display(Name = "URL de la magen")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ImagenURL { get; set; }

        [Display(Name = "Fecha de Inicio")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de finalización")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Selecciona una categoria")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public MovieCategory MovieCategory { get; set; }

        //Relaciones

        //Lista actores
        [Display(Name = "Selecciona los actores")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public List<int> Actors { get; set; }

        //Cinema
        [Display(Name = "Selecciona un cine")]
        [Required(ErrorMessage = "Este campo es obligatorio")]

        public int CinemaId { get; set; }

        //Producer
        [Display(Name = "Selecciona un productor")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int ProducerId { get; set; }
    }
}
