using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var user = _repository.GetByName(name);
                return View(user);
            }
            return RedirectToAction("Users");
        }

        public IActionResult Users(string? searchName = null)
        {
            if (!string.IsNullOrWhiteSpace(searchName))
            {
                var user = _repository.GetByName(searchName);
                if (user != null)
                {
                    return View(new List<User> { user });
                }
                return View(new List<User>());
            }

            var users = _repository.GetAll();
            return View(users);
        }
    }
}