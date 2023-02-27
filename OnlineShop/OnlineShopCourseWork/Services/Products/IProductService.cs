using OnlineShopCourseWork.InputModels;

namespace OnlineShopCourseWork.Services.Products
{
    public interface IProductService
    {
        int Create(ProductsInputModel model);
    }
}
