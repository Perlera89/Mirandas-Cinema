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
        public async Task<IActionResult> Index()
        {
            var movies = await service.GetAll(n => n.Cinema);
            return View(movies);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchMovie)
        {
            var movies = await service.GetAll();

            if (!string.IsNullOrEmpty(searchMovie))
            {
                var filter = movies.Where(m => m.Name.Contains(searchMovie) 
                    || m.Description.Contains(searchMovie) 
                    || m.Cinema.Name.Contains(searchMovie) 
                    || m.Producer.FullName.Contains(searchMovie)).ToList();

                return View("Index", filter);
            }

            return View("Index", movies);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            /*========= cinco mejores =============*/
            var movies = await service.GetAll(n => n.Cinema);
            var cincoMejores = (from t in movies
                                orderby t.Id descending
                                select t).Take(5).ToList();
            ViewBag.peliculasRecientes = cincoMejores;

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
            return RedirectToAction(nameof(ControlMovies));
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
        public async Task<ActionResult> DeleteMovies(int Id_2)
        {
            await service.Delete(Id_2);
            return RedirectToAction(nameof(ControlMovies));
        }
    }
}
