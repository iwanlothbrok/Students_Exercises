using Microsoft.AspNetCore.Identity;

namespace OnlineShopCourseWork.Data.Models
{
    public sealed class User : IdentityUser<int>
    {
        public string UserPassword { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
