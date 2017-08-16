#region

using System;
using _10装饰器模式.Shape;

#endregion

namespace _10装饰器模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape redCircle = new RedShapeDecorator(circle);
            IShape redRectangle = new RedShapeDecorator(new Rectangle());

            circle.Draw();
            Console.WriteLine();

            redCircle.Draw();
            Console.WriteLine();

            redRectangle.Draw();

            Console.Read();
        }
    }
}