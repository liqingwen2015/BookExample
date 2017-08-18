using System.Collections.Generic;
using System.Linq;

namespace _0305并行LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private static IEnumerable<int> MultiplyBy2(IEnumerable<int> values)
        {
            return values.AsParallel().Select(item => item * 2);
        }

        /// <summary>
        /// 按照 LINQ 的默认方式，这个例子中输出数据队列额次数是不固定的。可以指明保持原来的次序。下面的例子可以并行执行，但是保留了数据的原有次序
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private static IEnumerable<int> MultiplyBy3(IEnumerable<int> values)
        {
            return values.AsParallel().AsOrdered().Select(item => item * 2);
        }

        private static int ParallelSum(IEnumerable<int> values)
        {
            return values.AsParallel().Sum();
        }
    }
}