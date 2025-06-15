using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationShopOnline.Models;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Tasks()
        {
            return View();
        }

        public string Task1()
        {
            var Hour = DateTime.Now.Hour;

            if (Hour >= 0 && Hour < 6) return "Ноччь";
            if (Hour >= 6 && Hour < 12) return "Утро";
            if (Hour >= 12 && Hour < 18) return "День";

            return "Вечер";
        }

        public string Task2(int a, int b)
        {
            return Convert.ToString(a + b);
        }
        public string Task3_4(int a, int b, string sign)
        {
            if (sign == "+") return Convert.ToString(a + b);
            if (sign == "-") return Convert.ToString(a - b);
            if (sign == "*") return Convert.ToString(a * b);
            if (sign == "/") return Convert.ToString(a / b);
            else return "Ошибка.Такого оператора нет";

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}