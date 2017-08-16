#region

using System;

#endregion

namespace _02抽象工厂模式
{
    internal class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine(nameof(Red));
        }
    }
}