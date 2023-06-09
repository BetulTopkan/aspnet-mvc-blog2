using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminUserController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
