using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Services
{
    public interface IActors
    {
        Task<IEnumerable<Actor>> GetActors();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
