using Devcard_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Devcard_MVC.Controllers
{
    
    public class HomeController : Controller
    {
		private readonly List<Service> _services = new List<Service>
	    {
		    new Service(1,"نقره ای"),
		    new Service(2,"طلایی"),
		    new Service(3,"پلاتین"),
		    new Service(4,"الماس")
	    };

		public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            { 
                Services = new SelectList(_services, "Id", "Name")
            };
            return View(model);
        }

        //برای زمانی که نمیدونیم فیلد های فرم ما به چه صورت هست از این رشو استفاده میکنیم
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            form.Services = new SelectList(_services , "Id", "Name");
            
            if (!ModelState.IsValid)
            {
                ViewBag.erorr = "اطلاعات وارد شده صحیح نمی باشد لطفا دوباره تلاش کنید.";
                return View(form);
            }

            ModelState.Clear();
            form = new Contact
            {
                 Services = new SelectList(_services , "Id", "Name")
            };
            ViewBag.success = "اطلاعات با موفقیت ثبت گردید.";
            return View(form);
        }

        public IActionResult Projects()
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
