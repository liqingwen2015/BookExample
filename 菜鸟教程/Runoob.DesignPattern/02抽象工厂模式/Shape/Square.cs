#region

using System;

#endregion

namespace _02抽象工厂模式.Shape
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Square));
        }
    }
}