using Microsoft.AspNetCore.Mvc;

namespace Victory.WebShop.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
