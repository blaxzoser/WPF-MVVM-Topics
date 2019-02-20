using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities
{
    public class Father
    {
        public string Name { get; set; }
        public List<Child> Childrens  { get; set; }
    }
}
