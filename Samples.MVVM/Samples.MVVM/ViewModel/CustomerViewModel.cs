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
using System.Windows.Input;

namespace Samples.MVVM.ViewModel
{
    public class CustomerViewModel
    {
        #region interfaces
        private ICustomer CustomerRepository;
        #endregion

        #region Commands     
        public ICommand MessageCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayParameterCommand<string> AddCommand { get; set; }
        #endregion

        #region Properties
        public ObservableCollection<Customer> Customers { get; set; }


        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                AddCommand.RaiseCanExecuteChanged();
            }
        }


        private Customer _selectedCustomer;
        public Customer SelectedCustomer
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
            DeleteCommand = new RelayCommand(OnDelete, CanDelete);
            AddCommand = new RelayParameterCommand<string>(OnAdd, CanAdd);
            MessageCommand = new SimpleCommand();
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


        private bool CanAdd(object obj)
        {
            return (obj is string);
        }

        private void OnAdd(object obj)
        {
            if (obj != null)
            {
                string name = obj as string;
                Customers.Add(new Customer() { LastName = "", Name = name, Phone = 000 });
            }
        }

        #endregion
    }
}
