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
using Samples.MVVM.Scenarios.Medium;

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
                case "DataTemplate":
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
                    var badScenario = new Scenarios.Basic.BadScenarioViewModel();
                    badScenario.ShowDialog();
                    break;
                case "GoodScenario":
                    var goodScenario = new Scenarios.Basic.GoodScenarioViewModel();
                    goodScenario.ShowDialog();
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
                case "CommandsVsEventsScenario":
                    var commandsVsEventsScenario = new Scenarios.Basic.CommandsVsEventsScenario();
                    commandsVsEventsScenario.ShowDialog();
                    break;
                case "RelativeSourceScenario":
                    var relativeSourceScenario = new Scenarios.Basic.RelativeSourceScenario();
                    relativeSourceScenario.ShowDialog();
                    break;
                case "ControlTemplate":
                    var ControlTemplate = new Scenarios.Basic.ControlTemplate();
                    ControlTemplate.ShowDialog();
                    break;
                case "ConvertsScenario":
                    var convertsScenario = new Scenarios.Basic.ConvertsScenario();
                    convertsScenario.ShowDialog();
                    break;
                case "ValidationScenario":
                    var validationScenario = new Scenarios.Basic.ValidationScenario();
                    validationScenario.ShowDialog();
                    break;
                case "ResourcesScenario":
                    var resourcesScenario = new Scenarios.Medium.ResourcesScenario();
                    resourcesScenario.ShowDialog();
                    break;
                case "PanelScenario":
                    var panelScenario = new Scenarios.Medium.PanelScenario();
                    panelScenario.ShowDialog();
                    break;
                case "GridLayoutScenario":
                    var gridLayoutScenario = new Scenarios.Medium.GridLayoutScenario();
                    gridLayoutScenario.ShowDialog();
                    break;
                case "ScrollViewerScenario":
                    var scrollViewerScenario = new Scenarios.Medium.ScrollViewerScenario();
                    scrollViewerScenario.ShowDialog();
                    break;
                case "ViewBoxScenario":
                    var viewBoxScenario = new Scenarios.Medium.ViewBoxScenario();
                    viewBoxScenario.ShowDialog();
                    break;




            }
        }

        
    }
}
