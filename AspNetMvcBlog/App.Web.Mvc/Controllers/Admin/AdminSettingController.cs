using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminSettingController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
