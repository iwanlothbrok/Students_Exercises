using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShopCourseWork.Globals;
using OnlineShopCourseWork.InputModels.Products;
using OnlineShopCourseWork.Services.Products;

namespace OnlineShopCourseWork.Controllers
{
    [Authorize(Roles = GlobalConstants.AdminRoleName)]
    public class AdminController : Controller
    {
        private IProductService productService;
        public AdminController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            var model = new ProductsInputModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductsInputModel model)
        {
            if (this.ModelState.IsValid == false)
            {
                return RedirectToAction("Index", "Admin");
            }

            this.productService.Create(model);

            return View(model);
        }
    }
}
