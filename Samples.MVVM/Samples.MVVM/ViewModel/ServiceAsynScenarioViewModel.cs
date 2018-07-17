using Samples.MVVM.Library;
using Samples.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class ServiceAsynScenarioViewModel : BindableBase
    {
        private readonly IFakeService _service;
        public string _Url;
        public string Url
        {
            get { return _Url; }
            set { SetProperty(ref _Url, value); }

        }
        public NotifyTaskCompletion<int> UrlByteCount { get; private set; }
        public ServiceAsynScenarioViewModel(IFakeService fakeService)
        {
            _service = fakeService;
            Url = "http://www.salon.com.mx";
            UrlByteCount = new NotifyTaskCompletion<int>(
              _service.DownloadAndCountBytesAsync(Url)
              );

        }


        
    }
}
