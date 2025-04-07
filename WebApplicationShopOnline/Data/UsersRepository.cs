using WebApplicationShopOnline.Models;
using System.Linq;

namespace WebApplicationShopOnline.Data
{
    public class UsersRepository : InterfUsersRepository
    {
        static List<User> users = new List<User>
        {
            new User("Аслан", "aslan", "aas12", "+89280000000", "aslan@yandex.ru"),
            new User("Кира", "kira", "rikk", "+89281000000", "rikitiki2@yandex.ru")
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