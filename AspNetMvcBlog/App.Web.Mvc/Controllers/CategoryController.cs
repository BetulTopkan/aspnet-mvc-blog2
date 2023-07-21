using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System;

namespace App.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        //TEMP
        public static List<BlogPostModel> _dbBlogPosts = new List<BlogPostModel>
        {
            new BlogPostModel
            {
                Id = 1,
                CategoryId = 1,
                CategoryName = "Yazılım",
                Title = "C# 7 release yayınlandı!",
				ImageUrl = "/images/news/f1.jpg",
				Author = "Betül Topkan",
				InsertedDate = DateTime.Now,
				Content = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates ab ratione animi nobis in et consequatur
							earum modi repellendus, qui, non debitis pariatur tempora consequuntur!",
				ShowInSlider = true,
            },
			new BlogPostModel
			{
				Id = 2,
				CategoryId = 1,
				CategoryName = "Yazılım",
				Title = "Elon Musk Twitter'ı satın aldı.",
				ImageUrl = "/images/news/f2.jpg",
				Author = "Betül Topkan",
				InsertedDate = Convert.ToDateTime("2022-12-01 10:00"),
				Content = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates ab ratione animi nobis in et consequatur
							earum modi repellendus, qui, non debitis pariatur tempora consequuntur!",
                ShowInSlider = true,
            },
			new BlogPostModel
			{
				Id = 3,
				CategoryId = 2,
				CategoryName = "Bilim",
				Title = "Atom parçalandı!",
				ImageUrl = "/images/news/f3.jpg",
				Author = "Betül Topkan",
				InsertedDate = Convert.ToDateTime("1800-02-01 12:00"),
				Content = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates ab ratione animi nobis in et consequatur
							earum modi repellendus, qui, non debitis pariatur tempora consequuntur!",
                ShowInSlider = true,
            },
			new BlogPostModel
			{
				Id = 4,
				CategoryId = 3,
				CategoryName = "Hayvanlar",
				Title = "Megaladon dişi bulundu!",
				ImageUrl = "/images/news/f4.jpg",
				Author = "Betül Topkan",
				InsertedDate = Convert.ToDateTime("2022-01-03 12:00"),
				Content = @"Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptates ab ratione animi nobis in et consequatur
							earum modi repellendus, qui, non debitis pariatur tempora consequuntur!",
                ShowInSlider = true,
            }
		};

        [Route("Category")]
        [Route("Category/{id}")]
        public IActionResult Index(int id, int page)
        {
			//id'ye göre kategoriyi bul
			//bu kategorinin yazılarını (blogposts) bul
			//bu kayıtları dön

			List<BlogPostModel> blogPosts = _dbBlogPosts.Where(x => x.CategoryId == id).ToList();

			return View(blogPosts);
        }
    }
}
