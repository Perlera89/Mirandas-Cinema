using Microsoft.AspNetCore.Mvc;
using Mirandas_Cinema.Data.Cart;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Data.ViewModels;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMovies service;
        private readonly ShoppingCart cart;
        private readonly IOrders order;
        public OrdersController(IMovies _service, ShoppingCart _cart, IOrders _order)
        {
            service = _service;
            cart = _cart;
            order = _order;
        }

        public async Task<IActionResult> Index()
        {
            string userId = "";
            var orders = await order.GetOrdersUser(userId);
            return View(orders);
        }

        public IActionResult ShoppingCart()
        {
            var items = cart.GetShoppingCartItems();
            cart.ShoppingCartItems = items;

            var response = new ShoppingCartViewModel() {
                ShoppingCart = cart,
                ShoppingTotal = cart.GetShoppingTotal()
            };

            return View(response);  
        }

        public async Task<IActionResult> AddItem(int id)
        {
            var movie = await service.GetById(id);

            if(movie != null)
            {
                cart.AddItem(movie);
            }

            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveItem(int id)
        {
            var movie = await service.GetById(id);

            if (movie != null)
            {
                cart.RemoveItem(movie);
            }

            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> Order()
        {
            var movies = cart.GetShoppingCartItems();
            string userId = "";
            string email = "";

            await order.StoreOrder(movies, userId, email);
            await cart.ClearShoppingCart();

            return View("OrderCompleted"); ;
        }
    }
}
