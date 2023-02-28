namespace OnlineShopCourseWork.Data.Models
{
    public sealed class Orders
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
    }
}
