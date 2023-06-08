using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
