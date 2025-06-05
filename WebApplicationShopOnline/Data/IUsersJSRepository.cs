using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface IUsersJSRepository
    {
        void Add(User user);
        List<User> GetAll();
        User TryGetById(Guid id);
        void Updata(UserEdit user);
        User TryGetByEmail(string email);
        bool UserExists(string email);
        bool ValidateUser(string email, string password);
    }
}