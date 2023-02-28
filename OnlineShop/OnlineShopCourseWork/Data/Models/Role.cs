using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace OnlineShopCourseWork.Data.Models
{
    public sealed class Role : IdentityRole<int>
    {
        public string RoleName { get; set; }

    }
}
