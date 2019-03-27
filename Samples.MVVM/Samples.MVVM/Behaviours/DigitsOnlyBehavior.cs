using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Samples.MVVM.Behaviours
{
    public static class DigitsOnlyBehavior
    {
        public static bool GetIsDigitOnly(DependencyObject obj)
        {
            return (bool) obj.GetValue(IsDigitOnlyProperty);
        }

        public static void SetIsDigitOnly(DependencyObject obj,
            bool value)
        {
            obj.SetValue(IsDigitOnlyProperty, value);
        }

        public static readonly DependencyProperty IsDigitOnlyProperty =
            DependencyProperty.RegisterAttached("IsDigitOnly",
                typeof(bool), typeof(DigitsOnlyBehavior),
                new PropertyMetadata(false, OnIsDigitOnlyChanged));

        private static void OnIsDigitOnlyChanged(object sender,
            DependencyPropertyChangedEventArgs e)
        {
            var textBlock = sender as TextBox;
            var value  = e.NewValue;
            MessageBox.Show(value.ToString() + textBlock.Text);
        }
    }
}