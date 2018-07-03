using Sample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Repository
{
    public interface IProduct
    {
        List<Product> Get();
    }
}
