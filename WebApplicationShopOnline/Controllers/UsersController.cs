using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            User user = new User("Артемий Лебедев", 28, "Lebedev@gmail.com", "pasword");

            return View(user);
        }
    }
}
