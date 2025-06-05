using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        UserRepository userRepository = new UserRepository();

        public IActionResult Index(Guid idUser)
        {
            var existingUser = userRepository.TryGetById(idUser);
            return View(existingUser);
        }

        public IActionResult UsersAll()
        {
            var users = userRepository.GetAll();
            return View(users);
        }

        public IActionResult Search(string searchName)
        {
            var existingUser = userRepository.GetAll().FirstOrDefault(user => user.Name == searchName);
            if (existingUser == null)
                return NotFound("Пользователь не найден!");
            return RedirectToAction(nameof(Index), new { idUser = existingUser.IdUser });
        }
    }
}
