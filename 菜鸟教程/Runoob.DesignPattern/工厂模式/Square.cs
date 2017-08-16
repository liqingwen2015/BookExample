#region

using System;

#endregion

namespace 工厂模式
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Square));
        }
    }
}