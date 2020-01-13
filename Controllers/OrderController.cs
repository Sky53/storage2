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
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        private IDataServise dataServise;
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public List<Order> GetAll()
        {
            return dataServise.GetOrdersList();
        }

        [HttpGet]
        public Order GetForNumber()
        {
            return dataServise.GetOrderForNumber(1111);
        }
    }
}
