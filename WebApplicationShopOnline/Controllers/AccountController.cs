using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB;
using OnlineShop.DB.Models;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class AccountController : Controller
    {
        readonly UserManager<UserDB> userManager;
       

        public AccountController(UserManager<UserDB> userManager)
        {
            this.userManager = userManager;
         
        }

        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Login(Login login)
        //{
        //    //var user = userManager.FindByNameAsync(login.UserName).Result;
        //    //if (user != null)
        //    //{
        //    //    var result = signInManager.PasswordSignInAsync(user, login.Password, login.RememberMe, false).Result;
        //    //    if (result.Succeeded)
        //    //    {
        //    //        return RedirectToAction("Catalog", "Product");
        //    //    }
        //    //}
        //    return View(login);

        //}
    }
}
