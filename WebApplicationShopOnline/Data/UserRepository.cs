using WebApplicationStart.Models;

namespace WebApplicationStart.Data
{
    public class UserRepository
    {
        public static List<User> users = new List<User>()
        {
            new User(1, "Иван Иванов", "ivan@mail.com", "qwerty123", "ivanov", "+79161234567"),
            new User(2, "Петр Петров", "petr@mail.com", "pass1234", "petrov", "+79261234568"),
            new User(3, "Анна Сидорова", "anna@mail.com", "anna2023", "sidorova", "+79361234569"),
            new User(4, "Мария Кузнецова", "maria@mail.com", "maria777", "kuznetsova", "+79461234570"),
            new User(5, "Алексей Смирнов", "alex@mail.com", "smirnoff", "smirnov", "+79561234571"),
            new User(6, "Елена Волкова", "elena@mail.com", "volkova1", "volkova", "+79661234572"),
            new User(7, "Дмитрий Козлов", "dmitry@mail.com", "kozlovdd", "kozlov", "+79761234573"),
            new User(8, "Ольга Новикова", "olga@mail.com", "novikova8", "novikova", "+79861234574"),
            new User(9, "Сергей Морозов", "sergey@mail.com", "frost2023", "morozov", "+79961234575"),
            new User(10, "Наталья Павлова", "nataly@mail.com", "pavlovan", "pavlova", "+79061234576")
        };
        public List<User> GetAll()
        {
            return users;
        }

        public User TryGetById(int id)
        {
            return users.FirstOrDefault(x => x.IdUser == id);
        }

        public void Add(User user)
        {
            users.Add(user);
        }
    }
}
