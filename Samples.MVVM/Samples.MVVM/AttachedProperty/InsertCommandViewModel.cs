using Samples.MVVM.Command;
using Samples.MVVM.ViewModel;
using Samples.MVVM.AttachedProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.AttachedProperty
{
    public class InsertCommandViewModel : AttachedPropertiesViewModel<ViewModel>
    {
        public RelayCommand IncrementCommand => new RelayCommand(() => Increment());

        private void Increment()
        {
            ViewModel.Counter++;
        }
    }
}