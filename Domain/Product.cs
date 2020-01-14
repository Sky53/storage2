using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storage2.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string SKU { get; set; }
        public string NameProduct { get; set; }
        public decimal Cost { get; set; }
        public Order Order { get; set; }
        public bool IsDeleted { get; set; }
    }
}
