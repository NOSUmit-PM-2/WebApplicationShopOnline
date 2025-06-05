using System.Text.Json;
using WebApplicationShopOnline.Models;

namespace OnlineShop.Models
{
    public class UserRepository
    {
        private List<User> users;

        public UserRepository(string jsonFilePath)
        {
            // Загрузка пользователей из JSON-файла
            LoadUsersFromJson(jsonFilePath);
        }

        private void LoadUsersFromJson(string jsonFilePath)
        {
            try
            {
                // Чтение JSON-файла
                string jsonString = File.ReadAllText(jsonFilePath);

                // Десериализация JSON в список пользователей
                users = JsonSerializer.Deserialize<List<User>>(jsonString) ?? new List<User>();
            }
            catch (Exception ex)
            {
                // Логирование ошибки
                Console.WriteLine($"Ошибка при чтении JSON: {ex.Message}");
                users = new List<User>();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.IdUser == id);
        }

        public User FindUserByName(string name)
        {
            return users.FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}