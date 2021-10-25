using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext appDb;

        public ProducersController(AppDbContext _appDb)
        {
            appDb = _appDb;
        }

        public async Task<IActionResult> Index()
        {
            var producers = await appDb.Producers.ToListAsync();
            return View(producers);
        }
    }
}
