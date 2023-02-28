using OnlineShopCourseWork.Data.Models;
using System.Reflection.Metadata;

namespace OnlineShopCourseWork.Services.Roles
{
    public interface IRoleService
    {
        IEnumerable<string> GetUserRoles(int userId);

        bool HasRole(string roleName);

        Role GetRoleByName(string name);

        void Insert(Role role);

        bool IsInRole(string roleName, int userId);

        void AddUserToRole(int userId, int roleId);

      
    }
}
