using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.ViewComponents
{
	public class SliderViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var models = CategoryController._dbBlogPosts.Where(x => x.ShowInSlider == true).ToList();
			return View(models);
		}
	}
}
