using Devcard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Devcard_MVC.View_Components
{
	public class LatestArticlesViewComponent: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var article = new List<Article>()
			{
				new Article(1,"آموزش ASP.NET CORE","اموزش پکیج ASP,NET CORE","blog-post-thumb-card-1.jpg"),
				new Article(1,"آموزش Git & Github","آموزش پکیج Git & Github","blog-post-thumb-card-2.jpg"),
				new Article(1,"آموزش Onion Architecture","آموزش Onion Architecture","blog-post-thumb-card-3.jpg"),
				new Article(1,"آموزش طراحی سایت","اموزش طراحی سایت به زان فارسی","blog-post-thumb-card-4.jpg"),
			};

			return View("_LatestArticles", article );
		}
	}
}
