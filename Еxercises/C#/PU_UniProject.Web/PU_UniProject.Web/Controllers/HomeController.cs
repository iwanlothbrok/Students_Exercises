using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PU_UniProject.BO.Models;
using System.Text;

namespace PU_UniProject.Web.Controllers
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

		public async Task<IActionResult> GetStudentsAsync()
		{
			// creaing empty collection 
			List<Student> students = new List<Student>();

			// creating http client for request 
			using (var httpClient = new HttpClient())
			{
													  //  you can sent post too
				using (var response = await httpClient.GetAsync("the url of the api "))
				{
					// reading the response 
					string apiResponse = await response.Content.ReadAsStringAsync();
					// you are shooting to the API and recieving samo values 
					// API is working with StudentService 
					students = JsonConvert.DeserializeObject<List<Student>>(apiResponse);
				}
			}

			return View(students);
		}

		public async Task<IActionResult> AddStudentAsync(InputStudentModel model)
		{
			// creating http client for request 
			using (var httpClient = new HttpClient())
			{
				// sending the model for the post method in the API
				StringContent content = new StringContent(JsonConvert.SerializeObject(model), encoding: Encoding.UTF8, "application/json" ); 

				//  sending post method
				using (var response = await httpClient.PostAsync("the url of the api", content))
				{
					// reading the response 
					string apiResponse = await response.Content.ReadAsStringAsync();
					// you are shooting to the API and recieving samo values 
					// API is working with StudentService 
					model = JsonConvert.DeserializeObject<InputStudentModel>(apiResponse);
				}
			}

			return View(model);
		}
	}
}