using Microsoft.AspNetCore.Identity;
using OnlineShopCourseWork.Data;
using OnlineShopCourseWork.Models;
using OnlineShopCourseWork.Services.Roles;

namespace OnlineShopCourseWork.Storages
{
    public sealed class RoleStore : IRoleStore<Role>
    {
        private readonly IRoleService roleService;

        public RoleStore(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        public async Task<IdentityResult> CreateAsync(Role role, CancellationToken cancellationToken)
        {
            IdentityResult result;

            try
            {
                roleService.Insert(role);
                result = IdentityResult.Success;
            }
            catch (Exception ex)
            {
                result = new IdentityResult();
                IdentityError error = new IdentityError
                {
                    Code = "102",
                    Description = ex.ToString(),
                };

                result.Errors.ToList().Add(error);
            }

            return result;
        }

        public Task<IdentityResult> DeleteAsync(Role role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Task<Role> FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<Role> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            return roleService.GetRoleByName(normalizedRoleName);
        }

        public Task<string> GetNormalizedRoleNameAsync(Role role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetRoleIdAsync(Role role, CancellationToken cancellationToken)
        {
            return role.Id.ToString();
        }

        public async Task<string> GetRoleNameAsync(Role role, CancellationToken cancellationToken)
        {
            return role.RoleName;
        }

        public async Task SetNormalizedRoleNameAsync(Role role, string normalizedName, CancellationToken cancellationToken)
        {
            role.NormalizedName = normalizedName;
        }

        public Task SetRoleNameAsync(Role role, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(Role role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
