//执行多个任务，只需要对其中任意一个的完成进行响应。如：同时向多个 Web 服务询问股票价格，但只关心第一个响应的。
//Task.WhenAny

using System.Net.Http;
using System.Threading.Tasks;

namespace _0205等待任意一个任务完成
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// 返回第一个响应的 url 的数据长度
        /// </summary>
        /// <param name="urlA"></param>
        /// <param name="urlB"></param>
        /// <returns></returns>
        private static async Task<int> FirstRespondingUrlAsync(string urlA, string urlB)
        {
            var httpClient = new HttpClient();

            //并发地开始两个下载任务
            var downloadTaskA = httpClient.GetByteArrayAsync(urlA);
            var downloadTaskB = httpClient.GetByteArrayAsync(urlB);

            //等待任意一个任务完成
            var comletedTask = await Task.WhenAny(downloadTaskA, downloadTaskB);

            //返回从 url 得到的数据长度
            var data = await comletedTask;
            return data.Length;
        }
    }
}
