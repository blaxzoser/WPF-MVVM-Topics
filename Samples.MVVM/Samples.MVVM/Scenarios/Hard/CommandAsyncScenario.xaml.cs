using Samples.MVVM.ViewModel;
using System.Windows;


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
