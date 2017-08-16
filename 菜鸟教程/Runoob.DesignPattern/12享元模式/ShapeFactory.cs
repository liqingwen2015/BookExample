#region

using System;
using System.Collections.Generic;
using _12享元模式.Shape;

#endregion

namespace _12享元模式
{
    internal class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> StringToShapeDict = new Dictionary<string, IShape>();

        public static IShape GetShape(string color)
        {
            IShape shape;
            var isOk = StringToShapeDict.TryGetValue(color, out shape);

            if (isOk)
                return shape;

            shape = new Circle(color);
            StringToShapeDict.Add(color, shape);
            Console.WriteLine($"Color: {color} 已添加。");

            return shape;
        }
    }
}