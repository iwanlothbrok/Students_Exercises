using OnlineShopCourseWork.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OnlineShopCourseWork.InputModels.Products
{
    public class ProductsInputModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int ImageId { get; set; }
        public byte[]? ProductPhoto { get; set; }
        
        // getting all the categories 
        public IEnumerable<ProductCategory>? Categories { get; set; }
        [Display(Name = "Category")]

        // now you could use it in the view 
        public int CategoryId { get; set; }
    }
}
