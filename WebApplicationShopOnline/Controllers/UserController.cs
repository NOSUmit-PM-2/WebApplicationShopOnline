using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        readonly IUsersRepository usersRepository;
        public UserController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        public IActionResult Index(int id)
        {
            User user = usersRepository.TryGetById(id);
            if (user == null)
            {
                return null;
            }
            return View(user);
        }
        public IActionResult Catalog()
        {
            var users = usersRepository.GetAll();
            return View(users);
        }

        public IActionResult Search(string userName)
        {
            var user = usersRepository.GetAll().FirstOrDefault(user => user.Name.ToLower() == userName.ToLower());
            if (user == null)
            {
                return View();
            }
            return RedirectToAction("Index", new {id = user.IdUser});
        }
    }
}