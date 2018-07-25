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

namespace Samples.MVVM.View
{
    /// <summary>
    /// Interaction logic for DesignTimeView.xaml
    /// </summary>
    public partial class DesignTimeView : UserControl
    {
        public DesignTimeView()
        {
            InitializeComponent();
            this.root.DataContext = this;
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            if (oldContent != null) throw new InvalidOperationException("El contenido no puede ser modificado");
        }

        public static readonly DependencyProperty PercentageProperty =
        DependencyProperty.Register("Percentage", typeof(int), typeof(DesignTimeView));
        public int Percentage
        {
            get { return (int)GetValue(PercentageProperty); }
            set { SetValue(PercentageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(DesignTimeView));
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty CancelCommandProperty =
            DependencyProperty.Register("CancelCommand", typeof(ICommand), typeof(DesignTimeView));
        public ICommand CancelCommand
        {
            get { return (ICommand)GetValue(CancelCommandProperty); }
            set { SetValue(CancelCommandProperty, value); }
        }
    }
}
