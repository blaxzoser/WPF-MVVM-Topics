using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Services
{
    public interface IFakeService
    {
        Task<int> DownloadAndCountBytesAsync(string url);
    }
}
