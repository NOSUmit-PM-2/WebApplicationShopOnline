using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class ProductController : Controller
    {
        //public string Index(string name, decimal cost, string description)
        //{
        //    //Product prod = new Product("Пирожок", "Печенный пирожок с мясом", 100);
        //    Product prod = new Product(name, description, cost);
        //    return prod.ToString();
        //}

        //public IActionResult Index(string name, decimal cost, string description)
        //{
        //    Product prod = new Product(name, description, cost);
        //    ViewBag.Product = prod;
        //    return View();
        //}

        public IActionResult Index(string name, decimal cost, string description)
        {
            Product prod = new Product(name, description, cost);
            return View(prod);
        }
    }
}
