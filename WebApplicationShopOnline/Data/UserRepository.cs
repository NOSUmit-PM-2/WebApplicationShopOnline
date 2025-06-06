using WebApplicationShopOnline.Models;
using System.Linq;

namespace WebApplicationShopOnline.Data
{
    public class UserRepository
    {
        static List<User> users = new List<User>
        {
            new User("Имя1", "login1", "123", "+11111111111", "1myemail@gmail.com"),
            new User("Имя2", "login2", "456", "+22222222222", "2myemail@gmail.com"),
            new User("Имя2", "login2", "789", "+33333333333", "3myemail@gmail.com")
        };

        public List<User> GetAll()
        {
            return users;
        }

        public User TryGetById(int id)
        {
            return users.FirstOrDefault(user => user.IdUser == id);
        }
    }
}