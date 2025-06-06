using Microsoft.AspNetCore.Mvc;

namespace WebApplicationShopOnline.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}