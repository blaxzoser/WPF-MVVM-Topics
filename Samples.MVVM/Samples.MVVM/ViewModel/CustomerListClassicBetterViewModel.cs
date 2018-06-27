using Sample.Entities;
using Sample.Repository;
using Samples.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class CustomerListClassicBetterViewModel : INotifyPropertyChanged
    {
        #region Properties

        //The best practice
        public ObservableCollection<CustomerModel> Customers { get; set; }

        private string _titlePage;
        public string TitlePage
        {
            get
            {
                return _titlePage;
            }
            set
            {
                if (_titlePage != value)
                {
                    _titlePage = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("TitlePage"));
                }
            }
        }

        #endregion

        #region Interfaces
        private ICustomer _customerRepository;


        #endregion

        #region Constructor
        public CustomerListClassicBetterViewModel()
        {
            _customerRepository = new CustomerRepository();
            var listCustomers = CastToModel(_customerRepository.Get());
            Customers = new ObservableCollection<CustomerModel>(listCustomers);
            TitlePage = "Componen List of Customers";
        }
        #endregion

        #region Methods
        public void UpdateNameCustomers()
        {
            //It's working fine
            foreach (var customer in Customers)
            {
                customer.Name = "fake";
            }

            //It's not working well
            TitlePage= TitlePage + "Change Title"  ;
        }

        public void AddCustomer()
        {
            Customers.Add(new CustomerModel() { Name = "Fake", LastName = "Fake", Phone = 1212 });     
        }

        /// <summary>
        /// Its very commond used things to convert
        /// </summary>
        /// <param name="listCustomerModel"></param>
        /// <returns></returns>
        private List<CustomerModel> CastToModel(List<Customer> listCustomers)
        {
            var listConvert = new List<CustomerModel>();
            foreach (var customer in listCustomers)
            {
                CustomerModel newCustomer = new CustomerModel();
                newCustomer.Name = customer.Name;
                newCustomer.LastName = customer.LastName;
                newCustomer.Phone = customer.Phone;
                listConvert.Add(newCustomer);
            }
          
            return listConvert;
        }

        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        #endregion
    }
}
