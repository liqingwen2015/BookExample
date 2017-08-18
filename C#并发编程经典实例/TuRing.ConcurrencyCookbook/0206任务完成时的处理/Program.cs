using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _0206任务完成时的处理
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private static async Task<int> DelayAndReturnAsync(int val)
        {
            await Task.Delay(TimeSpan.FromSeconds(0));
            return val;
        }

        /// <summary>
        /// 当前，此方法输出 2,3,1
        /// 我们希望输出 1,2,3（见解决方案 1）
        /// </summary>
        /// <returns></returns>
        private static async Task ProcessTaskAnsyc()
        {
            //创建任务队列
            var taskA = DelayAndReturnAsync(2);
            var taskB = DelayAndReturnAsync(3);
            var taskC = DelayAndReturnAsync(1);
            var tasks = new[] {taskA, taskB, taskC};

            //按顺序 await 每个任务
            foreach (var task in tasks)
            {
                var result = await task;
                Trace.WriteLine(result);
            }
        }

        private static async Task AwaitAndProcessAsync(Task<int> task)
        {
            var result = await task;
            Trace.WriteLine(result);
        }

        #region 解决方案 1

        /// <summary>
        /// 现在，这个方法输出 1,2,3
        /// </summary>
        /// <returns></returns>
        private static async Task ProcessTaskAnsyc2()
        {
            //创建任务队列
            var taskA = DelayAndReturnAsync(2);
            var taskB = DelayAndReturnAsync(3);
            var taskC = DelayAndReturnAsync(1);
            var tasks = new[] {taskA, taskB, taskC};

            var processingTasks = (from t in tasks select AwaitAndProcessAsync(t)).ToArray();

            //等待全部处理过程的完成
            await Task.WhenAll(processingTasks);
        }

        #endregion 解决方案 1

        #region 解决方案 2

        /// <summary>
        /// 现在，这个方法输出 1,2,3
        /// </summary>
        /// <returns></returns>
        private static async Task ProcessTaskAnsyc3()
        {
            //创建任务队列
            var taskA = DelayAndReturnAsync(2);
            var taskB = DelayAndReturnAsync(3);
            var taskC = DelayAndReturnAsync(1);
            var tasks = new[] {taskA, taskB, taskC};

            var processingTasks = tasks.Select(async t =>
            {
                var result = await t;
                Trace.WriteLine(result);
            }).ToArray();

            //等待全部处理过程的完成
            await Task.WhenAll(processingTasks);
        }

        #endregion 解决方案 2
    }
}