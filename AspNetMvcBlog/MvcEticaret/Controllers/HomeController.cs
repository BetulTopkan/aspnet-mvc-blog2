using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;


namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<ProductItem>()
            {
                new ProductItem
                {
                    Title="Sector 9  33,375 Rosin Ricochet Longboard", StarCount = 1, OldPrice=200.99, Price=214.95, IsSale=true, ImageUrl = "https://cdn.shopify.com/s/files/1/2291/8079/products/ROSIN-RICOCHET_279c1fff-eaa9-4364-a9cd-1706005110e9_2048x.png?v=1617733668"
                },
                new ProductItem
                {
                     Title="Sector 9  30,5 Cascade Ninety Five Cruiser", StarCount = 2, OldPrice=155.99, Price=174.95, IsSale=true, ImageUrl="https://cdn.shopify.com/s/files/1/2291/8079/products/CASCADE-NINETY-FIVE_43c0200a-1b12-40fd-bc61-f240ae6ed229_2048x.png?v=1617733516"
                },
                new ProductItem
                {
                     Title="Sector 9 30,5 Noh Chomp Hop Cruiser", StarCount = 3, OldPrice=175.95, Price=185.95, IsSale=false, ImageUrl="https://cdn.shopify.com/s/files/1/2291/8079/products/CHOP-HOP-NOH_b10ebf75-f577-47ff-96bf-8a1e67b182a1_2048x.png?v=1617732958"

                },
                new ProductItem
                {
                    Title= "Penny Board The Original Costa 22", StarCount= 4, OldPrice=200.99, Price=218.99, IsSale=true, ImageUrl="https://cdn.shopify.com/s/files/1/0062/4915/2581/products/PNYCOMP22531_Costa-22_1_1800x1800.jpg?v=1604900192 "
                },
                new ProductItem
                {
                    Title="Penny Board The Original Regulas 22", StarCount=5, OldPrice=200.00, Price=235.55,  IsSale=true, ImageUrl="https://cdn.shopify.com/s/files/1/0062/4915/2581/products/PNYCOMP22533_Regulas-22_1_1800x1800.jpg?v=1604900267"
                },
                new ProductItem
                {
                    Title="Zflex 29 Aragon Cheetah Cruiser", StarCount=6, OldPrice=89.95, Price=99.95, IsSale=false, ImageUrl="https://cdn.shopify.com/s/files/1/0066/6121/0179/products/ZFX20_Aragon_29_Comp_1800x1800.jpg?v=1580702275"
                },
                new ProductItem
                {
                    Title= "Zflex 27 Aragon Cheetah Cruiser", StarCount=7 , OldPrice=89.95, Price=99.95, IsSale=true, ImageUrl="https://cdn.shopify.com/s/files/1/0066/6121/0179/products/ZFX20_Aragon_27_1_Comp_1800x1800.jpg?v=1580964672"
                },
                new ProductItem
                {
                    Title="Zflex 29 Bamboo Cruiser", StarCount=8, OldPrice=90.00, Price=95.99,  IsSale=false, ImageUrl="https://cdn.shopify.com/s/files/1/0066/6121/0179/products/ZFX20_Bamboo_29_Comp_1800x1800.jpg?v=1581295437"
                }
            };
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}