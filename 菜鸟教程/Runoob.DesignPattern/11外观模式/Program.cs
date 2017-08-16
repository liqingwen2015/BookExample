#region

using System;

#endregion

namespace _11外观模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();

            Console.Read();
        }
    }
}