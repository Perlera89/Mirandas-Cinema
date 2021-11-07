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
    public class CinemasController : Controller
    {
        private readonly AppDbContext appDb;

        public CinemasController(AppDbContext _appDb)
        {
            appDb = _appDb;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var cinemas = await appDb.Cinemas.ToListAsync();
            return View(cinemas);
        }
    }
}
