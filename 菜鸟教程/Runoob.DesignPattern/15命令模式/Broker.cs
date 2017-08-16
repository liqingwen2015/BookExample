#region

using System.Collections.Generic;
using _15命令模式.Order;

#endregion

namespace _15命令模式
{
    internal class Broker
    {
        private readonly IList<IOrder> _orders = new List<IOrder>();

        public void TaskOrder(IOrder order)
        {
            _orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
                order.Execute();

            _orders.Clear();
        }
    }
}