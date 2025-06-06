using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Models;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string name, string login, string password, string telephone, string email)
        {
            var userView = new UserViewModel(name, login, password, telephone, email);
            return View(userView);
        }
    }
}
