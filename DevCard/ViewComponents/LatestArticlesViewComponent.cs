using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard.ViewComponents
{
	public class LatestArticlesViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var article = new List<Article>
			{
				new Article(1,"ASP.NET Class", "This Class is for intermediate Students" , "blog-post-thumb-card-1.jpg"),
				new Article(2,"Python Class", "This Class is for Beginers Students" , "blog-post-thumb-card-2.jpg"),
				new Article(3,"C# Class", "This Class is for Advanced Students" , "blog-post-thumb-card-3.jpg"),
				new Article(4,"Laravel Class", "This Class is for All Students" , "blog-post-thumb-card-4.jpg"),
				new Article(5,"PHP Programming Class", "This Class is for All Begginers" , "blog-post-thumb-card-5.jpg"),
				new Article(6,"Angular Class", "This Class is for All Students" , "blog-post-thumb-card-6.jpg")


			};
			return View("_LatestArticles",article);
		}
	}
}
