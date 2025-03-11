using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string name, string description, decimal cost)
        {
            Product prod = new Product(name, description, cost);
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
