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

namespace Samples.MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();         
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var currentValue = cbOptions.SelectionBoxItem.ToString();
            switch (currentValue)
            {
                case "Controls":
                    var newWindowsControl = new Scenarios.Basic.ConvertsScenario();
                    newWindowsControl.ShowDialog();
                    break;
                case "Template":
                    var newWindowsTemplate = new Scenarios.Basic.DataTemplateScenario();
                    newWindowsTemplate.ShowDialog();
                    break;
                case "Style":
                    var newWindowsStyle = new Scenarios.Medium.ResourcesScenario();
                    newWindowsStyle.ShowDialog();
                    break;
                case "Theming":
                    var newWindowsTheming = new Scenarios.Basic.ValidationScenario();
                    newWindowsTheming.ShowDialog();
                    break;

                case "Events":
                    var eventsScenario = new Scenarios.Basic.EventsScenario();
                    eventsScenario.ShowDialog();
                    break;
                case "Binding":
                    var bindinBindingCoreScenario = new Scenarios.Basic.BindingCoreScenario();
                    bindinBindingCoreScenario.ShowDialog();
                    break;
                case "BadScenario":
                    var badScenario = new Scenarios.Basic.GoodScenarioViewModel();
                    badScenario.ShowDialog();
                    break;

            }
        }

        
    }
}
