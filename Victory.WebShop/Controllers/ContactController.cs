using Microsoft.AspNetCore.Mvc;

namespace Victory.WebShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
