
//не придумала, как адекватно этот файл назвать

using System.Text.Json;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class InJSONUsersRepository : InterfUsersRepository
    {
        private List<User> users;

        public InJSONUsersRepository()
        {
            string jsonData = File.ReadAllText("Data/users.json");
            users = JsonSerializer.Deserialize<List<User>>(jsonData) ?? new List<User>();
        }

        public List<User> GetAll()
        {
            var userList = new List<User>(users);
            return userList;
        }

        public User TryGetById(int id)
        {
            return users.FirstOrDefault(u => u.IdUser == id);
        }
    }
}
