#region

using System;

#endregion

namespace _11外观模式.Shape
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(nameof(Circle));
        }
    }
}