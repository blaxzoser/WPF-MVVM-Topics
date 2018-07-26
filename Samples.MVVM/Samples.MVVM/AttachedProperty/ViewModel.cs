using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Samples.MVVM.AttachedProperty
{
    public class ViewModel : INotifyPropertyChanged
    {
        private int _counter;

        public int Counter
        {
            get { return _counter; }
            set { _counter = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
