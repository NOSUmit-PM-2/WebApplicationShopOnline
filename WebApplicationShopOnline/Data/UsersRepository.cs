using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class UsersRepository
    {
        static List<UserViewModel> users = new List<UserViewModel>
        {
            new UserViewModel("Хетаг", "Heka", "Aa123456", "+1311", "HekaGekae@com.cr"),
            new UserViewModel("David", "Dava213", "Aa123456", "+13413414", "Davidik@mail.com"),
        };

        public UserViewModel GetById(int userId)
        {
            return users.FirstOrDefault(user => user.IdUser == userId);
        }

        public List<UserViewModel> GetUsers()
        {
            return users;
        }

    }
}
