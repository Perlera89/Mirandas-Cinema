using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Data.Static;
using Mirandas_Cinema.Data.ViewModels;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class MoviesController : Controller
    {
        private readonly AppDbContext context;
        private IMovies imovies;

        public MoviesController(AppDbContext _context, IMovies _imovies)
        {
            context = _context;
            this.imovies = _imovies;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var movies = await context.Movies.Include(c => c.Cinema).OrderBy(c => c.Name).ToListAsync();
            return View(movies);
        }

        //Tabla-Vista Principal===================================================//
        public async Task<IActionResult> Details()
        {
            //cargar los datos a la vista
            var listaMovies = await imovies.GetAll();

            return View(listaMovies);
        }

        //Formulario===============================================//
        //metodos para llenar los combobox
        //cines
        private async Task ListaComboCinesAsync()
        {
            var comboCinema = await imovies.ListOfCinema();
            List<SelectListItem> lista = new List<SelectListItem>();
            foreach (var i in comboCinema)
            {
                lista.Add(
                    new SelectListItem
                    {
                        Text = i.Name,
                        Value = Convert.ToString(i.Id)
                    }
                    );

                ViewBag.cines = lista;
            }
        }
        //productores
        public async Task ListaComboProducerAsync()
        {
            var comboProducer = await imovies.ListOfProducer();
            List<SelectListItem> lista_2 = new List<SelectListItem>();
            foreach (var i in comboProducer)
            {
                lista_2.Add(
                    new SelectListItem
                    {
                        Text = i.FullName,
                        Value = Convert.ToString(i.Id)
                    }
                    );
                ViewBag.producer = lista_2;
            }
        }

        public async Task<IActionResult> GestionMovies(int interruptor, int id)
        {
            //combobox cines
            await ListaComboCinesAsync();
            //combobox productores
            /*=================================================*/
            await ListaComboProducerAsync();

            //verificar si el formulario sera para agregar o actualizar
            if (interruptor == 1)
            {
                var actualizarPorId = await imovies.GetById(id);
                ViewBag.codigo = actualizarPorId.Id;
                ViewBag.interruptor = 1;

                MovieViewModel ListaById = MovieToMovieViewModel(actualizarPorId);
                /*==================================*/
                return View("GestionMovies", ListaById);
            }
            else
            {
                ViewBag.IdAdd = 0;
                ViewBag.interruptor = 0;
                return View();
            }


            
        }
        //guardar o actualizar
        [HttpPost]
        public async Task<IActionResult> MoviesAsync(MovieViewModel _movieViewModel)
        {
            //si id=0 ==> guardar
            //si id!=0 ==> actualizar
            Movie movie = MovieViewModelToMovie(_movieViewModel);
            int id = movie.Id;
            if (ModelState.IsValid == true)
            {
                if (!id.Equals(0))
                {
                    await imovies.Update(id, movie);
                    return Redirect("/Movies/Details");
                }
                else
                {
                   await imovies.Add(movie);
                    return Redirect("/Movies/Details");
                }

            }
            else
            {
                await ListaComboCinesAsync();
                await ListaComboProducerAsync();
                if (!id.Equals(0))
                {
                    ViewBag.codigo = _movieViewModel.Id;
                    ViewBag.interruptor = 1;
                }
                else
                {
                    ViewBag.interruptor = 0;
                    ViewBag.IdAdd = 0;
                }
                return View("GestionMovies", _movieViewModel);
            }

        }
        //borrado
        public async Task<IActionResult> DeleteMoviesAsync(int Id_2)
        {
            if (!Id_2.Equals(null))
            {
                await imovies.Delete(Id_2);
                return Redirect("/Movies/Details");
            }
            else
            {
                return View("NotFound");
            }


        }

        //pasar de ViewModel a Movie
        public Movie MovieViewModelToMovie(MovieViewModel _movieViewModel)
        {
            Movie movie = new Movie();
            movie.Id = _movieViewModel.Id;
            movie.Actors_Movies = _movieViewModel.Actors_Movies;
            movie.Cinema = _movieViewModel.Cinema;
            movie.CinemaId = _movieViewModel.CinemaId;
            movie.Name = _movieViewModel.Name;
            movie.ImagenURL = _movieViewModel.ImagenURL;
            movie.Description = _movieViewModel.Description;
            movie.EndDate = _movieViewModel.EndDate;
            movie.MovieCategory = _movieViewModel.MovieCategory;
            movie.Producer = _movieViewModel.Producer;
            movie.ProducerId = _movieViewModel.ProducerId;
            movie.Price = _movieViewModel.Price;
            movie.StartDate = _movieViewModel.StartDate;

            return movie;
        }
        //pasar de Movie a ViewModel 
        public MovieViewModel MovieToMovieViewModel(Movie _movie)
        {
            MovieViewModel movieViewModel = new MovieViewModel();
            movieViewModel.Id = _movie.Id;
            movieViewModel.Actors_Movies = _movie.Actors_Movies;
            movieViewModel.Cinema = _movie.Cinema;
            movieViewModel.CinemaId = _movie.CinemaId;
            movieViewModel.Name = _movie.Name;
            movieViewModel.ImagenURL = _movie.ImagenURL;
            movieViewModel.Description = _movie.Description;
            movieViewModel.EndDate = _movie.EndDate;
            movieViewModel.MovieCategory = _movie.MovieCategory;
            movieViewModel.Producer = _movie.Producer;
            movieViewModel.ProducerId = _movie.ProducerId;
            movieViewModel.Price = _movie.Price;
            movieViewModel.StartDate = _movie.StartDate;

            return movieViewModel;
        }

    }
}
