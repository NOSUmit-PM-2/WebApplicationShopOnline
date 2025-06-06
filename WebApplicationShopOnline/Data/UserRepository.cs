using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class UserRepository
    {
        static List<User> users = new List<User>
        {
            new User("Давид", "+77777777777", "DavidGerg",  "miumiu", "david@yandex.ru"),
            new User("Арсен", "+77777777777", "Vozduh", "pupupu", "arsen@yandex.ru")
        };

        public List<User> GetAll()
        {
            return users;
        }

        public User TryGetById(Guid id)
        {
            return users.FirstOrDefault(user => user.IdUser == id);
        }
    }
}
