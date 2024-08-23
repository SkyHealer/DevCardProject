using Devcard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Devcard_MVC.View_Components
{
	public class ProjectsViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var project = new List<Project>()
			{
				new Project(1 , "تاکسی" , "درخواست تاکسی", "project-1.jpg" , "snapp"),
				new Project(2 , "زودفود" , "درخواست آنلاین غذا","project-2.jpg", "zoodFood"),
				new Project(3 , "مدارس" , "سیستم مدیریت مدارس","project-3.jpg", "MONOP"),
				new Project(4 , "فضاپیما" , "برنامه مدیریت فضاپیما","project-4.jpg", "NASA"),
			};

			return View("_Projects", project);
		}
	}
}
