using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Xml.Linq;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        readonly InterfUsersRepository usersRepository;
        public UserController(InterfUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        public IActionResult Index(int id)
        {
            User user = usersRepository.TryGetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
        public IActionResult UserList()
        {
            var users = usersRepository.GetAll();
            return View(users);
        }

        public IActionResult Search(string searchName)
        {
            var user = usersRepository.GetAll().FirstOrDefault(user => user.Name == searchName);
            if (user == null)
            {
                return NotFound("Таких не знаем!");
            }
            return RedirectToAction("Index", new { id = user.IdUser });
        }
    }
}