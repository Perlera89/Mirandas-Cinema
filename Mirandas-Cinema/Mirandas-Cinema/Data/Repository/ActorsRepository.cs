using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mirandas_Cinema.Models;
using Mirandas_Cinema.Data.Services;
using Microsoft.EntityFrameworkCore;

namespace Mirandas_Cinema.Data.Repository
{
    public class ActorsRepository : IActors
    {
        private readonly AppDbContext context;

        public ActorsRepository(AppDbContext _context)
        {
            context = _context;
        }

        public void Add(Actor actor)
        {
            context.Actors.Add(actor);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetActors()
        {
            var actors = await context.Actors.ToListAsync();
            return actors;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
