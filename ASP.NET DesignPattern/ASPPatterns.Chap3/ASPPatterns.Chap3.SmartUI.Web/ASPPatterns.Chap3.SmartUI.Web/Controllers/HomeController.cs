using ASPPatterns.Chap3.SmartUI.Web.Data;
using ASPPatterns.Chap3.SmartUI.Web.Models.Home;
using System.Web.Mvc;

namespace ASPPatterns.Chap3.SmartUI.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(int discountType = 0)
        {
            var products = ProductDb.GetProducts();

            foreach (var product in products)
            {
                product.Discount = DisplayDiscount(product.Rrp, ApplyExtraDiscountsTo(product.SellingPrice, discountType));
                product.Savings = DisplaySavings(product.Rrp, ApplyExtraDiscountsTo(product.SellingPrice, discountType));
            }

            var vm = new ProductVM()
            {
                Products = products
            };

            return View(vm);
        }



        [HttpPost]
        public ActionResult Index()
        {

            return View();
        }

        private static string DisplayDiscount(decimal rrp, decimal salePrice)
        {
            var discountText = "";

            if (rrp > salePrice)
            {
                discountText = $"{rrp - salePrice:C}";
            }

            return discountText;
        }

        private static string DisplaySavings(decimal rrp, decimal sellingPrice)
        {
            var savingText = "";

            if (rrp > sellingPrice)
            {
                savingText = (1 - sellingPrice / rrp).ToString("#%");
            }

            return savingText;
        }

        private static decimal ApplyExtraDiscountsTo(decimal originalSalePrice, int discountType)
        {
            var price = originalSalePrice;

            if (discountType == 1)
            {
                price = price * 0.95M;
            }

            return price;
        }
    }
}