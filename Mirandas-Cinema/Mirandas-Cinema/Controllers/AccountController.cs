using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data;
using Mirandas_Cinema.Data.Static;
using Mirandas_Cinema.Data.ViewModels;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signIn;
        private readonly AppDbContext context;
        public AccountController(UserManager<ApplicationUser> _user, SignInManager<ApplicationUser> _signIn, AppDbContext _context)
        {
            userManager = _user;
            signIn = _signIn;
            context = _context;
        }

        public async Task<IActionResult> Users()
        {
            var users = await context.Users.ToListAsync();
            return View(users);
        }

        public IActionResult Login()
        {
            var login = new LoginViewModel();
            return View(login);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var user = await userManager.FindByEmailAsync(login.Email);

            if(user != null)
            {
                var password = await userManager.CheckPasswordAsync(user, login.Password);

                if (password)
                {
                    var result = await signIn.PasswordSignInAsync(user, login.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Movies");
                    }
                }

                TempData["Error"] = "Inicio de sesion incorrecto. Por favor intentelo de nuevo!";

                return View(login);

            }

            TempData["Error"] = "Inicio de sesion incorrecto. Por favor intentelo de nuevo!";

            return View(login);
        }

        public IActionResult Register()
        {
            var register = new RegisterViewModel();
            return View(register);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            var user = await userManager.FindByEmailAsync(register.Email);
            if(user != null)
            {
                TempData["Error"] = "Ya existe una cuenta con este correo electronico!";
                return View(register);
            }

            var newUser = new ApplicationUser()
            {
                FullName = register.FullName,
                Email = register.Email,
                UserName = register.Email

            };

            var newReponse = await userManager.CreateAsync(newUser, register.Password);

            if (newReponse.Succeeded)
            {
                await userManager.AddToRoleAsync(newUser, UserRoles.User);
            }

            return View("RegisterCompleted");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signIn.SignOutAsync();
            return RedirectToAction("Index", "Movies");
        }

        public IActionResult AccessDenied(string ReturnUrl)
        {
            ViewBag.Url = ReturnUrl;
            return View();
        }
    }
}
