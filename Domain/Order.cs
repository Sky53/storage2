using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Models
{
    public class Order
    {   
        [Key]
        public int Number { get; set; }

        public User User { get; set; }

        public List<Product> Products { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsDeleted { get; set; }
    }
}
