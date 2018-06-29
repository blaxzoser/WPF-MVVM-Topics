using Sample.Entities;
using Sample.Repository;
using Samples.MVVM.Command;
using Samples.MVVM.Model;
using Samples.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class CustomerGridViewModel : INotifyPropertyChanged
    {
        #region Interfaces
        private ICustomer _customerRepository;
        #endregion

        #region Commands
        public RelayCommand DeleteCommand { get; set; }
        #endregion

        #region Constructor
        public CustomerGridViewModel()
        {
            _customerRepository = new MemoryRepository();
            DeleteCommand = new RelayCommand(OnDeleted);
            CustomerModels = new ObservableCollection<CustomerModel>((CastToModel(_customerRepository.Get())));
        }
        #endregion

        #region Properties
        private CustomerModel _selectedCustomerModel;
        public CustomerModel SelectedCustomerModel
        {
            get
            {
                return _selectedCustomerModel;
            }
            set
            {
                if (_selectedCustomerModel != value)
                {
                    _selectedCustomerModel = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedCustomerModel"));
                }
            }
        }

        private bool _checkAllValues;
        public bool CheckAllValues
        {
            get
            {
                return _checkAllValues;
            }
            set
            {
                if (_checkAllValues != value)
                {
                    _checkAllValues = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("CheckAllValues"));
                    OnChekedAll(_checkAllValues);
                }
            }
        }

        public ObservableCollection<CustomerModel> CustomerModels { get; set; }



        #endregion

        #region Methods
        private void OnChekedAll(object param)
        {
            if(param != null && param is bool)
            {
                bool value =  (bool)param;
                foreach (var customers in this.CustomerModels)
                {
                    customers.IsAlive = value;
                }
            }
        }

        private Customer CastToModel(CustomerModel customerModel)
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = customerModel.Name;
            newCustomer.LastName = customerModel.LastName;
            newCustomer.Phone = customerModel.Phone.Value;
            return newCustomer;
        }

        private List<CustomerModel> CastToModel(List<Customer> customers)
        {
            var list = new List<CustomerModel>();
            if(customers != null && customers.Any())
            {
                foreach (var customer in customers)
                {
                    CustomerModel newCustomer = new CustomerModel();
                    newCustomer.Name = customer.Name;
                    newCustomer.LastName = customer.LastName;
                    newCustomer.Phone = customer.Phone;
                    list.Add(newCustomer);
                }
            }
            return list;
        }



        private void OnDeleted()
        {
            var customer = CastToModel(this.SelectedCustomerModel);
            _customerRepository.Delete(customer);
            CustomerModels.Remove(this.SelectedCustomerModel);            
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
