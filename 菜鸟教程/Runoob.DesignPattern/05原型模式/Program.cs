#region

using System;

#endregion

namespace _05原型模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapeCache = new ShapeCache();

            var circle1 = shapeCache.GetShape(1);
            var circle2 = shapeCache.GetShape(1);

            Console.WriteLine(circle1.Name);
            Console.WriteLine(circle2.Name);
            Console.WriteLine(circle2 == circle1);

            Console.Read();
        }
    }
}