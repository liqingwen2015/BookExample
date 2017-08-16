#region

using System;

#endregion

namespace _02抽象工厂模式.Color
{
    internal class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine(nameof(Blue));
        }
    }
}