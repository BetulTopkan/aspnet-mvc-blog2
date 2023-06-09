using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminPageController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
