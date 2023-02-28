using OnlineShopCourseWork.InputModels.Products;

namespace OnlineShopCourseWork.Services.Products
{
    public interface IProductService
    {
        int Create(ProductsInputModel model);
    }
}
