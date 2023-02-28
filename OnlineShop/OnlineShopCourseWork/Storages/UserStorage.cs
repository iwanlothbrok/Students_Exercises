using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using OnlineShopCourseWork.Data.Models;
using OnlineShopCourseWork.Services.Roles;
using OnlineShopCourseWork.Services.Users;
using System.Security.Claims;

namespace OnlineShopCourseWork.Storages
{
    public sealed class UserStorage : IUserStore<User>,
                                      IUserClaimStore<User>,
                                      IUserLoginStore<User>,
                                      IUserRoleStore<User>,
                                      IUserPasswordStore<User>,
                                      IUserSecurityStampStore<User>


    {
        private readonly IUserService userService;
        private readonly IRoleService roleService;

        public UserStorage(IUserService userService, IRoleService roleService)
        {
            this.userService = userService;
            this.roleService = roleService;
        }


        public Task AddClaimsAsync(User user, IEnumerable<Claim> claims, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task AddLoginAsync(User user, UserLoginInfo login, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task AddToRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            int roleId = roleService.GetRoleByName(roleName).Id;
            roleService.AddUserToRole(user.Id, roleId);
        }

        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            IdentityResult result;

            try
            {
                userService.Create(user);
                result = IdentityResult.Success;
            }
            catch (Exception ex)
            {
                result = new IdentityResult();
                IdentityError error = new IdentityError
                {
                    Code = "101",
                    Description = ex.ToString()
                };
                result.Errors.ToList().Add(error);
            }

            return result;

        }

        public Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return userService.GetByUserName(normalizedUserName);
        }

        public async Task<IList<Claim>> GetC7laimsAsync(User user, CancellationToken cancellationToken)
        {
            return new List<Claim>();
        }

        public async Task<IList<Claim>> GetClaimsAsync(User user, CancellationToken cancellationToken)
        {
            return new List<Claim>();
        }

        public Task<IList<UserLoginInfo>> GetLoginsAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetPasswordHashAsync(User user, CancellationToken cancellationToken)
        {
            //toDO:: Impelemnt this method!
            return userService.GetUserPasswordHash(user.Id);
        }

        public async Task<IList<string>> GetRolesAsync(User user, CancellationToken cancellationToken)
        {
            return roleService.GetUserRoles(user.Id).ToList();
        }

        public async Task<string> GetSecurityStampAsync(User user, CancellationToken cancellationToken)
        {
            return user.ConcurrencyStamp;
        }

        public async Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            return user.Id.ToString();
        }

        public async Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            return user.UserName;
        }

        public Task<IList<User>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsInRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            return roleService.IsInRole(roleName, user.Id);
        }

        public Task RemoveClaimsAsync(User user, IEnumerable<Claim> claims, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveLoginAsync(User user, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task ReplaceClaimAsync(User user, Claim claim, Claim newClaim, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            user.NormalizedUserName = normalizedName.ToUpper();
        }

        public async Task SetPasswordHashAsync(User user, string passwordHash, CancellationToken cancellationToken)
        {
            user.PasswordHash = passwordHash;
        }

        public async Task SetSecurityStampAsync(User user, string stamp, CancellationToken cancellationToken)
        {
            user.SecurityStamp = stamp;
        }

        public async Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            user.UserName = userName;
            user.NormalizedUserName = userName.ToUpper();
        }

        
        public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            return IdentityResult.Success;
        }
        
    }
}
