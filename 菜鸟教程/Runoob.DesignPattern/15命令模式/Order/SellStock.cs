namespace _15命令模式.Order
{
    internal class SellStock : IOrder
    {
        private readonly Stock _abcStock;

        public SellStock(Stock stock)
        {
            _abcStock = stock;
        }

        public void Execute()
        {
            _abcStock.Sell();
        }
    }
}