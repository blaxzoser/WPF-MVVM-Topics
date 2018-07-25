using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Samples.MVVM.ViewModel;
using Samples.MVVM.Library;
using Samples.Repository;
using Samples.MVVM.Progress;
using Samples.MVVM.Command;

namespace Samples.MVVM.ViewModel
{
    public class DesignTimeViewModel : BindableBase
    {
        public ProgressReport Report { get; protected set; }
        public Computation computation;

        public ICommand ComputationStart { get; protected set; }
        public ICommand ComputationCancel { get; protected set; }

        public DesignTimeViewModel()
        {
            this.computation = new Computation();
            this.Report = new ProgressReport(this.computation.Name);
            this.ComputationStart = new ComputationStartCommand(this.computation, this.Report.HandleReportProgress);
            this.ComputationCancel = new ComputationCancelCommand(this.computation);
        }
    }
}
