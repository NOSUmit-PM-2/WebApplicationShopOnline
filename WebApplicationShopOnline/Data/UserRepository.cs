using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class UserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User("Яна", "Yana05", "12345", "+77777777777", "yana@mail.ru"),
            new User("Давид", "David06", "11111", "+88888888888", "david@mail.ru"),
            new User("Арсен", "Arsen05", "22222", "+99999999999", "arsen@mail.ru")
        };

        public List<User> GetUsers()
        { 
            return users;
        }

        public User TryGetById(int id) 
        {
            return users.FirstOrDefault(user => user.IdUser == id);
        }
    

    }
}
