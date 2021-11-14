using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.ViewModels
{
    public class MovieViewModel
    {

        [Display(Name = "Id:")]
        public int Id { get; set; }

        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Descripción:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Description { get; set; }

        [Display(Name = "Precio:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public double Price { get; set; }

        [Display(Name = "Imagen:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string ImagenURL { get; set; }

        [Display(Name = "Fecha de Inicio:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de finalización:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Categoria:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public MovieCategory MovieCategory { get; set; }

        //Relaciones
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        [Display(Name = "Cine:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        [Display(Name = "Productor:")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

        public MovieViewModel(Movie _movie)
        {
            Id = _movie.Id;
            Name = _movie.Name;
            Description = _movie.Description;
            Price = _movie.Price;
            ImagenURL = _movie.ImagenURL;
            StartDate = _movie.StartDate;
            EndDate = _movie.EndDate;
            MovieCategory = _movie.MovieCategory;
            Actors_Movies = _movie.Actors_Movies;
            CinemaId = _movie.CinemaId;
            Cinema = _movie.Cinema;
            ProducerId = _movie.ProducerId;
            Producer = _movie.Producer;
        }

        public MovieViewModel()
        {

        }
    }
}
