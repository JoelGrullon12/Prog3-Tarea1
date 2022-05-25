using Microsoft.AspNetCore.Mvc;

namespace Tarea1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
