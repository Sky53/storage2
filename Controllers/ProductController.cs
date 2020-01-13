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
        [HttpGet("allproduct")]
        public List<Product> GetAll()
        {
            return dataServise.GetProductsList();
        }

        [HttpGet]
        public Product GetForName()
        {
            return dataServise.GetProductForName("CastomName");
        }
    }
}
