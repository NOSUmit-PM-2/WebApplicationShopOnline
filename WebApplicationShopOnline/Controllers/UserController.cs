using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(int id, string name, string login, string password, string telephone, string email)
        {
            var user = new User
            {
                Id = id,
                Name = name,
                Login = login,
                Password = password,
                Telephone = telephone,
                Email = email
            };

            return View(user);
        }
    }
}
