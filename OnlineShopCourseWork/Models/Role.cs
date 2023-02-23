using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace OnlineShopCourseWork.Models
{
    public sealed  class Role : IdentityRole<int>
    {
        public string RoleName { get; set; }
        
    }
}
