using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        readonly UserRepository userRepository = new UserRepository();
        public IActionResult Index(int id)
        {
            User user = userRepository.TryGetById(id);
            if (user == null)
            {
                return null;
            }
            return View(user);
        }
        public IActionResult Catalog()
        {
            var users = userRepository.GetAll();
            return View(users);
        }
    }
}