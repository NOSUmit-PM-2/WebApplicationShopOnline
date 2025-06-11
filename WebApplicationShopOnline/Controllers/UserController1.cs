// Controllers/UserController.cs
using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Models;
using WebApplicationShopOnline.Repositories;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string search)
        {
            ViewData["CurrentFilter"] = search;

            if (!string.IsNullOrEmpty(search))
            {
                var users = _repository.SearchByName(search);
                ViewBag.SearchPerformed = true;
                return View(users);
            }

            return View(_repository.GetAll());
        }

        public IActionResult Details(int id)
        {
            var user = _repository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
    }
}