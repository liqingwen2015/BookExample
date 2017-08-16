using System;
using _20观察者模式.Observer;

namespace _20观察者模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var subject = new Subject();

            subject.Attach(new BinaryObserver());
            subject.Attach(new OctalObserver());
            subject.Attach(new BinaryObserver());

            Console.WriteLine("First state change: 15");
            subject.SetState(15);

            Console.WriteLine();

            Console.WriteLine("Second state change: 10");
            subject.SetState(10);

            Console.Read();
        }
    }
}