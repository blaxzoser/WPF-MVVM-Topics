using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Samples.MVVM.AttachedProperty
{
    public class GlobalAttachedProperty : DependencyObject
    {
        public static readonly DependencyProperty IsFakeSourceProperty = DependencyProperty.RegisterAttached(
            "IsFakeSource",
            typeof(Boolean),
            typeof(GlobalAttachedProperty),
            new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsArrange)
        );
        public static void SetIsFakeSource(DependencyObject element, Boolean value)
        {
            element.SetValue(IsFakeSourceProperty, value);
        }
        public static Boolean GetIsFakeSource(DependencyObject element)
        {
            return (Boolean)element.GetValue(IsFakeSourceProperty);
        }

    }
}
