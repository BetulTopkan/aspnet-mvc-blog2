using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
