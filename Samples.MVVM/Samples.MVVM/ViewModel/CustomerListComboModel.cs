using Sample.Entities;
using Sample.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class CustomerListComboModel : INotifyPropertyChanged
    {
        private ObservableCollection<Customer> _customers;
        public ObservableCollection<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (_customers != value)
                {
                    _customers = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Customers"));
                }
            }
        }
        private ICustomer _customerRepository;
        public CustomerListComboModel()
        {
           
                _customerRepository = new CustomerRepository();
                Customers = new ObservableCollection<Customer>(_customerRepository.Get());
        }   

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

    }
}
