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

namespace Samples.MVVM.Scenarios.Hard
{
    /// <summary>
    /// Scenario Navigation And Comunication between view models
    /// Separete Concerns in View and ViewModel
    /// Create XAML objects
    /// Approach Main ViewModel to navegation 
    /// Approach ContentControl
    /// Use external library 'Unity' to Depency Injection and Ioc
    /// </summary>
    public partial class NavigationScenarioView : Window
    {
        public NavigationScenarioView()
        {
            InitializeComponent();
        }
    }
}
