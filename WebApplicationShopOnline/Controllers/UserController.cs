using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // Действие для отображения данных пользователя
        public IActionResult Details()
        {
            // Получаем query-параметры из URL
            int idUser = int.Parse(Request.Query["IdUser"]);
            string name = Request.Query["Name"];
            string login = Request.Query["Login"];
            string password = Request.Query["Password"];
            string telephone = Request.Query["Telephone"];
            string email = Request.Query["Email"];

            var user = new User
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
        public IActionResult Json_test(string searchName)
        {
            if (!string.IsNullOrEmpty(searchName))
            {
                var user = _userRepository.FindUserByName(searchName);
                if (user != null)
                {
                    return Json(user); // Возвращаем найденного пользователя в формате JSON
                }
                else
                {
                    return Json(new { message = "Такой пользователь не найден" });
                }
            }

            // Возвращаем всех пользователей в формате JSON
            return Json(_userRepository.GetAllUsers());
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
