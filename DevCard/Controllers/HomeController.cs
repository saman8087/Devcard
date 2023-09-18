using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Services> _services = new List<Services>
        {
            new Services(1, "Gold") ,
            new Services(2, "Platonium") ,
            new Services(3, "Diomond") ,
            new Services(4, "Silver") ,
            new Services(5, "Bronze")

        };
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name") 
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services=new SelectList(_services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.erroer = "خطایی رخ داده دوباره تلاش کنید";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(_services,"Id","Name")
            };
			ViewBag.success = "اطلاعات شما با موفقیت ارسال شد";

            return View(model);
        }

        public IActionResult Privacy()
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
