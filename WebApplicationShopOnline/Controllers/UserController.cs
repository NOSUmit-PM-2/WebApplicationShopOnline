using Microsoft.AspNetCore.Mvc;
using WebApplicationShopOnline.Data;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository userlist = new UserRepository();

        public IActionResult Index(int id)
        {
            User user = userlist.TryGetById(id);
            if (user != null)
                return View(user);
            return null;
        }

        public IActionResult UsersList()
        {
            var users = userlist.GetUsers();
            return View(users);
        }


    }

    
}