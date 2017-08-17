//Task.WhenAll()：等待一组任务完成，当所有任务都完成时，返回一个完成的 Task 对象
//使用 Task.WhenAll 时，一般只处理第一个错误就足够了，没必要要处理所有的错误

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace _0204等待一组任务完成
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private static async Task M()
        {
            var task1 = Task.Delay(TimeSpan.FromSeconds(1));
            var task2 = Task.Delay(TimeSpan.FromSeconds(2));
            var task3 = Task.Delay(TimeSpan.FromSeconds(1));

            await Task.WhenAll(task1, task2, task3);
        }

        private static async Task M2()
        {
            var task1 = Task.FromResult(3);
            var task2 = Task.FromResult(5);
            var task3 = Task.FromResult(7);

            var results = await Task.WhenAll(task1, task2, task3);

            //public static Task<TResult[]> WhenAll<TResult>(IEnumerable<Task<TResult>> tasks); 不建议使用
        }

        private static async Task<string> DownloadAllAsync(IEnumerable<string> urls)
        {
            var httpClient = new HttpClient();

            //定义每一个 url 的使用方法
            var downloads = urls.Select(url => httpClient.GetStringAsync(url));
            //注意，到这里，序列还没有求值，所以所有任务都还没真正启动

            //下面，所有的 url 下载同步开始
            var downloadTasks = downloads.ToArray();
            //到这里，所有任务已经开始执行

            //用异步方式等待所有下载完成
            var htmlPages = await Task.WhenAll(downloadTasks);

            return string.Concat(htmlPages);
        }

        private static async Task ThrowNotImplementedExceptionAsync()
        {
            await Task.Delay(0);

            throw new NotImplementedException();
        }

        private static async Task ThrowInvalidOperationExceptionAsync()
        {
            await Task.Delay(0);

            throw new InvalidOperationException();
        }

        private static async Task ObserveOneExceptionAsync()
        {
            var task1 = ThrowInvalidOperationExceptionAsync();
            var task2 = ThrowNotImplementedExceptionAsync();

            try
            {
                await Task.WhenAll(task1, task2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static async Task ObserveAllExceptionAsync()
        {
            var task1 = ThrowInvalidOperationExceptionAsync();
            var task2 = ThrowNotImplementedExceptionAsync();

            var allTasks = Task.WhenAll(task1, task2);

            try
            {
                await allTasks;
            }
            catch (Exception)
            {
                var allException = allTasks.Exception;

                Console.WriteLine(allException);
                throw;
            }
        }
    }
}