

using OnlineShop.DB.Models;

namespace WebApplicationShopOnline.Data
{
    public class UserRepository
    {
        static List<OnlineShop.DB.Models.User> users = new List<User>
        {
            new User("Stas", "Admin1", "Aa123456", "+79999999", "email@com"),
            new User("Anna", "Admin2", "Aa123456", "+7229339", "email@com"),
            new User("Alan", "Alan4ik", "Aa123456", "+444444", "alan254@google.com"),
        };

        public List<User> GetAll()
        {
            return users;
        }

        public User? TryGetById(string idUser)
        {
            return users.FirstOrDefault(user => user.Id == idUser);
        }
    }
}
