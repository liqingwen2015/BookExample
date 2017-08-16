#region

using System;
using _12享元模式.Shape;

#endregion

namespace _12享元模式
{
    internal class Program
    {
        private static readonly string[] Colors =
            {"Red", "Green", "Blue", "White", "Black"};

        private static readonly Random Random = new Random();


        private static void Main(string[] args)
        {
            for (var i = 0; i < 20; ++i)
            {
                var circle =
                    (Circle) ShapeFactory.GetShape(GetRandomColor());

                circle.X = GetRandomX();
                circle.Y = GetRandomY();
                circle.Color = GetRandomColor();
                circle.Radius = 100;

                circle.Draw();
            }

            Console.Read();
        }

        private static string GetRandomColor()
        {
            return Colors[Random.Next(Colors.Length)];
        }

        private static int GetRandomX()
        {
            return Random.Next(5) * 100;
        }

        private static int GetRandomY()
        {
            return Random.Next(5) * 100;
        }
    }
}