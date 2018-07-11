using Sample.Entities;
using Samples.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Samples.MVVM.Scenarios.Medium
{
    /// <summary>
    /// Interaction logic for DepencyPropertiesScenario.xaml
    /// </summary>
    public partial class DepencyPropertiesScenario : Window
    {
        public DepencyPropertiesScenario()
        {
            InitializeComponent();        
            Load();
            DataContext = this;
        }


        private void Load()
        {
            Customers = new List<Customer>();
            Customers.Add(new Customer() { Name = "Luis", LastName = "Pintado", Phone = 234324 });
            Customers.Add(new Customer() { Name = "Jorge", LastName = "Perez", Phone = 545346 });
            Customers.Add(new Customer() { Name = "Tomas", LastName = "Smit", Phone = 86778678 });
        }

        public List<Customer> Customers
        {
            get { return (List<Customer>)GetValue(CustomersProperty); }
            set { SetValue(CustomersProperty, value); }
        }

        public static readonly DependencyProperty CustomersProperty =
         DependencyProperty.RegisterAttached("Customers", 
             typeof(List<Customer>), 
             typeof(DepencyPropertyViewModel),
             new PropertyMetadata(null)
             );
    }
}
