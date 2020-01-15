using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using storage2.Models;
using storage2.Services;
using storage2.Services.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        private IDataServise dataServise;

        private StorageContext _storageContext;
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
            dataServise = new DataServise();
            _storageContext = new StorageContext();
        }
        // GET: api/order
        [HttpGet]
        public List<Order> GetAll()
        {
            return dataServise.GetOrdersList();
        }
        // GET: api/order/12
        [HttpGet("{Number}", Name = "GetForNumber")]
        public Order GetForNumber(int number)
        {
            return dataServise.GetOrderForNumber(number);

        }
        /*
        // POST: api/order
        [HttpPost("{Name}/{Cost}")]
        public void AddOrder([FromBody] List<Product> products)
        {
            //todo
        }
        */
        [HttpPost("{Name}/{Cost}")]
        public void AddOrder([FromBody] List<Product> products)
        {
            //todo
        }

        // PUT: api/order/5
        [HttpPut("{id}")]
        public void UpdateOrder(int id, [FromBody] List<Product> products)
        {
            //todo
        }

        // DELETE: api/order/5
        [HttpDelete("{id}")]
        public void DeleteProduct(int id)
        {
            //todo
        }



    }
}
