using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(double num1 = 0, double num2 = 0, string operation = "+")
        {
            if (operation != "+" && operation != "-" && operation != "*")
            {
                return Content("Ошибка: Допустимые операции: +, -, *. Пример: /calculator/index/1/3/+");
            }

            double result = operation switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                _ => 0 // Это никогда не должно произойти, так как проверка выше уже сделана, но C# просит так что пусть будет. 
            };

            string response = $"{num1} {operation} {num2} = {result}";

            return Content(response);
        }
    }
}
