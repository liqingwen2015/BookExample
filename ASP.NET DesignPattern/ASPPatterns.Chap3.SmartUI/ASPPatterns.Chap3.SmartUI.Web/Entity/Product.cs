using System.ComponentModel.DataAnnotations.Schema;

namespace ASPPatterns.Chap3.SmartUI.Web.Entity
{
    [Table("Products")]
    public class Product
    {
        public int ProductId { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal Rrp { get; set; }

        public string ProductName { get; set; }
    }
}