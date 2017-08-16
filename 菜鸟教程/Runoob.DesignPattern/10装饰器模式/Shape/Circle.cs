#region

using System;

#endregion

namespace _10装饰器模式.Shape
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Circle));
        }
    }
}