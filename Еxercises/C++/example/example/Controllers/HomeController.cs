using example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace example.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		[HttpGet]
		public IActionResult Clear()
		{
			var model = new HomeViewModel();
			return View(model);
		}
		[HttpGet]
		public IActionResult Create()
		{
			var model = new HomeViewModel();
			var n = new Random();

			model.first = n.Next();
			model.second = n.Next();
			model.third = n.Next();
			model.fourth = n.Next();

			return View(model);
		}
		[HttpPost]
		public IActionResult Create(HomeViewModel model)
		{

			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}