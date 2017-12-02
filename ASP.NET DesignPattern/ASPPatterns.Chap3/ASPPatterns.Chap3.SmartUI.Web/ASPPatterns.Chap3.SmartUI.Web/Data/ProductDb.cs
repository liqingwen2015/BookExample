using System.Collections.Generic;

namespace ASPPatterns.Chap3.SmartUI.Web.Data
{
    public static class ProductDb
    {
        public static IList<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product() {ProductId = 1, ProductName = "Drill", Rrp = 109.99M, SellingPrice = 99.99M},
                new Product() {ProductId = 2, ProductName = "Hammer", Rrp = 8.99M, SellingPrice = 7.99M},
                new Product() {ProductId = 3, ProductName = "Shovel", Rrp = 9.99M, SellingPrice = 9.99M}
            };
        }
    }
}