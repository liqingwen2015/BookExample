namespace _15命令模式.Order
{
    internal class BuyStock : IOrder
    {
        private readonly Stock _abcStock;

        public BuyStock(Stock stock)
        {
            _abcStock = stock;
        }

        public void Execute()
        {
            _abcStock.Buy();
        }
    }
}