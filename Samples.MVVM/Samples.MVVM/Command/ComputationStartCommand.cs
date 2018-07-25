using Samples.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Samples.MVVM.Command
{
    public class ComputationStartCommand : ICommand
    {
        Action<int> ReportProgress { get; set; }
        IComputation Computation { get; set; }

        public ComputationStartCommand(IComputation computation, Action<int> reportProgress)
        {
            this.Computation = computation;
            this.ReportProgress = reportProgress;
        }

        public bool CanExecute(object parameter)
        {
            return !this.Computation.IsExectuting;
        }

        public void Execute(object parameter)
        {
            this.Computation.Execute(this.ReportProgress);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

    }
}
