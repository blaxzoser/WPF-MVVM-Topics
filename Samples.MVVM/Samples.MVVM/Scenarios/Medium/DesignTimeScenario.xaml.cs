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
    /// Interaction logic for DesignTimeScenario.xaml
    /// </summary>
    public partial class DesignTimeScenario : Window
    {
        public DesignTimeScenario()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.DesignTimeViewModel();
        }
    }
}
