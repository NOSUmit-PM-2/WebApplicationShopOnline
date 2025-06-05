using OnlineShop.DB.Models;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class UserRepository
    {
        static List<UserView> users = new List<UserView>
        {
            new UserView("Geor", "Geor107", "Aa123456", "+79999", "Geor1007email@com"),
            new UserView("Ae", "Admin2", "Aa123456", "+1413419", "email@com"),
            new UserView("Mara", "Mara21", "Aa123456", "+44413314444", "Mara@gami.com"),
        };

        public List<UserView> GetAll()
        {
            return users;
        }

        public UserView TryGetById(Guid idUser)
        {
            return users.FirstOrDefault(user => user.IdUser == idUser);
        }
    }
}
