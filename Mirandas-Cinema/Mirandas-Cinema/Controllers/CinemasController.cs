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
    public class CinemasController : Controller
    {
        private readonly ICinema icinema; 

        public CinemasController(ICinema _cinema)
        {
            icinema = _cinema;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var cinemas = await icinema.GetAll();
            return View(cinemas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo, Name, Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            else
            {
                await icinema.Add(cinema);
                return RedirectToAction(nameof(Index));
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var details = await icinema.GetById(id);

            if(details == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(details);
            }
        }
        public async Task<IActionResult> Update(int id)
        {
            var updateDetails = await icinema.GetById(id);

            if (updateDetails == null)
            {
                return View("NotFound");
            }
            else
            {
                return View(updateDetails);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id,[Bind("Id, Logo, Name, Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            else
            {
                await icinema.Update(id, cinema);
                return RedirectToAction(nameof(Index));
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            var deleteDetails = await icinema.GetById(id);
            if (deleteDetails == null)
                return View("NoyFound");
            else
                return View(deleteDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var delete = await icinema.GetById(id);
            if (delete == null) return View("NotFound");

            await icinema.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }


}
