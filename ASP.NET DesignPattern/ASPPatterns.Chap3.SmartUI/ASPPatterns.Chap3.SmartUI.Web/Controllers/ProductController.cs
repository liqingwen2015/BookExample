using ASPPatterns.Chap3.SmartUI.Web.Entity;
using ASPPatterns.Chap3.SmartUI.Web.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;

namespace ASPPatterns.Chap3.SmartUI.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly AspPatternsDbContext _db = new AspPatternsDbContext();

        // GET: Product
        public ActionResult Index()
        {
            var vms = new List<ProductViewModel>();
            foreach (var product in _db.Products)
            {
                vms.Add(new ProductViewModel()
                {
                    ProductName = product.ProductName,
                    ProductId = product.ProductId,
                    Rrp = product.Rrp,
                    SellingPrice = product.SellingPrice,
                    Discount = DisplayDiscount(product.Rrp, product.SellingPrice),
                    Savings = DisplaySavings(product.Rrp, product.SellingPrice)
                });
            }

            return View(vms);
        }

        public ActionResult UpdateIndex(decimal rrp, decimal sellingPrice, int discountType)
        {
            return Json(new
            {
                Savings = DisplaySavings(rrp, ApplyExtraDiscountsTo(discountType, sellingPrice)),
                Discount= DisplayDiscount(rrp, ApplyExtraDiscountsTo(discountType, sellingPrice)),
                sellingPrice=$"{ApplyExtraDiscountsTo(discountType, sellingPrice)}"
            },JsonRequestBehavior.AllowGet);
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,SellingPrice,Rrp,ProductName")] Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,SellingPrice,Rrp,ProductName")] Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(product).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = _db.Products.Find(id);
            _db.Products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        protected string DisplayDiscount(decimal rrp, decimal salePrice)
        {
            var discountText = "";

            if (rrp > salePrice)
            {
                discountText = $"{rrp - salePrice:C}";
            }

            return discountText;
        }

        protected string DisplaySavings(decimal rrp, decimal salePrice)
        {
            var savingText = "";

            if (rrp > salePrice)
            {
                savingText = (1 - (salePrice / rrp)).ToString("#%");
            }

            return savingText;
        }

        protected decimal ApplyExtraDiscountsTo(int discountType, decimal originalSalePrice)
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
