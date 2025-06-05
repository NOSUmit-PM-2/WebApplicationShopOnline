using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class StartController : Controller
    {
        public IActionResult Hello()
        {
            var currentTime = System.DateTime.Now;

            string greeting;
            if (currentTime.Hour >= 0 && currentTime.Hour < 6)
            {
                greeting = "Доброй ночи";
            }
            else if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                greeting = "Доброе утро";
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                greeting = "Добрый день";
            }
            else
            {
                greeting = "Добрый вечер";
            }

            return Content(greeting);
        }
    }
}