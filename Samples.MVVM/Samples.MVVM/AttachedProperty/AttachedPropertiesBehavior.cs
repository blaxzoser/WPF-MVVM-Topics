using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;

namespace Samples.MVVM.AttachedProperty
{
    public class AttachedPropertiesBehavior
    {
        public Type Type { get; set; }

        #region static part
        // Using a DependencyProperty as the backing store for AttachedPropertyType.  This enables animation, styling, binding
        public static readonly DependencyProperty ViewModelTypeProperty
            = DependencyProperty.RegisterAttached("ViewModelType", typeof(Type), typeof(AttachedPropertiesBehavior),
                new PropertyMetadata(null, delegate (DependencyObject o, DependencyPropertyChangedEventArgs args)
                {
                    new AttachedPropertiesBehavior(o, (Type)args.NewValue);
                }));

        public static Type GetViewModelType(FrameworkElement control)
        {
            return (Type)control.GetValue(ViewModelTypeProperty);
        }

        public static void SetViewModelType(FrameworkElement control, Type value)
        {
            control.SetValue(ViewModelTypeProperty, value);
        }
        #endregion static part

        #region instance part
        private bool _isBusy;
        private readonly FrameworkElement _frameworkElement;

        public AttachedPropertiesBehavior(object sender, Type type)
        {
            _frameworkElement = (FrameworkElement)sender;
            CreateNewDataContext(type);
            _frameworkElement.DataContextChanged += (s, args) => CreateNewDataContext((Type)args.NewValue);
        }

        private void CreateNewDataContext(Type type)
        {
            if (_isBusy) return;
            _isBusy = true;
            Debug.Assert(_frameworkElement.DataContext != null, $"The was no DataContext for FrameworkElement");
            var newDataContext = Activator.CreateInstance(type);
            Debug.Assert(newDataContext != null, $"Could not create an instance of type {type}");
            var property = type.GetProperty("ViewModel");
            Debug.Assert(newDataContext != null, $"Could not access a 'ViewModel' property for type {type}");
            property.SetValue(newDataContext, _frameworkElement.DataContext);
            _frameworkElement.DataContext = newDataContext;
            _isBusy = false;
        }
        #endregion instance part
    }
}
