using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActors service;

        public  ActorsController(IActors _service)
        {
            service = _service;
        }

        public async Task<IActionResult> Index()
        {
            var actors = await service.GetActors();
            return View(actors);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, FullName, Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            else
            {
                service.Add(actor);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
