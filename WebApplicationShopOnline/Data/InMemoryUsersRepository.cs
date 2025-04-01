using WebApplicationShopOnline.Models;
using System.Linq;

namespace WebApplicationShopOnline.Data
{
    public class InMemoryUsersRepository : IUsersRepository
    {
        static List<User> users = new List<User>
        {
            new User("Имя1", "login1", "1234", "+77777777771", "mail1@mail1.com"),
            new User("Имя2", "login2", "1234", "+77777777772", "mail2@mail2.com")
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
