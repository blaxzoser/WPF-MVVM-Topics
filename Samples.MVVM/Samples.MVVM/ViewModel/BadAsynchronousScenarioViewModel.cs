using Samples.MVVM.Library;
using Samples.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class BadAsynchronousScenarioViewModel : BindableBase
    {
        private  readonly ServiceFake _serviceFake;
        private int _urlByteCount;
        public int UrlByteCount
        {
            get { return _urlByteCount; }
            private set { SetProperty(ref _urlByteCount, value); }
        }

        public BadAsynchronousScenarioViewModel()
        {
            _serviceFake = new ServiceFake();
            Load();
        }

        public async void Load()
        {
            UrlByteCount = await _serviceFake.CountBytesInUrlAsync("http://www.salon51.com.mx");
        }
    }
}
