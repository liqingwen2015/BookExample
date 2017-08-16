#region

using System;
using _15命令模式.Order;

#endregion

namespace _15命令模式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var abcStock = new Stock();

            var buyStockOrder = new BuyStock(abcStock);
            var sellStockOrder = new SellStock(abcStock);

            var broker = new Broker();
            broker.TaskOrder(buyStockOrder);
            broker.TaskOrder(sellStockOrder);

            broker.PlaceOrders();

            Console.Read();
        }
    }
}