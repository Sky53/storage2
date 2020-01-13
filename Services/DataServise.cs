using storage2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Services
{
    public class DataServise : IDataServise
    {

        public User GetUserForId(Guid id)
        {
            User user = new User();
            user.Id = Guid.NewGuid();
            user.NameUser = "ONEname";
            user.Login = "ONEBuyer";
            user.Password = "Password1";
            user.DateOfBrith = DateTime.Now;



            return user;
        }

        public List<User> GetUserList()
        {
            List<User> buyers = new List<User>();

            User user1 = new User();
            user1.Id = Guid.NewGuid();
            user1.NameUser = "Nane1";
            user1.Login = "Login1";
            user1.Password = "Password1";
            user1.DateOfBrith = DateTime.Now;

            User user2 = new User();
            user2.Id = Guid.NewGuid();
            user2.NameUser = "Name2";
            user2.Login = "Login2";
            user2.Password = "Password2";
            user2.DateOfBrith = DateTime.Now;

            User user3 = new User();
            user3.Id = Guid.NewGuid();
            user3.NameUser = "Name3";
            user3.Login = "Login3";
            user3.Password = "Password3";
            user3.DateOfBrith = DateTime.Now;

            buyers.Add(user1);
            buyers.Add(user2);
            buyers.Add(user3);

            return buyers;
        }

        public Order GetOrderForNumber(int number)
        {
            Order order1 = new Order();
            order1.Number = number;
            order1.Products = new List<Product>();
            order1.DateCreated = DateTime.Now;
            return order1;
        }

        public List<Order> GetOrdersList()
        {
            List<Order> orders = new List<Order>();
            Random random = new Random();

            Order order1 = new Order();
            order1.Number = random.Next(1, 1000);
            
            order1.Products = GetProductsList();
            order1.DateCreated = DateTime.Now;

            Order order2 = new Order();
            order2.Number = random.Next(1, 1000);
           
            order2.Products = GetProductsList();
            order2.DateCreated = DateTime.Now;

            Order order3 = new Order();
            order3.Number = random.Next(1, 1000);
            order3.Products = GetProductsList();
            order3.DateCreated = DateTime.Now;

            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);

            return orders;
        }

        public Product GetProductForId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductForName(string name)
        {
            Random random = new Random();

            Product product1 = new Product();
            product1.Id = Guid.NewGuid();
            product1.SKU = "SKUONE";
            product1.NameProduct = name;
            product1.Cost = new decimal(random.Next(12, 100));

            return product1;
        }

        public List<Product> GetProductsList()
        {
            Random random = new Random();
            List<Product> products = new List<Product>();

            Product product1 = new Product();
            product1.Id = Guid.NewGuid();
            product1.SKU = $"SKU{random.Next(10, 20)}";
            product1.NameProduct = $"NameProduct{random.Next(1,10)}";
            product1.Cost = new decimal(random.Next(12, 100));

            Product product2 = new Product();
            product2.Id = Guid.NewGuid();
            product2.SKU = $"SKU{random.Next(10, 20)}";
            product2.NameProduct = $"NameProduct{random.Next(1, 10)}";
            product2.Cost = new decimal(random.Next(12, 100));

            Product product3 = new Product();
            product3.Id = Guid.NewGuid();
            product3.SKU = $"SKU{random.Next(10, 20)}";
            product3.NameProduct = $"NameProduct{random.Next(1, 10)}";
            product3.Cost = new decimal(random.Next(12, 100));

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            return products;
        }
    }
}
