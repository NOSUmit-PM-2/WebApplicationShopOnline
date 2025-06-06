using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {

            var user = new User
            {
                IdUser = int.TryParse(Request.Query["idUser"], out var id) ? id : 0,
                Name = Request.Query["name"],
                Login = Request.Query["login"],
                Password = Request.Query["password"],
                Telephone = Request.Query["telephone"],
                Email = Request.Query["email"]
            };

            return View("Profile", user);
        }
    }
}