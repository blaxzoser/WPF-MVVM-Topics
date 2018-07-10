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

namespace Samples.MVVM.Scenarios.Basic
{
    /// <summary>
    /// Basic Scenario A in  MVVM
    //-Simple approach Binding MVVM
    //-Common mistakes in Binding
    //-Issues List vs ObservableCollection
    //-Sample bad practice to use events
    //-Sample Properties
    //-Use ItemTemplate for Combo Box, ListView with Binding
    //-Use some Tricks to communication ViewMode and View(not recomment, its a hack)
    /// </summary>
    public partial class BadScenarioViewModel : Window
    {
        public BadScenarioViewModel()
        {
            InitializeComponent();
        }
    }
}
