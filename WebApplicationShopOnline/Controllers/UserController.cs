using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(string name, string email, string password,string telephone)
        {
            if (name != "" || email == "" || password == "")
            {
                return View(new User("Ну введи имя", "И почту", "Пароль можно мне на почту","Телефон тоже надо"));
            }
            else
            {
               return View(new User(name,email,password,telephone));
            }
        }
    }
}
