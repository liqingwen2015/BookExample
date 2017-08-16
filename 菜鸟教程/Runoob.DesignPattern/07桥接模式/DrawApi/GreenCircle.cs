#region

using System;

#endregion

namespace _07桥接模式.DrawApi
{
    internal class GreenCircle : IDrawApi
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine(nameof(GreenCircle));
            Console.WriteLine($"Radius: {radius}; X: {x}; Y: {y}");
        }
    }
}