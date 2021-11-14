using Mirandas_Cinema.Data.Base;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mirandas_Cinema.Data.Repository
{
    public class MoviesRepository : EntityBaseRepository<Movie>, IMovies
    {
        public readonly AppDbContext dbContext;
        public MoviesRepository(AppDbContext _context) : base(_context)
        {
            this.dbContext = _context;
        }
        public new async Task<IEnumerable<Movie>> GetAll()
        {
            return await dbContext.Movies.Include(m => m.Cinema).Include(p => p.Producer).ToListAsync();
            
        }
        public new async Task<Movie> GetById(int id)
        {
           return  await dbContext.Movies.Where(x => x.Id == id).FirstOrDefaultAsync();
            
        }
        public new async Task Add(Movie entity)
        {
            await dbContext.Movies.AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }
        public new async Task Update(int id, Movie entity)
        {
            dbContext.Movies.Update(entity);
            await dbContext.SaveChangesAsync();
        }
        public new async Task Delete(int id)
        {
            var consulta = dbContext.Movies.Where(x => x.Id == id).FirstOrDefault();
            dbContext.Movies.Remove(consulta);
            await dbContext.SaveChangesAsync();
        }
        public new async Task Search(Movie entity)
        {

        }

        public async Task<List<Cinema>> ListOfCinema()
        {
            return await dbContext.Cinemas.ToListAsync();
        }

        public async Task<List<Producer>> ListOfProducer()
        {
            return await dbContext.Producers.ToListAsync();
        }
    }
}
