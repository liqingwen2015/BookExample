#region

using System;
using Common;

#endregion

namespace _15命令模式
{
    internal class Stock
    {
        public string Name { get; } = "ABC";

        public int Quantity { get; } = 10;


        public void Buy()
        {
            Console.WriteLine($"Bought: {this.ToJson()}");
        }

        public void Sell()
        {
            Console.WriteLine($"Sold： {this.ToJson()}");
        }
    }
}