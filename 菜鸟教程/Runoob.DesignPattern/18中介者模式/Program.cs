#region

using System;

#endregion

namespace _18中介者模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var robert = new User("Robert");
            var john = new User("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");

            Console.Read();
        }
    }
}