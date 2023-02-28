using OnlineShopCourseWork.Data.Models;

namespace OnlineShopCourseWork.Services.Users
{
    public interface IUserService
    {
        User GetByUserName(string userName);

        void Create(User user);

        string GetUserPasswordHash(int userId);

        bool HasUser(string username);
      
    }

}
