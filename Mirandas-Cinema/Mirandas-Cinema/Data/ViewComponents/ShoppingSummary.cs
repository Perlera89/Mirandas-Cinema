using Microsoft.AspNetCore.Mvc;
using Mirandas_Cinema.Data.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.ViewComponents
{
    public class ShoppingSummary : ViewComponent
    {
        private readonly ShoppingCart cart;

        public ShoppingSummary(ShoppingCart _cart)
        {
            cart = _cart;
        }

        public IViewComponentResult Invoke()
        {
            var items = cart.GetShoppingCartItems();
            return View(items.Count);
        }
    }
}
