using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository = new();

        // Список пользователей
        public IActionResult Index(string searchName)
        {
            List<User> users = new();

            if (!string.IsNullOrEmpty(searchName))
            {
                users = _userRepository.SearchUserByName(searchName);
            }
            else
            {
                users = _userRepository.GetAllUsers();
            }

            ViewBag.SearchName = searchName;
            return View(users);
        }

        // Детали пользователя
        public IActionResult Details(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
                return NotFound("Пользователь не найден");

            return View(user);
        }
    }
}
