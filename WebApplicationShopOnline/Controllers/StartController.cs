using Microsoft.AspNetCore.Mvc;

namespace WebApplicationShopOnline.Controllers
{
    public class StartController : Controller
    {
        // GET: /Start/Index
        public IActionResult Index()
        {
            return View(); // Вернет представление /Views/Start/Index.cshtml
        }

        // GET: /Start/Hello
        public string Hello()
        {
            var currentTime = DateTime.Now.TimeOfDay;

            if (currentTime >= new TimeSpan(0, 0, 0) && currentTime < new TimeSpan(6, 0, 0))
            {
                return "Доброй ночи";
            }
            else if (currentTime >= new TimeSpan(6, 0, 0) && currentTime < new TimeSpan(12, 0, 0))
            {
                return "Доброе утро";
            }
            else if (currentTime >= new TimeSpan(12, 0, 0) && currentTime < new TimeSpan(18, 0, 0))
            {
                return "Добрый день";
            }
            else
            {
                return "Добрый вечер";
            }
        }
    }
}