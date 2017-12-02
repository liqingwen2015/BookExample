﻿namespace ASPPatterns.Chap3.Layered.Model
{
    public class NullDiscountStrategy:IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal originalSalePrice)
        {
            return originalSalePrice;
        }
    }
}
