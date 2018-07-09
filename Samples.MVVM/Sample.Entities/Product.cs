using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public DateTime DateRegister { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
