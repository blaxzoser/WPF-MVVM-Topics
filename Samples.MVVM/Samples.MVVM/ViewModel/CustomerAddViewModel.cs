using Sample.Entities;
using Samples.MVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class CustomerAddViewModel : INotifyPropertyChanged
    {
        private CustomerModel _customerMode;
        public CustomerModel CustomerModel
        {
            get
            {
                return _customerMode;
            }
            set
            {
                if(_customerMode != null)
                {
                    _customerMode = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("CustomerModel"));
                }
            }
        }

        public CustomerAddViewModel()
        {
            CustomerModel = new CustomerModel();
        }

        private Customer CastToModel(CustomerModel customerModel)
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = customerModel.Name;
            newCustomer.LastName = customerModel.LastName;
            newCustomer.Phone = customerModel.Phone.Value;
            return newCustomer;
        }

        private void AddCustomer()
        {
            CastToModel(this.CustomerModel);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };



    }
}
