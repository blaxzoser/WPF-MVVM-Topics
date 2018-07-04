using Samples.MVVM.Command;
using Samples.MVVM.Library;
using Samples.MVVM.Product;
using Samples.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.Scenarios.Medium
{
    public class NavigationScenarioViewModel : BindableBase
    {
        #region Repository
        #endregion

        #region ViewModels
        private ProductListViewModel _productListViewModel;
        private ProductAddViewModel _productAddViewModel = new ProductAddViewModel();
        #endregion

        #region Properties
        public BindableBase _CurrentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }

        }
        #endregion

        #region Commands
        public RelayParameterCommand<string> NavCommand { get; set; }
        #endregion

        #region Contructor
        public NavigationScenarioViewModel()
        {        
            _productListViewModel = ContainerHelper.ResolveAll<ProductListViewModel>();
            
            NavCommand = new RelayParameterCommand<string>(OnNav, OnEnabled);
            _productListViewModel.PlaceDetailsRequested += _productListViewModel_PlaceDetailsRequested;
        }
        #endregion

        #region Methods
        private void _productListViewModel_PlaceDetailsRequested(int obj)
        {
            _productAddViewModel.ProductID = obj;
            CurrentViewModel = _productAddViewModel;

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
        #endregion
    }
}
