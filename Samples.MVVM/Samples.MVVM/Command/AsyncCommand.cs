using Samples.MVVM.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.Command
{
    public class AsyncCommand<TResult> : AsyncCommandBase, INotifyPropertyChanged
    {
        private readonly Func<Task<TResult>> _command;
        private NotifyTaskCompletion<TResult> _execution;

        public event PropertyChangedEventHandler PropertyChanged;

        public AsyncCommand(Func<Task<TResult>> command)
        {
            _command = command;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override Task ExecuteAsync(object parameter)
        {
            Execution = new NotifyTaskCompletion<TResult>(_command());
            return Execution.TaskCompletion;
        }
        // Raises PropertyChanged
        public NotifyTaskCompletion<TResult> Execution { get; private set; }
    }
}
