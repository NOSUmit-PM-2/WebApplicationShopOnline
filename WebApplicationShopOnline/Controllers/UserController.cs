using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;
        public UserController()
        {
            _userRepository = new UserRepository();
        }

        // Действие для отображения данных пользователя
        //public IActionResult Details()
        //{
        //    // Получаем query-параметры из URL
        //    int idUser = int.Parse(Request.Query["IdUser"]);
        //    string name = Request.Query["Name"];
        //    string login = Request.Query["Login"];
        //    string password = Request.Query["Password"];
        //    string telephone = Request.Query["Telephone"];
        //    string email = Request.Query["Email"];

        //    var user = new User
        //    {
        //        IdUser = idUser,
        //        Name = name,
        //        Login = login,
        //        Password = password,
        //        Telephone = telephone,
        //        Email = email
        //    };

        //    return View(user);
        //}

        //public IActionResult Users()
        //{
        //    return View();
        //}


        public IActionResult Users(string searchName)
        {
            if (!string.IsNullOrEmpty(searchName))
            {
                var user = _userRepository.FindUserByName(searchName);
                if (user != null)
                {
                    return View("Details", user);
                }
                else
                {
                    ViewBag.Message = "Такой пользователь не найден";
                    return View(_userRepository.GetAllUsers());
                }
            }
            return View(_userRepository.GetAllUsers());
        }

        public IActionResult Details(int id)
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