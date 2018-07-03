using Sample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Repository
{
    public class ProductRepository : IProduct
    {
        public List<Product> Get()
        {
            var listfake = new List<Product>();
            listfake.Add(new Product() { Cost = 10.02m, DateRegister = DateTime.Now, Description = "fake 1", ProductID = 1 });
            listfake.Add(new Product() { Cost = 121221, DateRegister = DateTime.Now, Description = "fake 2", ProductID = 2 });
            listfake.Add(new Product() { Cost = 23.23m, DateRegister = DateTime.Now, Description = "fake 2", ProductID = 3 });
            listfake.Add(new Product() { Cost = 242232323.32m, DateRegister = DateTime.Now, Description = "fake 3", ProductID = 4 });
            listfake.Add(new Product() { Cost = 1212.12m, DateRegister = DateTime.Now, Description = "fak3 4", ProductID = 5 });
            return listfake;
        }
    }
}
