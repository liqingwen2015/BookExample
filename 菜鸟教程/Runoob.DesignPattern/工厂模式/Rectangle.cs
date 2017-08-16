#region

using System;

#endregion

namespace 工厂模式
{
    internal class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Rectangle));
        }
    }
}