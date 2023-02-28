using Microsoft.AspNetCore.Identity;
using OnlineShopCourseWork.Data.Models;
using OnlineShopCourseWork.Globals;
using OnlineShopCourseWork.Services.Roles;
using OnlineShopCourseWork.Services.Users;
using System.ServiceProcess;

namespace OnlineShopCourseWork.Seed
{
    public sealed class Seeder
    {
        private const string AdminUserName = "admin";
        private const string AdminPassword = "admin";


        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly IUserService userService;
        private readonly IRoleService roleService;

        public Seeder(IServiceScope scopedService)
        {
            userManager = scopedService.ServiceProvider.GetService<UserManager<User>>();
            roleManager = scopedService.ServiceProvider.GetService<RoleManager<Role>>();
            userService = scopedService.ServiceProvider.GetService<IUserService>();
            roleService = scopedService.ServiceProvider.GetService<IRoleService>();
        }

        public async void SeedData() 
        {
            await SeedUser();
            await SeedRoles();
            await SeedUserRoles();
        }

        private async Task SeedUserRoles()
        {
            var user = await userManager.FindByNameAsync(AdminUserName);

            if (user is null)
            {
                return;
            }

            if (await userManager.IsInRoleAsync(user, GlobalConstants.AdminRoleName))
            {
                return;
            }

            var result = await userManager.AddToRoleAsync(user, GlobalConstants.AdminRoleName);
        }

        private async Task SeedRoles()
        {
            if (!roleService.HasRole(GlobalConstants.AdminRoleName))
            {
                Role adminRole = new Role
                {
                    RoleName = GlobalConstants.AdminRoleName,
                };

                var result = await roleManager.CreateAsync(adminRole);
            }

            if (!roleService.HasRole(GlobalConstants.UserRoleName))
            {
                Role userRole = new Role
                {
                    RoleName = GlobalConstants.UserRoleName,
                };

                var result = await roleManager.CreateAsync(userRole);
            }
            if (!roleService.HasRole(GlobalConstants.ModeratorRoleName)) 
            {

                Role modoretorRole = new Role
                {
                    RoleName = GlobalConstants.ModeratorRoleName,
                };
                var result = await roleManager.CreateAsync(modoretorRole);
            }
        }

        private async Task SeedUser()
        {
            if (userService.HasUser(AdminUserName))
            {
                return;
            }

            User adminUser = new User
            {
                UserName = AdminUserName,
                Email = $"{AdminUserName}@abv.bg",
                FirstName = AdminUserName,
                LastName = AdminUserName,
                PhoneNumber = "1234567890",
            };

            await userManager.CreateAsync(adminUser, AdminPassword);
        }
    }
}
