#region

using System;
using _13代理模式.Image;

#endregion

namespace _13代理模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            image.Display();
            Console.WriteLine();

            image.Display();

            Console.Read();
        }
    }
}