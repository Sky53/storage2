using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using storage2.Models;
using storage2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Controllers
{
    [ApiController]
    //serv/api/
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
       
        private IDataServise dataServise;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
            dataServise = new DataServise();
        }
        // GET: api/product
        [HttpGet]
        public List<Product> GetAll()
        {
            return dataServise.GetProductsList();
        }
        // GET: api/product/MyName
        [HttpGet("{Name}", Name = "GetForName")]
        public Product GetForName(string name)
        {
            return dataServise.GetProductForName(name);
        }

        // POST: api/product
        [HttpPost]
        public void AddProduct([FromBody] string nameProduct, decimal cost)
        {
            //todo
        }

        // PUT: api/product/5
        [HttpPut("{id}")]
        public void UpdateProduct(int id, [FromBody] string nameProduct)
        {
            //todo
        }

        // DELETE: api/product/5
        [HttpDelete("{id}")]
        public void DeleterProduct(int id)
        {
            //todo
        }
    }
}
