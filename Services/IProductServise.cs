using storage2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Services
{
    interface IProductServise
    {
        public List<Product> GetAllProducts();
        public Product GetProductForId(string id);
        public Product GetFirstProductForName(string nameProduct);
        public List<Product> GetProductsForName(string nameProduct);
        public void AddProduct(string id, string nameProduct, string cost);
        public void UpdateProduct(string id, string nameProduct, string cost);
        public void DeleteProduct(string id);
    }
}
