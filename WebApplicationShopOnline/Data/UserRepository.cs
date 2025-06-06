using OnlineShop.DB.Models;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class UserRepository
    {
        static List<UserView> users = new List<UserView>
        {
            new UserView("Arsen", "Arsen111", "Aa123456", "+7928343", "ArsenKH@mail.ru"),
            new UserView("Klan", "Lan211", "123456", "+89893338321", "KKK@gmail.com"),
            new UserView("Larin", "Rin311", "987654321", "+42123141", "Ringrin@cloud.com"),
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