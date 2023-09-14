using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard.ViewComponents
{
	public class ProjectsViewComponent:ViewComponent 
	{
		public IViewComponentResult Invoke()
		{
			var Projects = new List<Project>
			{
				new Project { Id = 1,Name="Archelogy",Description="The best major",Client="UCLA"},
				new Project { Id = 2,Name="Liteture",Description="Soooo Good",Client="Oxford"},
				new Project { Id = 3,Name="Math",Description="good major",Client="UCLA"},
				new Project { Id = 4,Name="Physics",Description="Awsome Major",Client="UCLA"},
			};
			return View("_Projects",Projects); 
		}

	}
}
