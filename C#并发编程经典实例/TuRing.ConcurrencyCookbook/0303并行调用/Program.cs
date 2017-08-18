using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace _0303并行调用
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        /// <summary>
        /// 将一个数组分为两半，并且单独处理
        /// </summary>
        /// <param name="array"></param>
        private static void ProcessArray(double[] array)
        {
            Parallel.Invoke(() => ProcessPartialArray(array, 0, array.Length / 2));
            Parallel.Invoke(() => ProcessPartialArray(array, array.Length / 2, array.Length));
        }

        private static void ProcessPartialArray(double[] array, int begin, int end)
        {
            //计算密集型的处理过程
        }

        private static void AoAction20Times(Action action, CancellationToken token)
        {
            var actions = Enumerable.Repeat(action, 20).ToArray();
            Parallel.Invoke(new ParallelOptions { CancellationToken = token }, actions);
        }
    }
}