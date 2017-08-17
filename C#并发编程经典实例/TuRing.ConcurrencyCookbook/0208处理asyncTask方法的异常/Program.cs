using System;
using System.Threading.Tasks;

namespace _0208处理asyncTask方法的异常
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static async Task ThrowExceptionAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            throw new InvalidOperationException("Test");
        }

        static async Task TestAsync()
        {
            try
            {
                await ThrowExceptionAsync();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static async Task TestAsync2()
        {
            //抛出异常并将其存储在 Task 中
            var task = ThrowExceptionAsync();

            try
            {
                //Task 对象被 await 调用，异常在这里再次被引发
                await task;
            }
            catch (InvalidOperationException e)
            {
                //这里，异常被正常地捕获
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
