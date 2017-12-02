namespace ASPPatterns.Chap3.Layered.Model
{
    public class TradeDiscountStrategy:IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal originalSalePrice)
        {
            return originalSalePrice * 0.95M;
        }
    }
}
