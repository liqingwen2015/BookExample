using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace _0301数据的并行处理
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private void RotateMatrices(IEnumerable<int> times, int value)
        {
            Parallel.ForEach(times, time => Console.WriteLine(value));
        }

        private void InvertMatrices(IEnumerable<int> times)
        {
            Parallel.ForEach(times, (time, state) =>
            {
                if (time == 5)
                    state.Stop();
                else
                    Console.WriteLine(time);
            });
        }

        /// <summary>
        /// </summary>
        /// <param name="times"></param>
        /// <param name="value"></param>
        /// <param name="token"></param>
        /// <remarks>比之前增加了取消选项，结束循环是在循环内部进行，而取消循环是在循环外部进行的</remarks>
        private void RotateMatrices(IEnumerable<int> times, int value, CancellationToken token)
        {
            Parallel.ForEach(times,
                new ParallelOptions { CancellationToken = token },
                time => Console.WriteLine($"{time}: {value}"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="times"></param>
        /// <returns></returns>
        /// <remarks>加入共享保护（锁），但这并不是最高效的方式</remarks>
        private int InvertMatrices2(IEnumerable<int> times)
        {
            var mutex = new object();
            var nonInvertibleCount = 0;

            Parallel.ForEach(times, time =>
            {
                if (time != 5)
                    Console.WriteLine(time);
                else
                    lock (mutex)
                    {
                        nonInvertibleCount++;
                    }
            });

            return nonInvertibleCount;
        }
    }
}