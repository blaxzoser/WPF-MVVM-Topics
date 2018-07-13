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
        public string Url { get; set; }
        public IAsyncCommand CountUrlBytesCommand { get; private set; }
        public int ByteCount { get; private set; }
        private ServiceFake _service;

        public CommandAsyncScenarioViewModel()
        {
            Url = "http://www.salon51.com.mx/";
            _service = new ServiceFake();
            CountUrlBytesCommand = new AsyncCommand<int>(() =>           
              _service.DownloadAndCountBytesAsync(Url)
            );

        }
    }
}
