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
                    var newWindowsStyle = new Scenarios.Basic.ValidationScenario();
                    newWindowsStyle.ShowDialog();
                    break;
                case "AttachedBehaviour":
                    var attachedBehaviour = new Scenarios.Basic.AttachedBehaviorScenario();
                    attachedBehaviour.ShowDialog();
                    break;
                case "TriggersBehaviour":
                    var newWindowsTheming = new Scenarios.Medium.BehaviorsScenarioView();
                    newWindowsTheming.ShowDialog();
                    break;
                case "BlendBehaviour":
                    var behaviourBlend = new Scenarios.Medium.Behaviour();
                    behaviourBlend.ShowDialog();
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
                case "Triggers":
                    var triggersScenario = new Scenarios.Medium.TriggersScenario();
                    triggersScenario.ShowDialog();
                    break;

                case "DepencyProperty":
                    var depencyProperty = new Scenarios.Medium.DepencyPropertiesScenario();
                    depencyProperty.ShowDialog();
                    break;
                case "SimpleAttachedProperty":
                    var simpleAttachedProperty = new Scenarios.Basic.SimpleAttachScenario();
                    simpleAttachedProperty.ShowDialog();
                    break;
                case "ComplexAttachedProperty":
                    var complexAttachedProperty = new Scenarios.Medium.AttachedPropertyScenario();
                    complexAttachedProperty.ShowDialog();
                    break;
                case "Canvas":
                    var canvas = new Scenarios.Medium.CanvasScenario();
                    canvas.ShowDialog();
                    break;

            }
        }

        
    }
}
