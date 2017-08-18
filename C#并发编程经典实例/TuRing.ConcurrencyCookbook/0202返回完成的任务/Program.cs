using System;
using System.Threading.Tasks;

namespace _0202返回完成的任务
{
    internal class Program
    {
        /// <summary>
        /// ZeroTask
        /// </summary>
        /// <remarks>如果使用 Task.FromResult 反复调用同一个参数，可以考虑用一个实际的 task 变量，在以后的调用中都只使用这个变量，就无需额外创建变量，这样可以减少垃圾回收的次数。</remarks>
        private static readonly Task<int> ZeroTask = Task.FromResult(0);

        private static void Main(string[] args)
        {
        }

        private static Task<T> NotImplementedAsync<T>()
        {
            var tcs = new TaskCompletionSource<T>();
            tcs.SetException(new NotImplementedException());
            return tcs.Task; //Task.FromResult 是简化版本
        }

        private static Task<int> GetValueAsync()
        {
            return ZeroTask;
        }
    }

    internal interface IMyAsyncInterface
    {
        Task<int> GetValueAsync();
    }

    internal class MySynchronousImplemetation : IMyAsyncInterface
    {
        /// <summary>
        ///     获取值
        /// </summary>
        /// <returns></returns>
        /// <remarks>使用 Task.FromResult 方法创建并返回一个新的 Task<T /> 的对象</remarks>
        public Task<int> GetValueAsync()
        {
            return Task.FromResult(13);
        }
    }
}