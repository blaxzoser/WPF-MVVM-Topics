using Samples.MVVM.Library;
using Samples.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class GoodAsyncScenarioViewModel
    {
        private readonly ServiceFake _serviceFake;
        public NotifyTaskCompletion<int> UrlByteCount { get; private set; }
        public GoodAsyncScenarioViewModel()
        {
            _serviceFake = new ServiceFake();
            UrlByteCount = new NotifyTaskCompletion<int>(
                _serviceFake.CountBytesInUrlAsyncExpection("http://www.salon51.com.mx")
                );
        }


    }
}
