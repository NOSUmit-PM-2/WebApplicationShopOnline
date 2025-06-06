using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel testUser = new UserViewModel("Test", "keks@mail.com", "password", "+77777777");
            return View(testUser);
        }
    }
}
