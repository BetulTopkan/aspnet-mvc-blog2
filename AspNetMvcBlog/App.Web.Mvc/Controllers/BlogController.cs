using App.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class BlogController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string query, int page)
        {
            var models = new List<BlogPostModel>();

            if (!string.IsNullOrEmpty(query))
            {
                models = CategoryController._dbBlogPosts.Where(x => x.Title.ToLower().Contains(query.ToLower())).ToList();
            }

            return View(models);
        }

        [Route("Blog/Detail")]
        [Route("Blog/Detail/{id}")]
        public IActionResult Detail(int id)
        {
            BlogPostModel blogPost = CategoryController._dbBlogPosts.FirstOrDefault(x => x.Id == id);

            return View(blogPost);
        }
    }
}
