
//�� ���������, ��� ��������� ���� ���� �������

using System.Text.Json;
using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class ReadingJsonUsersRepository : InterfUsersRepository
    {
        private List<User> users;

        public ReadingJsonUsersRepository()
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
