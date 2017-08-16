#region

using System;
using _07桥接模式.DrawApi;
using _07桥接模式.Shape;

#endregion

namespace _07桥接模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BaseShape redCircle = new Circle(100, 100, 10, new RedCircle());
            BaseShape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();

            Console.Read();
        }
    }
}