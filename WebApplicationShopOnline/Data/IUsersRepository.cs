using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface IUsersRepository
    {
        public List<User> GetAll();

        public User TryGetById(int id);
    }
}
