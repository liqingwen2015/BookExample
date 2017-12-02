namespace ASPPatterns.Chap3.SmartUI.Web.Data
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        /// <summary>
        /// 推荐零售价
        /// </summary>
        public decimal Rrp { get; set; }

        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal SellingPrice { get; set; }

        /// <summary>
        /// 折扣
        /// </summary>
        public string Discount { get; set; }

        /// <summary>
        /// 节省百分比
        /// </summary>
        public string Savings { get; set; }
    }
}