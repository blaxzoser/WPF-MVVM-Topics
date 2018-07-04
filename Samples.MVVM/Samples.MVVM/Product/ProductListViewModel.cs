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
        private Sample.Entities.Product _selectedProduct;
        public Sample.Entities.Product SelectedProduct
        {
            get { return _selectedProduct; }
            set { SetProperty(ref _selectedProduct, value); }
        }
        public ObservableCollection<Sample.Entities.Product> Products { get; set; }

        public RelayParameterCommand<Sample.Entities.Product> DetailsCommand { get; set; }

        public event Action<int> PlaceDetailsRequested = delegate { };

        public ProductListViewModel(IProduct _IProduct)
        {
            Products = new ObservableCollection<Sample.Entities.Product>(_IProduct.Get());
            DetailsCommand = new RelayParameterCommand<Sample.Entities.Product>(OnDetails);
        }

        private void OnDetails(Sample.Entities.Product product)
        {
            PlaceDetailsRequested(product.ProductID);
        }

    }
}
