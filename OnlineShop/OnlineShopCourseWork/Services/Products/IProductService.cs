namespace OnlineShopCourseWork.Services.Products
{
    using OnlineShopCourseWork.InputModels.Products;
    public interface IProductService
    {
        int Create(ProductsInputModel model);
    }
}
