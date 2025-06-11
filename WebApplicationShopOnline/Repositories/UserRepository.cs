// Repositories/UserRepository.cs
using System.Collections.Generic;
using System.Linq;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User1> GetAll(); 
        User1 GetById(int id);       
        IEnumerable<User1> SearchByName(string name); 
    }

    public class UserRepository : IUserRepository
    {
        private readonly List<User1> _users = new()  
        {
            new User1 { IdUser = 1, Name = "Марта", Login = "marta", Password = "admin123", Telephone = "1234567890", Email = "marta@gmail.com" },
            new User1 { IdUser = 2, Name = "Ира", Login = "irka", Password = "pass123", Telephone = "79123456789", Email = "irka@mail.ru" },
            new User1 { IdUser = 3, Name = "Сюзанна", Login = "istok", Password = "qwerty", Telephone = "79234567890", Email = "istok@gmail.com" }
        };

        public IEnumerable<User1> GetAll() => _users;
        public User1 GetById(int id) => _users.FirstOrDefault(u => u.IdUser == id);
        public IEnumerable<User1> SearchByName(string name) =>
            _users.Where(u => u.Name.Contains(name, System.StringComparison.OrdinalIgnoreCase));
    }
}