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
                await service.Add(actor);
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> Details(int id)
        {
            var details = await service.GetById(id);

            if (details == null) 
                return View("NotFound");
            else
                return View(details);
        }

        public async Task<IActionResult> Update(int id)
        {
            var updateDetails = await service.GetById(id);

            if (updateDetails == null)
                return View("NotFound");
            else
                return View(updateDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, [Bind("Id, ProfilePictureURL, FullName, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            else
            {
                await service.Update(id, actor);
                return RedirectToAction(nameof(Index));
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteDetails = await service.GetById(id);

            if (deleteDetails == null)
                return View("NotFound");
            else
                return View(deleteDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actor = await service.GetById(id);
            if (actor == null) return View("Error");

            await service.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
