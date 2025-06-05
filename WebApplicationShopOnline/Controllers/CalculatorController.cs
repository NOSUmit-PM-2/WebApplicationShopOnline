using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index(double a = 0, double b = 0, string operation = "plus")
        {
            if (operation != "plus" && operation != "minus" && operation != "multiply" && operation != "divide")
            {
                return Content("Ошибка: Допустимые операции: +, -, *, /. Используйте словесные обозначения операндов, Пример: /Calculator/index?a=1&b=3&operation=plus");
            }

            double result = operation switch
            {
                "plus" => a + b,
                "minus" => a - b,
                "multiply" => a * b,
                "divide" => b == 0 ? double.NaN : a / b, // Защита от деления на ноль
                _ => 0 // Это никогда не должно произойти, так как проверка выше уже сделана, но C# просит так что пусть будет
            };

            operation = operation switch
            {
                "plus" => "+",
                "minus" => "-",
                "multiply" => "*",
                "divide" => "/",
                _ => "" // Это никогда не должно произойти, так как проверка выше уже сделана, но C# просит так что пусть будет
            };

            string response;
            if (double.IsNaN(result))
            {
                response = $"Ошибка: Деление на ноль недопустимо.";
            }
            else
            {
                response = $"{a} {operation} {b} = {result}";
            }

            return Content(response);
        }
    }
}
