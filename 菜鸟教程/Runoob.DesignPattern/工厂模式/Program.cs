#region

using System;

#endregion

namespace 工厂模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shape = ShapeFactory.GetShape("circle");
            shape.Draw();

            Console.Read();
        }
    }
}