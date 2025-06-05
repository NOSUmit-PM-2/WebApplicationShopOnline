using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User(string name, string password, string login, string phone, string email)
        {
            User inputUser = new User(name, login, password, phone, email);
            return View(inputUser);
        }
    }
}