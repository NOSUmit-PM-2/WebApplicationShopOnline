using WebApplicationShopOnline.Models;

namespace WebApplicationShopOnline.Data
{
    public class UserRepository : IUserRepository
    {
        List<User> users = new List<User>
        {
            new User(
                name: "Иван Иванов",
                email: "ivanov@example.com",
                password: "SecurePass123",
                telephone: "+79123456789"
            ),
            new User(
                name: "Елена Петрова",
                email: "epetrova@mail.ru",
                password: "Elena2023!",
                telephone: "+79234567890"
            ),
            new User(
                name: "Алексей Смирнов",
                email: "asmirnov@gmail.com",
                password: "Alex@1985",
                telephone: "+79031234567"
            )
        };

        public List<User> GetAll()
        {
            return users;
        }

        public void Add(User user)
        {
            users.Add(user);
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
