using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Samples.MVVM.Command
{
    public class RelayCommand : ICommand
    {
        Action _tarjetExecuteMethod;
        Func<bool> _tarjetCanExecuteMethod;

        public RelayCommand(Action excecutedMethod)
        {
            _tarjetExecuteMethod = excecutedMethod;
        }
        public RelayCommand(Action excecutedMethod, Func<bool> canExecuteMethod)
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
            if(_tarjetCanExecuteMethod != null)
            {
                return _tarjetCanExecuteMethod();
            }
            if(_tarjetExecuteMethod != null)
            {
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            if(_tarjetExecuteMethod != null)
            { _tarjetExecuteMethod(); }
        }

       

        #endregion

    }
}
