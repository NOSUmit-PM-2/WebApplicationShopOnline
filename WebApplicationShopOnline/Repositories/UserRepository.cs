using System.Collections.Generic;
using System.Linq;

namespace WebApplicationShopOnline.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public UserRepository()
        {
            // Инициализация тестовых данных
            _users = new List<User>
            {
                new User { IdUser = 1, Name = "Иван Петров", Login = "ivan", Password = "password123", Telephone = "+7(999)123-45-67", Email = "ivan@example.com" },
                new User { IdUser = 2, Name = "Анна Сидорова", Login = "anna", Password = "password456", Telephone = "+7(999)234-56-78", Email = "anna@example.com" },
                new User { IdUser = 3, Name = "Петр Иванов", Login = "petr", Password = "password789", Telephone = "+7(999)345-67-89", Email = "petr@example.com" }
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.IdUser == id);
        }

        public User GetUserByName(string name)
        {
            return _users.FirstOrDefault(u => u.Name.ToLower().Contains(name.ToLower()));
        }
    }
}