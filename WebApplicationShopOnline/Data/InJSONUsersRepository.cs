using System.Text.Json;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class InJSONUsersRepository : IUsersRepository
    {
        List<User> users;

        public InJSONUsersRepository()
        {
            var jsonString = File.ReadAllText("Data/users.json");
            users = JsonSerializer.Deserialize<List<User>>(jsonString);
        }

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
