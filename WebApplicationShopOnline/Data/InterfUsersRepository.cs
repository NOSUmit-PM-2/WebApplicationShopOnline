using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public interface InterfUsersRepository
    {
        public List<User> GetAll();

        public User TryGetById(int id);
    }
}