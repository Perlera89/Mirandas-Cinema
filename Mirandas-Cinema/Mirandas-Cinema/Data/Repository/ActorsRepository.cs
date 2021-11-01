using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mirandas_Cinema.Models;
using Mirandas_Cinema.Data.Services;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data.Base;

namespace Mirandas_Cinema.Data.Repository
{
    public class ActorsRepository : EntityRepository<Actor>, IActors
    {
        public ActorsRepository(AppDbContext _context) : base(_context)
        {
        }
    }
}
