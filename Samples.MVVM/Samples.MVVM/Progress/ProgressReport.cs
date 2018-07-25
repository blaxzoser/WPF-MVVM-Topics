using Samples.MVVM.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Samples.MVVM.Progress
{
    public class ProgressReport : BindableBase
    {
        int percentage;
        public int Percentage
        {
            get { return percentage; }
            set { SetProperty(ref percentage, value); }
        }

        string message;
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        public void HandleReportProgress(int percentage)
        {
            this.Percentage = percentage;
        }

        public ProgressReport(string computationName)
        {
            if (string.IsNullOrEmpty(computationName)) throw new ArgumentException("computationName");
            this.percentage = 0;
            this.message = computationName + " progreso: ";
        }


    }
}
