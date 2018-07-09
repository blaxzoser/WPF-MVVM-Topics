using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities
{
    public class Company
    {
        public int CompanyID { get; set; }
        public String Name { get; set; }
        public int NumberEmployes { get; set; }
        public DateTime Register { get; set; }
        public Decimal Budget { get; set; }

        public List<Product> Products { get; set; }
    }
}
