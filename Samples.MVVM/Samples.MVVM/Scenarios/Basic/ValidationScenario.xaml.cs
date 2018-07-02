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
    ///Added Scenario F Validations:
    //-How to use a INotifyDataErrorInfo
    //-Refactor INotifyPropertyChanged
    //-Put Style in errors in the View
    //-Validation Approach
    /// </summary>
    public partial class ValidationScenario : Window
    {
        public ValidationScenario()
        {
            InitializeComponent();
        }
    }
}
