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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Samples.MVVM.View
{
    /// <summary>
    /// Interaction logic for CustomerListClassic.xaml
    /// </summary>
    public partial class CustomerListClassicView : UserControl
    {
        private readonly CustomerListClassicViewModel _viewModel;
        public CustomerListClassicView()
        {
            _viewModel = new CustomerListClassicViewModel();
            this.DataContext = _viewModel;
            InitializeComponent();         
        }

        /// <summary>
        /// its bad practice, it wouldn't be like that aproach
        /// Break MVVM Pattern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotDoThat_Click(object sender, RoutedEventArgs e)
        {
            // Hack
            _viewModel.UpdateNameCustomers();
        }

        /// <summary>
        /// its bad practice, it wouldn't be like that aproach
        /// Break MVVM Pattern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNotDoThat_Click(object sender, RoutedEventArgs e)
        {
            // Hack
            _viewModel.AddCustomer();
        }
    }
}
