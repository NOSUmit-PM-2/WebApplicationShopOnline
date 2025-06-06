using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;


namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        // GET: User/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: User/Details
        public IActionResult Details(int idUser, string name, string login,
                                   string password, string telephone, string email)
        {
            var user = new User1
            {
                IdUser = idUser,
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