using storage2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Services
{
    interface IOrderServise
    {
        public List<Order> GetAllOrders();
        public Order GetOrderForNumer(int number);
        public void AddOrder(string userId, List<Product> products);
        public void UpdateProduct(string userId, List<Product> products);
        public void DeleteProduct(int number);
    }
}
