using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Models
{
    public class Order
    {   
        public int Number { get; set; }

        public List<Product> Products { get; set; }

        public User UserId { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
