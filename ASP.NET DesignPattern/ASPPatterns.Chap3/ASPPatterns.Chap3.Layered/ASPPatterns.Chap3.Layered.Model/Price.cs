namespace ASPPatterns.Chap3.Layered.Model
{
    public class Price
    {
        private IDiscountStrategy _discountStrategy = new NullDiscountStrategy();
        private decimal _sellingPrice;

        public decimal Rrp { get; }

        public decimal SellingPrice { get; }

        public decimal Discount
        {
            get
            {
                if (Rrp > SellingPrice)
                {
                    return Rrp - SellingPrice;
                }

                return 0;
            }
        }

        public decimal Savings
        {
            get
            {
                if (Rrp > SellingPrice)
                {
                    return 1 - SellingPrice / Rrp;
                }

                return 0;
            }
        }

        public Price(decimal rrp, decimal sellingPrice)
        {
            Rrp = rrp;
            SellingPrice = sellingPrice;
        }

        public void SetDiscountStrategyTo(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }


    }
}
