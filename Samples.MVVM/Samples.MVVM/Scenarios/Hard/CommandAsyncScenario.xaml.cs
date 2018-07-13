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

namespace Samples.MVVM.Scenarios.Hard
{
    /// <summary>
    /// Interaction logic for CommandAsyncScenario.xaml
    /// </summary>
    public partial class CommandAsyncScenario : Window
    {
        public CommandAsyncScenario()
        {
            this.DataContext = new CommandAsyncScenarioViewModel();
            InitializeComponent();
        }
    }
}
