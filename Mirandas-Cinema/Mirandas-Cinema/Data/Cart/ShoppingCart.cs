using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Cart
{
    public class ShoppingCart
    {
        public AppDbContext context { get; set; }
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems{ get; set; }

        public ShoppingCart(AppDbContext _context)
        {
            context = _context;
        }

        //Servicios en tiempo de ejecucion y guardar peticiones del usuario
        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId};
        }

        //Agregar elemento al carrito
        public void AddItem(Movie movie)
        {
            var shoppingCart = context.ShoppingCartItems.
                FirstOrDefault(s => s.Movie.Id == movie.Id && s.ShoppingCartId == ShoppingCartId);

            if(shoppingCart == null)
            {
                shoppingCart = new ShoppingCartItem()
                {
                    ShoppingCartId = this.ShoppingCartId,
                    Movie = movie,
                    Amount = 1
                };

                context.ShoppingCartItems.Add(shoppingCart);
            }
            
            else
            {
                shoppingCart.Amount++;
            }

            context.SaveChanges();
        }

        //Eliminar elemento del carrito
        public void RemoveItem(Movie movie)
        {
            var shoppingCart = context.ShoppingCartItems.
                FirstOrDefault(s => s.Movie.Id == movie.Id && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCart != null)
            {
                if(shoppingCart.Amount > 1)
                {
                    shoppingCart.Amount--;
                }

                else
                {
                    context.ShoppingCartItems.Remove(shoppingCart);
                }

            }

            context.SaveChanges();
        }

        //Listas los elementos del carrito
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = context.ShoppingCartItems.
                Where(s => s.ShoppingCartId == ShoppingCartId).Include(s => s.Movie).ToList()); 
        }

        //Calcular el total de los elementos del carrito
        public double GetShoppingTotal()
        {
            var total = context.ShoppingCartItems.
                Where(s => s.ShoppingCartId == ShoppingCartId).
                Select(s => s.Movie.Price * s.Amount).Sum();

            return total;   
        }

        //Limpiar carrito
        public async Task ClearShoppingCart()
        {
            var movies = await context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).ToListAsync();
            context.ShoppingCartItems.RemoveRange(movies);

            await context.SaveChangesAsync();
        }
    }
}
