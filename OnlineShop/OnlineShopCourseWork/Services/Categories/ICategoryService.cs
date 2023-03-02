namespace OnlineShopCourseWork.Services.Categories
{
    public interface ICategoryService
    {
        int Create(string name);
        int IsAvailable(string name);
        //public int CheckName(string name);
    }
}
