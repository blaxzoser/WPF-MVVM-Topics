using Samples.MVVM.Command;
using Samples.MVVM.Library;
using Samples.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.MVVM.ViewModel
{
    public class CommandAsyncScenarioViewModel : BindableBase
    {
        public string _Url;
        public string Url
        {
            get { return _Url; }
            set { SetProperty(ref _Url, value); }

        }
        public IAsyncCommand CountUrlBytesCommand { get; private set; }
        public int ByteCount { get; private set; }
        private ServiceFake _service;

        public CommandAsyncScenarioViewModel()
        {
            Url = "http://www.salon51.com.mx/";
            _service = new ServiceFake();
            CountUrlBytesCommand = AsyncCommand.Create(token => _service.DownloadAndCountBytesAsync(Url, token));

        }
    }
}
