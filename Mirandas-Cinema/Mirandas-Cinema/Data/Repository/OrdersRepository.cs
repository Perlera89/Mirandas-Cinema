using Microsoft.EntityFrameworkCore;
using Mirandas_Cinema.Data.Services;
using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Repository
{
    public class OrdersRepository : IOrders
    {
        private readonly AppDbContext context;

        public OrdersRepository(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<List<Order>> GetOrdersUser(string userId, string userRole)
        {
            var orders = await context.Orders.Include(o => o.OrderItems).ThenInclude(o => o.Movie).Include(o => o.User).ToListAsync();

            if(userRole != "Admin")
            {
                orders = orders.Where(o => o.UserId == userId).ToList();
            }
            return orders;
        }

        public async Task StoreOrder(List<ShoppingCartItem> items, string userId, string email)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = email
            };

            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderMovie = new OrderItem() 
                { 
                    Amount = item.Amount,
                    MovieId = item.Movie.Id,
                    OrderId = order.Id,
                    Price = item.Movie.Price
                };

                await context.OrderItems.AddAsync(orderMovie);
                await context.SaveChangesAsync();
            }
        }
    }
}
