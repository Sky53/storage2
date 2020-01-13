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
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
      
        private IDataServise dataServise;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
            dataServise = new DataServise();
        }
        // GET: api/user
        [HttpGet]
        public List<User> GetAll()
        {
            return dataServise.GetUserList();
        }
        // GET: api/user/5
        [HttpGet("{id}", Name = "GetForid")]
        public User GetForId(Guid id)
        {
            return dataServise.GetUserForId(id);
        }

        // POST: api/user
        [HttpPost]
        public void AddUser([FromBody] string nameUser, string login, string password, DateTime dateTime)
        {
            //todo
        }

        // PUT: api/user/5
        [HttpPut("{id}")]
        public void UpdateUser(int id, 
                                    [FromBody] string nameProduct, 
                                    string login, 
                                    string password, 
                                    DateTime dateOfBrith)
        {
            //todo
        }

        // DELETE: api/user/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            //todo
        }
    }
}

