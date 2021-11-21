using Mirandas_Cinema.Data.Base;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Repository
{
    public class CinemaRepository : EntityBaseRepository<Cinema>, ICinema
    {
        public CinemaRepository(AppDbContext _context) : base(_context)
        {

        }
    }
}
