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