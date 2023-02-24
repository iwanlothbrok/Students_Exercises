using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShopCourseWork.Globals;

namespace OnlineShopCourseWork.Controllers
{
    [Authorize(Roles = GlobalConstants.AdminRoleName)]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateCategory() 
        {
            return View();
        }
    }
}
