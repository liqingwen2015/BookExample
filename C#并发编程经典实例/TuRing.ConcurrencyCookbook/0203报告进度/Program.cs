//Progress<T> 中的 T 最好是不可变类型，或者是值类型。如果 T 是一个可变的引用类型，那么每次在调用 IProgress.Report() 前都应该要创建一个副本
//如果一个方法可以报告进度，就应该做到尽量取消。

using System;
using System.Threading.Tasks;

namespace _0203报告进度
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private static async Task MyMethodAsync(IProgress<double> progress = null)
        {
            double percentComplete = 0;
            while (percentComplete <= 5)
            {
                //...
                progress?.Report(percentComplete);

                percentComplete++;
            }

            await Task.Delay(0);
        }

        private static async Task CallMyMethodAsync()
        {
            var progress = new Progress<double>();
            progress.ProgressChanged += (s, e) => { };

            await MyMethodAsync(progress);
        }
    }
}