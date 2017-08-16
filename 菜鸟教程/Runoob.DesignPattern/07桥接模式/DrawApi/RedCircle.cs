#region

using System;

#endregion

namespace _07桥接模式.DrawApi
{
    internal class RedCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine(nameof(RedCircle));
            Console.WriteLine($"Radius: {radius}; X: {x}; Y: {y}");
        }
    }
}