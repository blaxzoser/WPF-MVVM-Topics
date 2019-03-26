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
    /// Interaction logic for EventsScenarioxaml.xaml
    /// </summary>
    public partial class EventsScenario : Window
    {
        public EventsScenario()
        {
            InitializeComponent();
        }

        private void CommonClickHandler(object sender, RoutedEventArgs e)
        {
            FrameworkElement feSource = e.Source as FrameworkElement;
            switch (feSource.Name)
            {
                case "YesButton":
                    MessageBox.Show("Yes");
                    break;
                case "NoButton":
                    MessageBox.Show("No");
                    break;
                case "CancelButton":
                    MessageBox.Show("Cancel");
                    break;
            }
            e.Handled = false;
        }

        private void YesButton_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("2");
        }
    }
}
