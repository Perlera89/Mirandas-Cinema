using Mirandas_Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mirandas_Cinema.Data.Services
{
    public interface IOrders
    {
        Task StoreOrder(List<ShoppingCartItem> items, string userId,  string email);
        Task<List<Order>> GetOrdersUser(string userId, string userRole);
    }
}
