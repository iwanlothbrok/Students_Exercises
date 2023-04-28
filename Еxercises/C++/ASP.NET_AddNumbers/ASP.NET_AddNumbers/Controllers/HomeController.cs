using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_AddNumbers.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
	}
}
