using System;
using _23策略模式.Strategy;

namespace _23策略模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var context = new Context(new OperationAdd());

            Console.WriteLine("10+5=");
            Console.WriteLine(context.ExecuteStrategy(10, 5));
            Console.WriteLine();

            context = new Context(new OperationSubstract());

            Console.WriteLine("10-5=");
            Console.WriteLine(context.ExecuteStrategy(10, 5));
            Console.WriteLine();

            context = new Context(new OperationMultiply());

            Console.WriteLine("10*5=");
            Console.WriteLine(context.ExecuteStrategy(10, 5));
            Console.WriteLine();

            Console.Read();
        }
    }
}