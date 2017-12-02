using System.Collections.Generic;

namespace ASPPatterns.Chap3.Layered.Model
{
    public static class ProductListExtendsionMethods
    {
        public static void Apply(this IList<Product> products, IDiscountStrategy discountStrategy)
        {
            foreach (var product in products)
            {
                product.Price.SetDiscountStrategyTo(discountStrategy);
            }
        }
    }
}
