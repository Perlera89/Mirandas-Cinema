using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext appDb;

        public MoviesController(AppDbContext _appDb)
        {
            appDb = _appDb;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await appDb.Movies.Include(c => c.Cinema).ToListAsync();
            return View(movies);
        }
    }
}
