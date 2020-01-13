using storage2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Services
{
    interface IDataServise
    {
        public List<User> GetUserList();
        public User GetUserForId(Guid id);
        public List<Order> GetOrdersList();
        public Order GetOrderForNumber(int number);
        public List<Product> GetProductsList();
        public Product GetProductForId(Guid id);
        public Product GetProductForName(string name);

    }
}
