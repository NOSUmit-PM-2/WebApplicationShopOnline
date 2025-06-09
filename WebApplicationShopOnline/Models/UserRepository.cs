namespace WebApplicationShopOnline.Models
{
    public class UserRepository
    {
        private static List<User> Users = new List<User>
        {
            new User { IdUser = 1, Name = "Иван", Login = "ivan123", Password = "pass1", Telephone = "+79001234567", Email = "ivan@example.com" },
            new User { IdUser = 2, Name = "Мария", Login = "maria", Password = "pass2", Telephone = "+79007654321", Email = "maria@example.com" },
            new User { IdUser = 3, Name = "Алексей", Login = "alex", Password = "pass3", Telephone = "+79001122334", Email = "alex@example.com" }
        };

        public List<User> GetAllUsers() => Users;

        public User GetUserById(int id) => Users.FirstOrDefault(u => u.IdUser == id);

        public List<User> SearchUserByName(string name) =>
            Users.Where(u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
