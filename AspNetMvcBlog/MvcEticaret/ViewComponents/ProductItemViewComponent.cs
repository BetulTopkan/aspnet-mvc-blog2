using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;

namespace MvcEticaret.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ProductItem product)
        {
            return View(product);
        }
    }
}
