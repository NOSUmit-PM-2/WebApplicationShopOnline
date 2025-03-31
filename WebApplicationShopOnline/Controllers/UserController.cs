using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
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

        public IActionResult Index()
        {
            return View();
        }
    }
}
