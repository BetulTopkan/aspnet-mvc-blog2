using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class AdminHomeController : AdminBaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }}
