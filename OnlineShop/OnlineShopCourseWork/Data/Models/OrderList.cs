namespace OnlineShopCourseWork.Data.Models
{
    public sealed class OrderList
    {
        public int OrderId { get; set; }
        public int OLId { get; set; }
        public double OrderPrice { get; set; }
        public double OrderQuantity { get; set; }
        public int StockId { get; set; }
    }
}
