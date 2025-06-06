using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Models;
using WebApplicationShopOnline.Models;
namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {     

        public IActionResult Index(string name, string login, string password, string phone, string email)
        {
            UserViewModel testUser = new UserViewModel("Test", "keks@mail.com", "password", "+77777777");
            return View(testUser);
            User inputUser = new User(name, login, password, phone, email);
            return View(inputUser);
        }
    }
}