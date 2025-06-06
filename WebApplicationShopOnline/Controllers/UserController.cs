using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string name, string telephone, string email, string login, string password)
        {
            return View(new User(name, telephone, email, login, password));

        }


    }

    
}