using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class PageController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
