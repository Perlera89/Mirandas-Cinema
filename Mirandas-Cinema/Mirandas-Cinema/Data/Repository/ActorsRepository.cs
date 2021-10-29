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

        public async Task Add(Actor actor)
        {
            await context.Actors.AddAsync(actor);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var actor = await context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            context.Actors.Remove(actor);
            await context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Actor>> GetActors()
        {
            var actors = await context.Actors.ToListAsync();
            return actors;
        }

        public async Task<Actor> GetById(int id)
        {
            var actor = await context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return actor;
        }

        public async Task<Actor> Update(int id, Actor newActor)
        {
            context.Update(newActor);
            await context.SaveChangesAsync();
            return newActor;
        }
    }
}
