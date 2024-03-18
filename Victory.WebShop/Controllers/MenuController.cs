using Microsoft.AspNetCore.Mvc;

namespace Victory.WebShop.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
    }
}
