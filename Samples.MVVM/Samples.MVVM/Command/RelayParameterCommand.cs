using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Samples.MVVM.Command
{

    public class RelayParameterCommand<T> : ICommand
    {
        Action<T> _tarjetExecuteMethod;
        Predicate<T> _tarjetCanExecuteMethod;

        public RelayParameterCommand(Action<T> excecutedMethod)
        {
            _tarjetExecuteMethod = excecutedMethod;
        }
        public RelayParameterCommand(Action<T> excecutedMethod, Predicate<T> canExecuteMethod)
        {
            _tarjetExecuteMethod = excecutedMethod;
            _tarjetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        #region ICommand Members
        public event EventHandler CanExecuteChanged = delegate { };

        public bool CanExecute(object parameter)
        {
            return _tarjetCanExecuteMethod == null ? true : _tarjetCanExecuteMethod((T)parameter);
        }

        public void Execute(object parameter)
        {
            if (_tarjetExecuteMethod != null)
            { _tarjetExecuteMethod((T)parameter); }
        }



        #endregion

    }
}
