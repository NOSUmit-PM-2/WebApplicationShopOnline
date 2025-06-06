using Microsoft.AspNetCore.Mvc;
using OnlineShop.DB.Models;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        UsersRepository userRepository = new UsersRepository();

        public IActionResult Index(string name, string login, string password, string telephone, string email)
        {
            var userView = new UserViewModel(name, login, password, telephone, email);
            return View(userView);
        }


        public IActionResult Details(int idUser)
        {
            var existingUser = userRepository.GetById(idUser);
            return View(existingUser);
        }

        public IActionResult UsersAll()
        {
            var users = userRepository.GetUsers();
            return View(users);
        }

        public IActionResult Search(string name)
        {
            var existingUser = userRepository.GetUsers().FirstOrDefault(user => user.Name == name);
            if (existingUser == null)
                return NotFound("такой пользователь не найден!");
            return RedirectToAction(nameof(Details), new { idUser = existingUser.IdUser });
        }
    }
}
