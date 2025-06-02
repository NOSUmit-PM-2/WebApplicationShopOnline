using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Models;
using System.Diagnostics;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class AccountController : Controller
    {
        //private readonly IUserManager usersManager;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(SignInManager<User> signInManager, UserManager<User> _userManager)
        {
            _signInManager = signInManager;
            this._userManager = _userManager;
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            var user = _userManager.FindByNameAsync(login.UserName).Result;
            if (user != null)
            {
                var result = _signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, false).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("Catalog", "Product");
                }
            }
            return View(login);
        }

   
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();   
            return RedirectToAction("Catalog", "Product");
        }

    }
}