using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities
{
    public class Child
    {
        public string Name { get; set; }
        public  List<Child> Children { get; set; }

    }
}
