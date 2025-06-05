using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;
using WebApplicationShopOnline.Models.Repositories;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        [HttpGet]
        public IActionResult Index(string searchName)
        {
            if (!string.IsNullOrEmpty(searchName))
            {
                var user = _userRepository.GetUserByName(searchName);
                if (user != null)
                {
                    return View("Index", new List<User> { user });
                }
                ViewBag.Message = "Пользователь не найден";
                return View("Index", new List<User>());
            }

            var users = _userRepository.GetAllUsers();
            return View(users);
        }

        [HttpGet]
        public IActionResult UserDetails(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
    }
} 