using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.AttachedProperty
{
    public abstract class AttachedPropertiesViewModel<T>
    {
        public T ViewModel { set; protected get; }
    }
}
