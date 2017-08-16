#region

using System;
using Common;

#endregion

namespace _12享元模式.Shape
{
    internal class Circle : IShape
    {
        public Circle(string color)
        {
            Color = color;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Radius { get; set; }

        public string Color { get; set; }

        public void Draw()
        {
            Console.WriteLine(this.ToJson());
        }
    }
}