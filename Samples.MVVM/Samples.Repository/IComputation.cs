using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Repository
{
    public interface IComputation
    {
        string Name { get; }
        void Execute(Action<int> onReportProgress);
        bool IsExectuting { get; }
        void Cancel();
    }
}
