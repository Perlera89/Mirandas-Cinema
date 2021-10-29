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
        Task<Actor> GetById(int id);
        Task Add(Actor actor);
        Task<Actor> Update(int id, Actor newActor);
        Taks Delete(int id);
    }
}
