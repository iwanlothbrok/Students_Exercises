namespace OnlineShopCourseWork.Models
{
    public sealed class OrderList
    {
        public int OLId { get; set; }
        public int OrderId { get; set; }
        public double  OrderPrice { get; set; }
        public double OrderQuantity { get; set; }
        public int StockId { get; set; }
    }
}
