using Samples.MVVM.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.Product
{
    public  class ProductAddViewModel : BindableBase
    {
        private int _productID;
        public int ProductID
        {
            get { return _productID; }
            set { SetProperty(ref _productID, value); }
        }
    }
}
