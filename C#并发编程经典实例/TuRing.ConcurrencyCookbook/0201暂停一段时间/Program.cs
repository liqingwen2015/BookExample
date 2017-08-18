using System;
using System.Net.Http;
using System.Threading.Tasks;

/// <summary>
/// Task.Delay 适合用于对异步代码进行单元测试或者实现重试逻辑。要实现超时功能的话，最好使用 CancellationToken。
/// </summary>
namespace _0201暂停一段时间
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Read();
        }

        /// <summary>
        /// 延迟结果
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        /// <param name="delay"></param>
        /// <returns></returns>
        private static async Task<T> DelayResult<T>(T result, TimeSpan delay)
        {
            await Task.Delay(delay);
            return result;
        }

        /// <summary>
        /// 下载字符串（含重试）
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        /// <remarks>在访问 Web 服务时，最好的方式就是采用指数退避，它可以防止服务器被太多的重试阻塞</remarks>
        private static async Task<string> DownloadStringWithRetries(string uri)
        {
            using (var client = new HttpClient())
            {
                //第1次重试前等1秒，第2次等2秒，第三次等4秒
                var nextDelay = TimeSpan.FromSeconds(1);

                for (var i = 0; i != 3; i++)
                {
                    try
                    {
                        return await client.GetStringAsync(uri);
                    }
                    catch (Exception)
                    {
                    }

                    await Task.Delay(nextDelay);
                    nextDelay = nextDelay + nextDelay;
                }

                //最后重试一次，以便让调用者知道出错信息
                return await client.GetStringAsync(uri);
            }
        }

        /// <summary>
        /// 下载字符串（含超时判断）
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        /// <remarks>如果服务在3秒内没有响应，就返回 null</remarks>
        private static async Task<string> DownloadStringWithTimeout(string uri)
        {
            using (var client = new HttpClient())
            {
                var downloadTask = client.GetStringAsync(uri);
                var timeoutTask = Task.Delay(3000);

                var completedTask = await Task.WhenAny(downloadTask, timeoutTask);
                if (completedTask == timeoutTask)
                {
                    return null;
                }

                return await downloadTask;
            }
        }
    }
}