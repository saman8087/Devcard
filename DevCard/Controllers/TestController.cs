using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Net.Mime;

namespace DevCard.Controllers
{
	public class TestController : Controller
	{
		// GET: TestController
		public IActionResult Index()
		{
			return Json(new { id = 1, name = "pariya", major = "MBA" });
			
		}
	}
}

