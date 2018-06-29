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
    public class CustomerAddViewModel : INotifyPropertyChanged
    {
        #region Interfaces
        private ICustomer _customerRepository;
        #endregion

        #region Commands
        public RelayCommand AddCommand { get; set; }
        #endregion

        #region Properties
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


        public ObservableCollection<Customer> Customers { get; set; }
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

        private int _totalCustomers;
        public int TotalCustomers
        {
            get
            {
                return _totalCustomers;
            }
            set
            {
                if (_totalCustomers != value)
                {
                    _totalCustomers = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("TotalCustomers"));
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

        #endregion

        #region Constructor
        public CustomerAddViewModel()
        {
            _customerRepository = new MemoryRepository();
            Nationalities = new ObservableCollection<Nationality>(_customerRepository.GetAllNationalities());
            CustomerModel = new CustomerModel();
            AddCommand = new RelayCommand(OnAdd);
            Refresh();
        }

        public void Refresh()
        {
            HasNationality = true;
            TotalCustomers = _customerRepository.Get().Count;
        }

        #endregion

        #region Methods
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
            Refresh();
        }
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        #endregion


    }
}
