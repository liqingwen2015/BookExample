#region

using System;
using _21状态模式.State;

#endregion

namespace _21状态模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new Context();

            var startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.State);

            var stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.State);

            Console.Read();
        }
    }
}