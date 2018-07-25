using Samples.MVVM.ViewModel;
using Samples.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Samples.MVVM.Command
{
    public class ComputationCancelCommand : ICommand
    {
        DesignTimeViewModel ViewModel { get; set; }
        IComputation Computation { get; set; }

        public ComputationCancelCommand(IComputation computation)
        {
            this.Computation = computation;
        }

        public bool CanExecute(object parameter)
        {
            return this.Computation.IsExectuting;
        }

        public void Execute(object parameter)
        {
            this.Computation.Cancel();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
