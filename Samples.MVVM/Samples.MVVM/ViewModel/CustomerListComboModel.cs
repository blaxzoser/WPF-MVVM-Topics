using Sample.Entities;
using Sample.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class CustomerListComboModel
    {
        public ObservableCollection<Customer> Customers { get; set; }
        private ICustomer CustomerRepository;

        public CustomerListComboModel()
        {
            CustomerRepository = new CustomerRepository();
            Customers = new ObservableCollection<Customer>(CustomerRepository.Get());
        }
    }
}
