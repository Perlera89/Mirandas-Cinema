using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Data.Static;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProducersController : Controller
    {
        private readonly IProducer iproducers;

        public ProducersController(IProducer _producers)
        {
            iproducers = _producers;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var cinemas = await iproducers.GetAll();
            return View(cinemas);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteDetails = await iproducers.GetById(id);
            if (deleteDetails == null)
                return View("NoyFound");
            else
                return View(deleteDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var delete = await iproducers.GetById(id);
            if (delete == null) return View("NotFound");

            await iproducers.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL, FullName, Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            else
            {
                await iproducers.Add(producer);
                return RedirectToAction(nameof(Index));
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var details = await iproducers.GetById(id);

            if (details == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(details);
            }

        }

        public async Task<IActionResult> Edits(int id)
        {

            var updateDetails = await iproducers.GetById(id);

            if (updateDetails == null)
                return View("NotFound");
            else
                return View(updateDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edits(int id, [Bind("Id, ProfilePictureURL, FullName, Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }

            else
            {
                await iproducers.Update(id, producer);
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
