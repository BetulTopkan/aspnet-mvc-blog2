using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class BlogController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
