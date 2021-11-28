using Mirandas_Cinema.Data.Base;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data.ViewModels;

namespace Mirandas_Cinema.Data.Repository
{
    public class MoviesRepository : EntityBaseRepository<Movie>, IMovies
    {
        public readonly AppDbContext context;

        public MoviesRepository(AppDbContext _context) : base(_context)
        {
            context  = _context;
        }

        Movie movies = new Movie();
        public List<Movie> GetMovies()
        {
            var movies = context.Movies.Include(p => p.Producer).Include(c => c.Cinema).ToList();
            //var seleccionDatos = (from t in movies
            //             select new
            //             {
            //                 t.Id,
            //                 t.Name,
            //                 t.Description,
            //                 Cinemas = t.Cinema.Name,
            //                 Producers = t.Producer.FullName,
            //                 t.Price,
            //                 t.MovieCategory,
            //                 t.StartDate,
            //                 t.EndDate,
            //                 t.ImagenURL
            //             }).ToList();
            return movies;
        }

        public async Task AddMovie(MovieVM data)
        {
            var newMovie = new Movie()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImagenURL = data.ImagenURL,
                CinemaId = data.CinemaId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                MovieCategory = data.MovieCategory,
                ProducerId = data.ProducerId
            };

            await context.Movies.AddAsync(newMovie);
            await context.SaveChangesAsync();

            //Actores
            foreach (var actorId in data.Actors)
            {
                var actors = new Actor_Movie()
                {
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };

                await context.Actors_Movies.AddAsync(actors);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Movie> GetMovieById(int id)
        {
            var details = await context.Movies
                .Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actors_Movies)
                .ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(m => m.Id == id);
            return details;
        }

        public async Task<DropDownListVM> GetMovieDropDown()
        {
            var response = new DropDownListVM()
            {
                Actors = await context.Actors.OrderBy(n => n.FullName).ToListAsync(),
                Producers = await context.Producers.OrderBy(n => n.FullName).ToListAsync(),
                Cinemas = await context.Cinemas.OrderBy(c => c.Name).ToListAsync()
            };

            return response;
        }

        public async Task UpdateMovie(MovieVM data)
        { 
            var getMovie = await context.Movies.FirstOrDefaultAsync(m => m.Id == data.Id);

            if(getMovie != null)
            {
                getMovie.Name = data.Name;
                getMovie.Description = data.Description;
                getMovie.Price = data.Price;
                getMovie.ImagenURL = data.ImagenURL;
                getMovie.CinemaId = data.CinemaId;
                getMovie.StartDate = data.StartDate;
                getMovie.EndDate = data.EndDate;
                getMovie.MovieCategory = data.MovieCategory;    
                getMovie.ProducerId = data.ProducerId;

                await context.SaveChangesAsync();
            }

            //Eliminar si existe el actor
            var existActor = context.Actors_Movies.Where(m => m.MovieId == data.Id).ToList();
            context.Actors_Movies.RemoveRange(existActor);

            await context.SaveChangesAsync();

            //Actores
            foreach (var actorId in data.Actors)
            {
                var actors = new Actor_Movie()
                {
                    MovieId = data.Id,
                    ActorId = actorId
                };

                await context.Actors_Movies.AddAsync(actors);
                await context.SaveChangesAsync();
            }
        }

    }
}