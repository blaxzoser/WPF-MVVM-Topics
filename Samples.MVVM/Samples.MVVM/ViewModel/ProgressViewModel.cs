using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Samples.MVVM.ViewModel
{
    public class ProgressViewModel
    {
        public int Percentage { get; private set; }

        public string Message { get; private set; }

        public ICommand CancelCommand { get; private set; }

        public ProgressViewModel()
        {
            this.Percentage = 20;
            this.Message = "Progreso";
            this.CancelCommand = null;
        }
    }
}
