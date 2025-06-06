using Microsoft.AspNetCore.Mvc;
using WebApplicationStart.Data;
using WebApplicationStart.Models;

namespace WebApplicationStart.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        public IActionResult Index(string searchName)
        {
            // Если есть поисковый запрос
            if (!string.IsNullOrEmpty(searchName))
            {
                var foundUser = _userRepository.GetAll()
                    .FirstOrDefault(u => u.Name.Contains(searchName, StringComparison.OrdinalIgnoreCase));

                if (foundUser != null)
                {
                    return View(new List<User> { foundUser });
                }

                ViewBag.Message = "Пользователь не найден";
                return View(new List<User>());
            }

            // Если поиска нет - возвращаем всех пользователей
            return View(_userRepository.GetAll());
        }

        public IActionResult Details(int id)
        {
            var user = _userRepository.TryGetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Генерируем новый ID
                var newId = _userRepository.GetAll().Max(u => u.IdUser) + 1;
                user.IdUser = newId;

                _userRepository.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}