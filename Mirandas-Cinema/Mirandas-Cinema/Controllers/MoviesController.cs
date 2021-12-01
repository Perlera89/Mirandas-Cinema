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
        private IMovies service;

        public MoviesController(AppDbContext _context, IMovies _service)
        {
            context = _context;
            service = _service;
        }

        public ActionResult ControlMovies()
        {
            var peliculas = service.GetMovies();
            return View(peliculas);
        }

        public ActionResult ControlMovie(int interruptor)
        {
            string url = "";
            if (interruptor == 0)
            {
                url = "/Movies/Create";
            }
            return Redirect(url);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(string searchInvalid, List<Movie> filter)
        {
            var movies = await service.GetAll(n => n.Cinema);
            FiltrarMoviesCaroucel(movies.ToList());

            //para no mostrar los caroucel si no hay resultados
            if (searchInvalid != null && filter.Count == 0)
            {
                movies = filter;
                ViewBag.searchInvalid = searchInvalid;
                FiltrarMoviesCaroucel(filter);

                return View(filter);
            }

            return View(movies);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchMovie)
        {
            var movies = await service.GetAll(n => n.Cinema, n => n.Producer);

            if (!string.IsNullOrEmpty(searchMovie))
            {
                //var filter = movies.Where(m => m.Name.ToLower().Contains(searchMovie.ToLower())
                //    || m.Description.ToLower().Contains(searchMovie.ToLower())
                //    || m.Producer.FullName.ToLower().Contains(searchMovie.ToLower())).ToList();

                var filter = movies.Where(m => string.Equals(m.Name, searchMovie,
                    StringComparison.CurrentCultureIgnoreCase) || string.Equals(m.Description, searchMovie,
                    StringComparison.CurrentCultureIgnoreCase) || string.Equals(m.Producer.FullName, searchMovie,
                    StringComparison.CurrentCultureIgnoreCase)).ToList();

                FiltrarMoviesCaroucel(filter);

                if (filter.Count == 0)
                {
                    await Index("No se encontraron resultados...", filter);
                }

                return View("Index", filter);
            }
            return View("Index", movies);
        }

        //Categorias del menu

        [AllowAnonymous]
        public async Task<IActionResult> Categorias(string categoria)
        {
            var movies = await service.GetAll(n => n.Cinema, n => n.Producer);

            //Accion
            if (!categoria.Equals(""))
            {
                var filter = movies.Where(m => m.MovieCategory.GetHashCode()==Convert.ToInt32(categoria)).ToList();

                FiltrarMoviesCaroucel(filter);

                if (filter.Count == 0)
                {
                    await Index("No se encontraron resultados...", filter);
                }

                return View("Index", filter);
            }
            return View("Index", movies);
        }

        //metodo para hacer un filtro en los carouceles y no mostrarlos si en un caroucel no hay peliculas
        public void FiltrarMoviesCaroucel(List<Movie> filter)
        {
            ViewBag.EnCines = false;
            var consulta1 = (from t in filter
                             where DateTime.Now >= t.StartDate && DateTime.Now <= t.EndDate
                             select t).ToList();

            ViewBag.Expiraron = false;
            var consulta2 = (from t in filter
                             where DateTime.Now > t.StartDate && DateTime.Now > t.EndDate
                             select t).ToList();

            ViewBag.FuturosEstrenos = false;
            var consulta3 = (from t in filter
                             where DateTime.Now < t.StartDate
                             select t).ToList();
            if (consulta1.Count > 0)
            {
                ViewBag.EnCines = true;
            }
            if (consulta2.Count > 0)
            {
                ViewBag.Expiraron = true;
            }
            if (consulta3.Count > 0)
            {
                ViewBag.FuturosEstrenos = true;
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            /*========= cinco mejores =============*/
            var movies = await service.GetAll(n => n.Cinema);
            var cuatroRecientes = (from t in movies
                                   orderby t.Id descending
                                   select t).Take(4).ToList();
            ViewBag.peliculasRecientes = cuatroRecientes;
            var seisRecientes = (from t in movies
                                 orderby t.Id descending
                                 select t).Take(6).ToList();
            ViewBag.peliculasRecientes2 = seisRecientes;

            var details = await service.GetMovieById(id);

            return View(details);
        }

        public async Task<IActionResult> Create()
        {
            var movieDropdown = await service.GetMovieDropDown();

            ViewBag.cinemas = new SelectList(movieDropdown.Cinemas, "Id", "Name");
            ViewBag.producers = new SelectList(movieDropdown.Producers, "Id", "FullName");
            ViewBag.actors = new SelectList(movieDropdown.Actors, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                var movieDropdown = await service.GetMovieDropDown();

                ViewBag.cinemas = new SelectList(movieDropdown.Cinemas, "Id", "Name");
                ViewBag.producers = new SelectList(movieDropdown.Producers, "Id", "FullName");
                ViewBag.actors = new SelectList(movieDropdown.Actors, "Id", "FullName");

                return View(movie);
            }

            await service.AddMovie(movie);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var movie = await service.GetMovieById(id);
            if (movie == null)
                return View("NotFound");

            var response = new MovieVM()
            {
                Id = movie.Id,
                Name = movie.Name,
                Description = movie.Description,
                Price = movie.Price,
                ImagenURL = movie.ImagenURL,
                MovieCategory = movie.MovieCategory,
                StartDate = movie.StartDate,
                EndDate = movie.EndDate,
                CinemaId = movie.CinemaId,
                ProducerId = movie.ProducerId,
                Actors = movie.Actors_Movies.Select(m => m.ActorId).ToList()
            };

            var movieDropdown = await service.GetMovieDropDown();

            ViewBag.cinemas = new SelectList(movieDropdown.Cinemas, "Id", "Name");
            ViewBag.producers = new SelectList(movieDropdown.Producers, "Id", "FullName");
            ViewBag.actors = new SelectList(movieDropdown.Actors, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, MovieVM movie)
        {
            if(id != movie.Id)
                return View("NotFound");

            if (!ModelState.IsValid)
            {
                var movieDropdown = await service.GetMovieDropDown();

                ViewBag.cinemas = new SelectList(movieDropdown.Cinemas, "Id", "Name");
                ViewBag.producers = new SelectList(movieDropdown.Producers, "Id", "FullName");
                ViewBag.actors = new SelectList(movieDropdown.Actors, "Id", "FullName");

                return View(movie);
            }

            await service.UpdateMovie(movie);
            return RedirectToAction(nameof(ControlMovies));
        }
        public async Task<ActionResult> DeleteMovies(int id)
        {
            await service.Delete(id);
            return RedirectToAction(nameof(ControlMovies));
        }
    }
}
