using Samples.MVVM.Command;
using Samples.MVVM.Library;
using Samples.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.Product
{
    public class ProductListViewModel : BindableBase
    {
        public ObservableCollection<Sample.Entities.Product> Products { get; set; }
        public RelayParameterCommand<Sample.Entities.Product> DetailsCommand { get; set; }
        public IProduct _IProduct;

        public ProductListViewModel()
        {
            _IProduct = new ProductRepository();
            Products = new ObservableCollection<Sample.Entities.Product>(_IProduct.Get());
            DetailsCommand = new RelayParameterCommand<Sample.Entities.Product>(OnDetails);
        }

        private void OnDetails(Sample.Entities.Product product)
        {

        }

    }
}
