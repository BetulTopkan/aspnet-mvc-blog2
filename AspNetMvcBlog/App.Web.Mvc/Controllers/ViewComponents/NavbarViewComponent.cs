using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new NavbarModel();

            model.CategoryList = new List<CategoryModel> 
            {
                new CategoryModel()
                {
                    Id = 1,
                    Name = "Yazılım"
                },
				new CategoryModel()
				{
					Id = 2,
					Name = "Bilim"
				},
				new CategoryModel()
				{
					Id = 3,
					Name = "Hayvanlar"
				}
			};

            model.BlogList = CategoryController._dbBlogPosts;

            return View(model);
        }
    }
}
