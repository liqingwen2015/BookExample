#region

using System;

#endregion

namespace 工厂模式
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Circle));
        }
    }
}