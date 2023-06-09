using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminCategoryController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
