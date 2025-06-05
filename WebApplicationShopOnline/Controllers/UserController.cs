using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult UserDetails([FromQuery] int idUser, 
                                      [FromQuery] string name,
                                      [FromQuery] string login,
                                      [FromQuery] string telephone,
                                      [FromQuery] string email)
        {
            var user = new User
            {
                IdUser = idUser,
                Name = name,
                Login = login,
                Telephone = telephone,
                Email = email
            };

            return View(user);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
} 