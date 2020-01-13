using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string NameUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBrith { get; set; }
    }
}
