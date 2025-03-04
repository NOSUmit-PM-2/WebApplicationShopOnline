using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product prod = new Product("пирожок", "с ливером", 50);
            //ViewBag.Product = prod;
            return View(prod);
        }

        /*public string Index()
        {
            Product prod = new Product("пирожок","с ливером", 50);
            return prod.ToString();
        }*/
    }
}
