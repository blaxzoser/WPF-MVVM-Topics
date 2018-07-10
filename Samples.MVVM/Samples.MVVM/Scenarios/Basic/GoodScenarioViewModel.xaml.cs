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
    //--Added scenario B:
    //-Create good approach to MVVM
    //-Implement INotifyPropertyChanged
    //-Use Extra Class like a Model
    //-Improve scenario A
    /// </summary>
    public partial class GoodScenarioViewModel : Window
    {
        public GoodScenarioViewModel()
        {
            InitializeComponent();
        }
    }
}
