using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0302并行聚合
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        /// <remarks>只是举例用锁来保护共享状态，但这并不是最高效的方式</remarks>
        private static int ParallelSum(IEnumerable<int> values)
        {
            var mutex = new object();
            var result = 0;

            Parallel.ForEach(values,
                () => 0,
                (item, state, localValue) => localValue + item,
                localValue =>
                {
                    lock (mutex)
                    {
                        result += localValue;
                    }
                });

            return result;
        }

        /// <summary>
        /// PLINQ 简单使用
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static int ParalleSum(IEnumerable<int> values)
        {
            return values.AsParallel().Sum();
        }

        /// <summary>
        /// PLINQ 简单使用 2
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static int ParalleSum2(IEnumerable<int> values)
        {
            return values.AsParallel().Aggregate(0, (sum, item) => sum + item);
        }
    }
}