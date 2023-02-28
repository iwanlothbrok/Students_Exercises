namespace OnlineShopCourseWork.Data.Models
{
    public sealed class product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ImageId { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

    }
}
