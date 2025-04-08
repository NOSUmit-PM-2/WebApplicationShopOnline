using System.Text.Json;
using System.Text.Json.Serialization;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class UsersJsonRepository:IUserRepository
    {
        List<User> users;

        public UsersJsonRepository()
        {
            string json = File.ReadAllText(@"Data\users.json");
            users = JsonSerializer.Deserialize<List<User>>(json);

        }

        public void Add(User user)
        {
            users.Add(user);
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User? GetByName(string name)
        {
            return users.FirstOrDefault(u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public User? GetById(Guid id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
    }
}
