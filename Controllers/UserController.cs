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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
      
        private IDataServise dataServise;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public List<User> Get()
        {
            return dataServise.GetUserList();
        }

        [HttpGet]
        public User GetForName()
        {
            return dataServise.GetUserForId(Guid.NewGuid());
        }
    }
}
