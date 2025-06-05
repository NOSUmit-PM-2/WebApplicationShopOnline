using Microsoft.AspNetCore.Mvc;

namespace WebApplicationShopOnline.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(double num1 = 0, double num2 = 0)
        {
            double result = num1 + num2;

            string response = $"{num1} + {num2} = {result}";

            return Content(response);
        }
    }
}