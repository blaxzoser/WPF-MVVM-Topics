using Sample.Entities;
using Sample.Repository;
using Samples.MVVM.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Samples.MVVM.ViewModel
{
    public class CustomerViewModel
    {
        #region interfaces
        private ICustomer CustomerRepository;
        #endregion

        #region Commands
        public RelayCommand DeleteCommand { get;  set; }
        #endregion

        #region Properties
        public ObservableCollection<Customer> Customers { get; set; }  

        private Customer _selectedCustomer;
        public  Customer SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                _selectedCustomer = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region Constructors

        public CustomerViewModel()
        {
            CustomerRepository = new CustomerRepository();
            Customers = new ObservableCollection<Customer>(CustomerRepository.Get());
            DeleteCommand = new RelayCommand(OnDelete,CanDelete);
        }
        #endregion

        #region Methods

        private bool CanDelete()
        {
            return SelectedCustomer != null;
        }

        private void OnDelete()
        {
            Customers.Remove(SelectedCustomer);
        }

        #endregion
    }
}
