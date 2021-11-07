using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data;
using Mirandas_Cinema.Data.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProducersController : Controller
    {
        private readonly AppDbContext appDb;

        public ProducersController(AppDbContext _appDb)
        {
            appDb = _appDb;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var producers = await appDb.Producers.ToListAsync();
            return View(producers);
        }

        [AllowAnonymous]
        public IActionResult prueba()
        {
            return View();
        }
    }
}
