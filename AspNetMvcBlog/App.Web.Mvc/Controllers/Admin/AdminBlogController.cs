using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminBlogController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
