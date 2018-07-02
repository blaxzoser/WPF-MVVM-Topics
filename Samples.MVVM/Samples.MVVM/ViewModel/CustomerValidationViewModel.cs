using Sample.Entities;
using Sample.Repository;
using Samples.MVVM.Command;
using Samples.MVVM.Library;
using Samples.MVVM.Model;
using Samples.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Samples.MVVM.ViewModel
{
    public class CustomerValidationViewModel : BindableBase
    {
        #region Interfaces
        private ICustomer _customerRepository;
        #endregion

        #region Commands
        public RelayCommand AddCommand { get; set; }
        public RelayCommand ValidateCommand { get; set; }
        #endregion

        #region Properties
        private SuperCustomerModel _customerMode;
        public SuperCustomerModel CustomerModel
        {
            get
            {
                return _customerMode;
            }
            set
            {
                SetProperty(ref _customerMode, value);
            }
        }


        #endregion

        #region Constructors
        public CustomerValidationViewModel()
        {
            Load();
        }
        #endregion

        #region Methods

        private void Load()
        {
            _customerRepository = new MemoryRepository();
            AddCommand = new RelayCommand(OnAdd, CanAdd);
            ValidateCommand = new RelayCommand(OnValidate);

            if (CustomerModel != null) CustomerModel.ErrorsChanged -= CustomerModel_ErrorsChanged;
            CustomerModel = new SuperCustomerModel();
            CustomerModel.ErrorsChanged += CustomerModel_ErrorsChanged;

            LoadCustomer();
            Refresh();
        }

        private void CustomerModel_ErrorsChanged(object sender, DataErrorsChangedEventArgs e)
        {
            AddCommand.RaiseCanExecuteChanged();
        }

        public void Refresh()
        {

        }

        private void LoadCustomer()
        {
            CustomerModel.Name = "LUIS";
            CustomerModel.LastName = "PINTADO";
            CustomerModel.Phone = "5555555";
            CustomerModel.Age = 31;
            CustomerModel.Comments = "abc123";
            CustomerModel.Email = "strato.beto@gmail.com";
        }

        private Customer CastToModel(SuperCustomerModel customerModel)
        {
            Customer newCustomer = new Customer();
            newCustomer.Name = customerModel.Name;
            newCustomer.LastName = customerModel.LastName;
            newCustomer.Phone = int.Parse(customerModel.Phone);
            return newCustomer;
        }

        private Customer AddCustomer()
        {
            return CastToModel(CustomerModel);
        }

        private bool CanAdd()
        {
            return !this.CustomerModel.HasErrors;
        }

        private void OnAdd()
        {
            var newCustomer = AddCustomer();
            _customerRepository.Add(newCustomer);
            Refresh();
        }

        private void OnValidate()
        {
            if(this.CustomerModel.HasErrors)
            {
                var listErrors = this.CustomerModel.GetTotalErrors();
                var message = new StringBuilder();
                foreach (var error in listErrors)
                {
                    message.AppendLine(error.Key);
                    if (error.Value.Any())
                    foreach (var msj in error.Value)
                    {
                            message.AppendLine(msj);
                    }
                }
                //It's a hack Also it's not best practice
                MessageBox.Show(message.ToString());
            }
        }
        #endregion
    }
}
