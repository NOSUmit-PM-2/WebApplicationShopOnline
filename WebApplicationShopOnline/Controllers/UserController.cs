using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string name, string login, string password, string telephone, string email)
        {
            User user = new User(name, login, password, telephone, email);
            return View(user);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
