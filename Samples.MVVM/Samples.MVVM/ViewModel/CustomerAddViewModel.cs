using Sample.Entities;
using Sample.Repository;
using Samples.MVVM.Command;
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
    public class CustomerAddViewModel : INotifyPropertyChanged
    {
        private ICustomer _customerRepository;


        public RelayCommand AddCommand { get; set; }

        private CustomerModel _customerMode;
        public CustomerModel CustomerModel
        {
            get
            {
                return _customerMode;
            }
            set
            {
                if(_customerMode != value)
                {
                    _customerMode = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("CustomerModel"));
                }
            }
        }

        public ObservableCollection<Nationality> Nationalities { get; set; }

        private Nationality _selectedNationality;
        public Nationality SelectedNationality
        {
            get
            {
                return _selectedNationality;
            }
            set
            {
                if (_selectedNationality != value)
                {
                    _selectedNationality = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedNationality"));
                }
            }
        }

        private bool _hasNationality;
        public bool HasNationality
        {
            get
            {
                return _hasNationality;
            }
            set
            {
                if (_hasNationality != value)
                {
                    _hasNationality = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("HasNationality"));
                }
            }
        }




        private bool _hasChilds;
        public bool HasChilds
        {
            get
            {
                return _hasChilds;
            }
            set
            {
                if (_hasChilds != value)
                {
                    _hasChilds = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("HasChilds"));
                }
            }
        }


        public CustomerAddViewModel()
        {
            _customerRepository = new CustomerRepository();
            CustomerModel = new CustomerModel();
            HasNationality = true;
            Nationalities = new ObservableCollection<Nationality>(_customerRepository.GetAllNationalities());
        }

        private Customer CastToModel(CustomerModel customerModel)
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = customerModel.Name;
            newCustomer.LastName = customerModel.LastName;
            newCustomer.Phone = customerModel.Phone.Value;
            return newCustomer;
        }

        private Customer AddCustomer()
        {
            return CastToModel(this.CustomerModel);
        }

        private bool CanAdd()
        {
            return true;
        }

        private void OnAdd()
        {
            var newCustomer = AddCustomer();
            _customerRepository.Add(newCustomer);
        }




        public event PropertyChangedEventHandler PropertyChanged = delegate { };




    }
}
