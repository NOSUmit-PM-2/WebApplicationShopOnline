using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
         readonly UserRepository userRepository = new UserRepository();

        public IActionResult Index(Guid id)
        {
            User user = userRepository.TryGetById(id);
            if (user != null)
                return View(user);
            return NotFound();
        }

        public IActionResult UsersList()
        {
            var users = userRepository.GetAll();
            return View(users);
        }

        public IActionResult Search(string sname)
        {
            var user = userRepository.GetAll().FirstOrDefault(user => user.Name == sname);
            if (user == null)
            {
                return NotFound("Может ты обознался");
            }
            return RedirectToAction("Index", new { id = user.IdUser });
        }


    }

    
}