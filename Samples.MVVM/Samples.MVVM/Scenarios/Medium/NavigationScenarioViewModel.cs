using Samples.MVVM.Command;
using Samples.MVVM.Library;
using Samples.MVVM.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.Scenarios.Medium
{
    public class NavigationScenarioViewModel : BindableBase
    {
        private ProductListViewModel _productListViewModel = new ProductListViewModel();
        private ProductAddViewModel _productAddViewModel = new ProductAddViewModel();

        public BindableBase _CurrentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }

        }

        public RelayParameterCommand<string> NavCommand { get; set; }

        public NavigationScenarioViewModel()
        {
            NavCommand = new RelayParameterCommand<string>(OnNav, OnEnabled);
        }

        private bool OnEnabled(object destination)
        {
            return true;
            
        }

        private void OnNav(object destination)
        {
            switch (destination)
            {
                case "ListProducts":
                    CurrentViewModel = _productListViewModel;
                    break;
                case "AddProduct":
                    CurrentViewModel = _productAddViewModel;
                    break;
                default:
                    CurrentViewModel = _CurrentViewModel;
                break;
            }
        }
    }
}
