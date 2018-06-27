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
    public class CustomerListClassicViewModel
    {
        #region Properties

        //The best practice
        public ObservableCollection<Customer> Customers { get; set; }

        //It's not recommended
        public List<Customer> CustomersNotUdpateUI { get; set; }
        public string TitlePage { get; set; }

        #endregion

        #region Interfaces
        private ICustomer _customerRepository;
        #endregion

        #region Constructor
        public CustomerListClassicViewModel()
        {
            _customerRepository = new CustomerRepository();
            var listCustomers = _customerRepository.Get();
            Customers = new ObservableCollection<Customer>(listCustomers);
            CustomersNotUdpateUI = listCustomers;
            TitlePage = "Componen List of Customers";
        }
        #endregion

        #region Methods
        public void UpdateNameCustomers()
        {
            //It's not working well
            foreach (var customer in Customers)
            {
                customer.Name = "fake";
            }

            //It's not working well
            TitlePage = "ChangeCustomer";
        }

        public void AddCustomer()
        {
            Customers.Add(new Customer() { Name = "Fake", LastName = "Fake", Phone = 1212 });
            CustomersNotUdpateUI.Add(new Customer() { Name = "Fake", LastName = "Fake", Phone = 1212 });
        }
        #endregion
    }
}
