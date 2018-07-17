using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Samples.Services
{
    public class ServiceFake : IFakeService
    {
        public  async Task<int> CountBytesInUrlAsync(string url)
        {
            await Task.Delay(TimeSpan.FromSeconds(5)).ConfigureAwait(false);
            using (var client = new HttpClient())
            {
                var data = await client.GetByteArrayAsync(url).ConfigureAwait(false);
                return data.Length;
            }
        }

        public async Task<int> CountBytesInUrlAsyncExpection(string url)
        {
            await Task.Delay(TimeSpan.FromSeconds(5)).ConfigureAwait(false);
            using (var client = new HttpClient())
            {
                var data = await client.GetByteArrayAsync(url).ConfigureAwait(false);
                throw new  Exception("Test TEST TEST");
                return data.Length;
            }
        }


        public  async Task<int> DownloadAndCountBytesAsync(string url,CancellationToken token = new CancellationToken())
        {
            await Task.Delay(TimeSpan.FromSeconds(10), token).ConfigureAwait(false);
            var client = new HttpClient();
            using (var response = await client.GetAsync(url, token).ConfigureAwait(false))
            {
                var data = await
                  response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
                return data.Length;
            }
        }

        public async Task<int> DownloadAndCountBytesAsync(string url)
        {
            await Task.Delay(TimeSpan.FromSeconds(10)).ConfigureAwait(false);
            using (var client = new HttpClient())
            {
                var data = await
                  client.GetByteArrayAsync(url).ConfigureAwait(false);
                return data.Length;
            }
        }
    }
}
