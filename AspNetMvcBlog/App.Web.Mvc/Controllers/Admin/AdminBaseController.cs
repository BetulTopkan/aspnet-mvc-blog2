using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{

    public abstract class AdminBaseController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
