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
        private readonly AppDbContext context;

        public MoviesController(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await context.Movies.Include(c => c.Cinema).OrderBy(c => c.Name).ToListAsync();
            return View(movies);
        }
    }
}
