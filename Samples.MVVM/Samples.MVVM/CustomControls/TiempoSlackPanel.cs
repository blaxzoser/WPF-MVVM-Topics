using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Samples.MVVM.CustomControls
{
    public class TiempoSlackPanel : StackPanel
    {
        public static readonly DependencyProperty IsRedBackgroundProperty =
         DependencyProperty.RegisterAttached("IsRedBackground",
             typeof(bool),
             typeof(TiempoSlackPanel),
             new PropertyMetadata(false,
                 new PropertyChangedCallback(OnIsRedBackgroundChanged)
                 ));

        //Never put logic in that place
        public bool IsRedBackground
        {
            get { return (bool)GetValue(IsRedBackgroundProperty); }
            set { SetValue(IsRedBackgroundProperty, value); }
        }

        private static void OnIsRedBackgroundChanged(DependencyObject source,DependencyPropertyChangedEventArgs e)
        {
            TiempoSlackPanel panel = source as TiempoSlackPanel;
            if (panel.IsRedBackground)
                panel.Background = System.Windows.Media.Brushes.Red;
            else
                panel.Background = System.Windows.Media.Brushes.White;
        }

    }
}
