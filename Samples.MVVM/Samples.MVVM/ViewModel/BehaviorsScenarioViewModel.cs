using Sample.Entities;
using Sample.Repository;
using Samples.MVVM.Command;
using Samples.MVVM.Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Samples.MVVM.ViewModel
{
    public class BehaviorsScenarioViewModel : BindableBase
    {
        public RelayCommand SelectedValueCommand { get; set; }
        public ObservableCollection<Customer> Customers { get; set; }
        public ICustomer _repository;

        public BehaviorsScenarioViewModel()
        {
            _repository = new CustomerRepository();
            Customers = new ObservableCollection<Customer>(_repository.Get());
            SelectedValueCommand = new RelayCommand(DoSomething);
        }

        public void LoadData()
        {
            MessageBox.Show("LoadData");
        }

        private void DoSomething()
        {
            MessageBox.Show("DoSomething");
        }
    }
}
