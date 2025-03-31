using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Xml.Linq;
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
                return NotFound();
            }
            return View(user);
        }
        public IActionResult UserList()
        {
            var users = userRepository.GetAll();
            return View(users);
        }
    }
}